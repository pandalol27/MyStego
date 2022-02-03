using System.Data;
using System.Text;
using System.Collections;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace MyStego
{
    public partial class MyStego : Form
    {
        public MyStego()
        {
            InitializeComponent();


            buttonEncryptText.Enabled = false;
            buttonSaveTextEncryption.Enabled = false;
            groupBoxFileEncryption.Hide();
            groupBoxExtractFile.Hide();
            buttonEncryptFile.Enabled = false;
            buttonSaveAsEncrypted.Enabled = false;
            buttonTextExtraction.Enabled = false;
            buttonExtractAndSave.Enabled = false;
            textBoxProgress.Hide();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Bitmap originalImage;
        Bitmap stegoImage;
        byte[] data;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=mystego";

        private byte getByte(byte[] bits)
        {
            String bitString = "";
            for (int i = 0; i < 8; i++)
                bitString += bits[i];
            byte newPixel = Convert.ToByte(bitString, 2);
            int dePixel = (int)newPixel;
            return (byte)dePixel;
        }

        private byte[] getStringBits(string dataToHide)
        {
            byte[] text = System.Text.ASCIIEncoding.ASCII.GetBytes(dataToHide);
            BitArray bits = new BitArray(text);
            bool[] boolArray = new bool[bits.Count];
            bits.CopyTo(boolArray, 0);
            byte[] bitsArray = boolArray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }

        private byte[] getBits(byte coloredPixel)
        {
            int currentPixel = 0;
            currentPixel = (int)coloredPixel;
            BitArray bits = new BitArray(new byte[] { (byte)currentPixel });
            bool[] boolArray = new bool[bits.Count];
            bits.CopyTo(boolArray, 0);
            byte[] bitsArray = boolArray.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);
            return bitsArray;
        }

        public void binaryRead()
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string pathOfFile = openFileDialog1.FileName;

                try
                {
                    using (FileStream fs = File.Open(pathOfFile, FileMode.Open))
                    {
                        data = new BinaryReader(fs).ReadBytes((int)fs.Length);
                    }
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Error! Couldn't open file" + ioe.Message);
                }
            }
        }

        public Color encrypt(Color currentPixel, byte[] bits)
        {

            byte[] RedBits = getBits((byte)currentPixel.R);
            byte[] GreenBits = getBits((byte)currentPixel.G);
            byte[] BlueBits = getBits((byte)currentPixel.B);

            RedBits[5] = bits[0];
            RedBits[6] = bits[1];
            RedBits[7] = bits[2];
            GreenBits[5] = bits[3];
            GreenBits[6] = bits[4];
            GreenBits[7] = bits[5];
            BlueBits[6] = bits[6];
            BlueBits[7] = bits[7];

            byte newRed = getByte(RedBits);
            byte newGreen = getByte(GreenBits);
            byte newBlue = getByte(BlueBits);

            return Color.FromArgb(newRed, newGreen, newBlue);

        }

        public byte extract(Color currentPixel)
        {
            byte[] RedBits = getBits((byte)currentPixel.R);
            byte[] GreenBits = getBits((byte)currentPixel.G);
            byte[] BlueBits = getBits((byte)currentPixel.B);
            byte[] BitsToDecrypt = new byte[8];

            BitsToDecrypt[0] = RedBits[5];
            BitsToDecrypt[1] = RedBits[6];
            BitsToDecrypt[2] = RedBits[7];
            BitsToDecrypt[3] = GreenBits[5];
            BitsToDecrypt[4] = GreenBits[6];
            BitsToDecrypt[5] = GreenBits[7];
            BitsToDecrypt[6] = BlueBits[6];
            BitsToDecrypt[7] = BlueBits[7];

            return getByte(BitsToDecrypt);
        }

        private void buttonBrowseEncryption_Click(object sender, EventArgs e)
        {
            
            ofd = new OpenFileDialog();
            ofd.Filter = "All picture files|*.bmp; *.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.tif;*.tiff;*.gif;*.png|Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|TIFF (*.tif,*.tiff)|*.tif;*.tiff|GIF (*.gif)|*.gif|PNG (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                pictureBoxOriginalImage.ImageLocation = ofd.FileName;
                textBoxBrowseOriginal.Text = ofd.FileName;

                Bitmap img = new Bitmap(ofd.FileName);
                labelImageSize.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);

                if (string.IsNullOrEmpty(richTextBoxEncryption.Text) == false)
                {
                    buttonEncryptText.Enabled = true;
                }
                if (string.IsNullOrEmpty(textBoxFileOpenEncryption.Text) == false)
                {
                    buttonEncryptFile.Enabled = true;
                }
            }

        }

        private void richTextPlain_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBrowseOriginal.Text) == false)
            {
                buttonEncryptText.Enabled = true;
            }
        }

        private void buttonEncryptText_Click(object sender, EventArgs e)
        {
            string hiddenMessage = richTextBoxEncryption.Text;
            char[] hiddenMessageArray = richTextBoxEncryption.Text.ToArray();

            originalImage = new Bitmap(pictureBoxOriginalImage.Image);
            labelProgress.Text = "";
            labelTextSize.Text = "Text length: " + Convert.ToString(hiddenMessage.Length) + " characters";

            if (textBoxKEY.Text.ToString() == "")
            {
                MessageBox.Show("You need to enter a key before encrypting your information!");
            }
            else if (textBoxKEY.Text.ToString().Length > 3)
            {
                MessageBox.Show("Your key must contain only 3 symbols!");
            }
            else
            {
                string[] key = new string[] { textBoxKEY.Text[0].ToString(), textBoxKEY.Text[1].ToString(), textBoxKEY.Text[2].ToString() };

                for (int i = 0; i < 3; i++)
                {
                    Color pixel = originalImage.GetPixel(originalImage.Width - i - 1, originalImage.Height - 1);
                    pixel = encrypt(pixel, getStringBits(key[i]));
                    originalImage.SetPixel(originalImage.Width - i - 1, originalImage.Height - 1, pixel);
                }

                string messageLength = Convert.ToString((richTextBoxEncryption.Text).Length);
                messageLength = messageLength.PadLeft(13, '0');
                char[] messageLengthArray = messageLength.ToArray();

                for (int i = 3; i < 16; i++)
                {
                    string msgString = Convert.ToString(messageLengthArray[i - 3]);
                    Color pixel = originalImage.GetPixel(originalImage.Width - i - 1, originalImage.Height - 1);
                    pixel = encrypt(pixel, getStringBits(msgString));
                    originalImage.SetPixel(originalImage.Width - i - 1, originalImage.Height - 1, pixel);
                }

                int k = 0;
                progressBarEncryption.Minimum = 0;
                progressBarEncryption.Maximum = hiddenMessage.Length - 1;
                labelProgress.Text = "Processing...";

                for (int i = 0; i < originalImage.Height; i++)
                {
                    for (int j = 0; j < originalImage.Width; j++)
                    {
                        if (k < hiddenMessage.Length)
                        {
                            string hiddenmsg = Convert.ToString(hiddenMessageArray[i + j]);
                            Color pixel = originalImage.GetPixel(j, i);
                            pixel = encrypt(pixel, getStringBits(hiddenmsg));
                            originalImage.SetPixel(j, i, pixel);
                            progressBarEncryption.Value = k;
                            k++;
                        }

                    }
                }

                labelProgress.Text = "Completed!";
            }

            buttonSaveTextEncryption.Enabled = true;
        }

        private void buttonSaveTextEncryption_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveEncryptedText = new SaveFileDialog();
            saveEncryptedText.Filter = "Bitmap files (*.bmp)|*.bmp";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd;

            string pathEncrypted = "";

            if (saveEncryptedText.ShowDialog() == DialogResult.OK)
            {
                pathEncrypted = saveEncryptedText.FileName;
            }

            try
            {
                MemoryStream ms = new MemoryStream();
                originalImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] stegoImg = ms.ToArray();

                originalImage.Save(pathEncrypted);

                string cmdString = "INSERT INTO images_stego(stego_image_id, stego_image) VALUES(@stego_image_id, @stego_image)";
                cmd = new MySqlCommand(cmdString, con);
                cmd.Parameters.Add("@stego_image_id", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@stego_image", MySqlDbType.MediumBlob);
                cmd.Parameters["@stego_image_id"].Value =saveEncryptedText.FileName;
                cmd.Parameters["@stego_image"].Value = stegoImg;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MemoryStream ms2 = new MemoryStream();
                pictureBoxOriginalImage.Image.Save(ms2, pictureBoxOriginalImage.Image.RawFormat);
                byte[] origImg = ms2.ToArray();

                string cmdString2 = "INSERT INTO image_normal(image, stego_image_id) VALUES(@image, @stego_image_id)";
                cmd = new MySqlCommand(cmdString2, con);
                cmd.Parameters.Add("@image", MySqlDbType.MediumBlob);
                cmd.Parameters.Add("@stego_image_id", MySqlDbType.VarChar, 100);
                cmd.Parameters["@image"].Value = origImg;
                cmd.Parameters["@stego_image_id"].Value = saveEncryptedText.FileName;

                con.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Your stego image has been successfully saved in the following path!\n" + pathEncrypted);
                }
                con.Close();

                pictureBoxOriginalImage.Image = originalImage;
               
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Error while writing file!" + ioe.Message);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            binaryRead();
            textBoxFileOpenEncryption.Text = openFileDialog1.FileName;
            if (pictureBoxOriginalImage.Image != null) buttonEncryptFile.Enabled = true;
        }

        private void buttonEncryptFile_Click(object sender, EventArgs e)
        {
            string pathOfFile = openFileDialog1.FileName;
            string nameOfFile = openFileDialog1.SafeFileName;

            labelProgress.Text = "Processing...";

            using (FileStream fs = File.Open(pathOfFile, FileMode.Open))
            {
                data = new BinaryReader(fs).ReadBytes((int)fs.Length);
            }

            originalImage = new Bitmap(textBoxBrowseOriginal.Text);

            if (data.Length > originalImage.Height * originalImage.Width - 30)
            {

                MessageBox.Show("Your data is larger than the image size!");
            }
            else
            {
                if (textBoxKEY.Text.ToString() == "")
                {
                    MessageBox.Show("You need to enter a key before encrypting your information!");
                }
                else if (textBoxKEY.Text.ToString().Length > 3)
                {
                    MessageBox.Show("Your key must contain only 3 symbols!");
                }
                else
                {
                    string[] key = { textBoxKEY.Text[0].ToString(), textBoxKEY.Text[1].ToString(), textBoxKEY.Text[2].ToString() };

                    for (int i = 0; i < 3; i++)
                    {
                        Color pixel = originalImage.GetPixel(originalImage.Width - i - 1, originalImage.Height - 1);
                        pixel = encrypt(pixel, getStringBits(key[i]));
                        originalImage.SetPixel(originalImage.Width - i - 1, originalImage.Height - 1, pixel);
                    }

                    string fileLength = (Convert.ToString(data.Length)).PadLeft(13, '0');
                    char[] fileLengthArray = fileLength.ToArray();

                    for (int i = 3; i < 16; i++)
                    {
                        string fileLengthString = Convert.ToString(fileLengthArray[i - 3]);
                        Color pixel = originalImage.GetPixel(originalImage.Width - i - 1, originalImage.Height - 1);
                        pixel = encrypt(pixel, getStringBits(fileLengthString));
                        originalImage.SetPixel(originalImage.Width - i - 1, originalImage.Height - 1, pixel);
                    }

                    string nameLength = Convert.ToString(nameOfFile.Length).PadLeft(4, '0');
                    char[] nameLengthArray = nameLength.ToArray();

                    for (int i = 16; i < 20; i++)
                    {
                        string nameLengthString = Convert.ToString(nameLengthArray[i - 16]);
                        Color pixel = originalImage.GetPixel(originalImage.Width - i - 1, originalImage.Height - 1);
                        pixel = encrypt(pixel, getStringBits(nameLengthString));
                        originalImage.SetPixel(originalImage.Width - i - 1, originalImage.Height - 1, pixel);
                    }

                    char[] fileNameArray = nameOfFile.ToArray();

                    for (int i = 20; i < 20 + nameOfFile.Length; i++)
                    {
                        string fileNameString = Convert.ToString(fileNameArray[i - 20]);
                        Color pixel = originalImage.GetPixel(originalImage.Width - i - 1, originalImage.Height - 1);
                        pixel = encrypt(pixel, getStringBits(fileNameString));
                        originalImage.SetPixel(originalImage.Width - i - 1, originalImage.Height - 1, pixel);
                    }

                    int k = 0;
                    progressBarEncryption.Minimum = 0;
                    progressBarEncryption.Maximum = data.Length - 1;

                    for (int i = 0; i < originalImage.Height; i++)
                    {
                        for (int j = 0; j < originalImage.Width; j++)
                        {
                            if (k < data.Length)
                            {
                                Color pixel = originalImage.GetPixel(j, i);
                                pixel = encrypt(pixel, getBits(data[k]));
                                originalImage.SetPixel(j, i, pixel);
                                progressBarEncryption.Value = k;
                                k++;
                            }
                        }
                    }

                    HiddenFileEncryption.Image = originalImage;
                    labelProgress.Text = "Completed!";
                    buttonSaveAsEncrypted.Enabled = true;

                }
            }
            }

            private void buttonSaveAsEncrypted_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveEncryptedFile = new SaveFileDialog();
            saveEncryptedFile.Filter = "Bitmap files (*.bmp)|*.bmp";
            string pathOfEncryptedFile = "";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd;

            if (saveEncryptedFile.ShowDialog() == DialogResult.OK)
            {
                pathOfEncryptedFile = saveEncryptedFile.FileName;
            }

            try
            {
                originalImage.Save(pathOfEncryptedFile);

                MemoryStream ms = new MemoryStream();
                originalImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] stegoImg = ms.ToArray();

                string cmdString = "INSERT INTO images_stego(stego_image_id, stego_image) VALUES(@stego_image_id, @stego_image)";
                cmd = new MySqlCommand(cmdString, con);
                cmd.Parameters.Add("@stego_image_id", MySqlDbType.VarChar, 100);
                cmd.Parameters.Add("@stego_image", MySqlDbType.MediumBlob);
                cmd.Parameters["@stego_image_id"].Value = saveEncryptedFile.FileName;
                cmd.Parameters["@stego_image"].Value = stegoImg;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MemoryStream ms2 = new MemoryStream();
                pictureBoxOriginalImage.Image.Save(ms2, pictureBoxOriginalImage.Image.RawFormat);
                byte[] origImg = ms2.ToArray();

                string cmdString2 = "INSERT INTO image_normal(image, stego_image_id) VALUES(@image, @stego_image_id)";
                cmd = new MySqlCommand(cmdString2, con);
                cmd.Parameters.Add("@image", MySqlDbType.MediumBlob);
                cmd.Parameters.Add("@stego_image_id", MySqlDbType.VarChar, 100);
                cmd.Parameters["@image"].Value = origImg;
                cmd.Parameters["@stego_image_id"].Value = saveEncryptedFile.FileName;
                con.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Your stego image has been successfully saved in the following path!\n" + pathOfEncryptedFile);
                }
                con.Close();
                
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Something went wrong while writing the file! Try again." + ioe.Message);
            }
        }

        private void radioButtonEncryptFile_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxFileEncryption.Show();
            groupBoxTextEncryption.Hide();
        }

        private void radioButtonEncryptText_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxFileEncryption.Hide();
            groupBoxTextEncryption.Show();
        }

        private void buttonBrowseExraction_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Bitmap files (*.bmp,*.dib)|*.bmp;*.dib|PNG (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStegoImage.ImageLocation = ofd.FileName;
                textBoxBrowseStego.Text = ofd.FileName;

                stegoImage = new Bitmap(ofd.FileName);
                String keyProgress = "";
                string[] keyStringArray = new string[3];

                for (int i = 0; i < 3; i++)
                {
                    Color pixelToDecrypt = stegoImage.GetPixel(stegoImage.Width - i - 1, stegoImage.Height - 1);
                    byte keyDecrypt = extract(pixelToDecrypt);
                    keyStringArray[i] = Encoding.ASCII.GetString(BitConverter.GetBytes(keyDecrypt));
                    keyProgress += keyStringArray[i];
                }

                String currentKey;
                currentKey = keyProgress.Replace("\0", String.Empty);
                char[] dKey = (currentKey).ToCharArray();

                if (textBoxKEY.Text.ToString() == "")
                {
                    MessageBox.Show("You need to enter a key before extracting your information!");
                }
                else if (textBoxKEY.Text.ToString().Length > 3)
                {
                    MessageBox.Show("Your key must contain only 3 symbols!");
                }
                else
                {
                    if (dKey[0] == textBoxKEY.Text[0] && dKey[1] == textBoxKEY.Text[1] && dKey[2] == textBoxKEY.Text[2])
                    {
                        radioButtonExtractText.Enabled = true;
                        radioButtonExtractText.Checked = true;
                        radioButtonExtractFile.Enabled = true;
                        radioButtonExtractFile.Checked = false;
                        groupBoxExtractText.Show();
                        groupBoxExtractFile.Hide();
                        buttonTextExtraction.Enabled = true;

                        if (string.IsNullOrEmpty(textBoxBrowseStego.Text) == false)
                        {
                            buttonExtractAndSave.Enabled = true;
                        }
                        else
                        {
                            buttonExtractAndSave.Enabled = false;
                        }

                        Bitmap img = new Bitmap(ofd.FileName);
                        labelImageSize2.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);
                    }
                    else if (dKey[0] == textBoxKEY.Text[0] && dKey[1] == textBoxKEY.Text[1] && dKey[2] == textBoxKEY.Text[2])
                    {
                        radioButtonExtractText.Checked = true;
                        radioButtonExtractText.Enabled = true;
                        radioButtonExtractFile.Enabled = true;
                        radioButtonExtractFile.Checked = true;
                        groupBoxExtractFile.Show();
                        groupBoxExtractText.Hide();

                        if (string.IsNullOrEmpty(textBoxBrowseStego.Text) == false)
                        {
                            buttonExtractAndSave.Enabled = true;
                        }
                        else
                        {
                            buttonExtractAndSave.Enabled = false;
                        }

                        Bitmap img = new Bitmap(ofd.FileName);
                        labelImageSize2.Text = "Image size: " + Convert.ToString(img.Width) + " x " + Convert.ToString(img.Height);
                    }
                    else
                    {
                        MessageBox.Show("No hidden data has been found in the selected image or you're using the wrong key!\nChoose another image that has encrypted data to continue!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    textBoxProgress.Hide();
                }
                }
            }

        private void buttonTextExtraction_Click(object sender, EventArgs e)
        {
            stegoImage = new Bitmap(pictureBoxStegoImage.Image);
            richTextBoxExtraction.Text = "";
            int k = 0;
            string TextLength = "";

            for (int i = 3; i < 16; i++)
            {
                Color pixelToDecrypt = stegoImage.GetPixel(stegoImage.Width - i - 1, stegoImage.Height - 1);
                byte decryptLength = extract(pixelToDecrypt);
                TextLength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(decryptLength)));
            }

            int ExtractedTextLength = Convert.ToInt32(TextLength);
            labelTextSize2.Text = "Text length: " + Convert.ToString(ExtractedTextLength) + " characters";

            progressBarExtraction.Minimum = 0;
            progressBarExtraction.Maximum = ExtractedTextLength - 1;

            for (int i = 0; i < stegoImage.Height; i++)
            {
                for (int j = 0; j < stegoImage.Width; j++)
                {
                    if (k < ExtractedTextLength)
                    {
                        Color pixelToDecrypt = stegoImage.GetPixel(j, i);
                        byte DecryptedHiddenMessage = extract(pixelToDecrypt);
                        richTextBoxExtraction.Text += Encoding.ASCII.GetString(BitConverter.GetBytes(DecryptedHiddenMessage));
                        progressBarExtraction.Value = k;
                        k++;
                    }
                }
            }

            labelProgress.Text = "Loading...";
            labelProgress.Text = "Completed!";
        }

        private void buttonExtractAndSave_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            richTextBoxFileExtraction.Text = "> Loading...\n";
            labelProgress.Text = "Processing...";
            stegoImage = new Bitmap(pictureBoxStegoImage.Image);
            int k = 0;
            string fileLength = "";

            for (int i = 3; i < 16; i++)
            {
                Color pixelToDecrypt = stegoImage.GetPixel(stegoImage.Width - i - 1, stegoImage.Height - 1);
                byte fileLengthByte = extract(pixelToDecrypt);
                fileLength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(fileLengthByte)));
            }

            int length = Convert.ToInt32(fileLength);

            string nameLength = "";

            for (int i = 16; i < 20; i++)
            {
                Color pixelToDecrypt = stegoImage.GetPixel(stegoImage.Width - i - 1, stegoImage.Height - 1);
                byte nameLengthByte = extract(pixelToDecrypt);
                nameLength += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(nameLengthByte)));
            }

            int name_length = Convert.ToInt32(nameLength);

            textBox1.Text = "";

            for (int i = 20; i < 20 + name_length; i++)
            {
                Color pixelToDecrypt = stegoImage.GetPixel(stegoImage.Width - i - 1, stegoImage.Height - 1);
                byte lengthByte = extract(pixelToDecrypt);
                textBox1.Text += Encoding.ASCII.GetString(BitConverter.GetBytes(lengthByte));
            }

            string name = textBox1.Text;

            byte[] data = new byte[length]; 

            for (int i = 0; i < stegoImage.Height; i++)
            {

                for (int j = 0; j < stegoImage.Width; j++)
                {
                    if (k < length)
                    {
                        Color pixelToDecrypt = stegoImage.GetPixel(j, i);
                        byte decryptedData = extract(pixelToDecrypt);
                        data[k] = decryptedData;
                        k++;
                    }
                }
            }

            labelProgress.Text = "Completed!";
            string pathDecrypted = Path.GetDirectoryName(ofd.FileName) + "\\" + name;
           
            sw.Stop();
            string time = string.Format("{0} mins, {1} secs", sw.Elapsed.Minutes, sw.Elapsed.Seconds);

            richTextBoxFileExtraction.Text += "> It's done!\n";
            richTextBoxFileExtraction.Text += "> Duration: " + time + "\n\n";

            try
            {
                if (File.Exists(pathDecrypted))
                {
                    if (MessageBox.Show(name + " already exists in this directory!\nDo you want to overwrite?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FileStream write = new FileStream(pathDecrypted, FileMode.Create);
                        BinaryWriter writeBinary = new BinaryWriter(write);
                        writeBinary.Write(data);
                        writeBinary.Close();
                        richTextBoxFileExtraction.Text += "> Extracted file : " + name + "\n";
                        richTextBoxFileExtraction.Text += "> Extraction path: " + Path.GetDirectoryName(ofd.FileName) + "\n\n";
                    }
                }
                else
                {
                    FileStream write = new FileStream(pathDecrypted, FileMode.Create);
                    BinaryWriter writeBinary = new BinaryWriter(write);
                    writeBinary.Write(data);
                    writeBinary.Close();
                    richTextBoxFileExtraction.Text += "> Extracted file : " + name + "\n";
                    richTextBoxFileExtraction.Text += "> Extraction path: " + Path.GetDirectoryName(ofd.FileName) + "\n\n";
                }

            }
            catch (IOException ioe)
            {
                MessageBox.Show("Something went wrong while writing the file in the system!" + ioe.Message);
            }
        }

        private void radioButtonExtractText_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxExtractFile.Hide();
            groupBoxExtractText.Show();
        }

        private void radioButtonExtractFile_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxExtractFile.Show();
            groupBoxExtractText.Hide();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelImageSize.ResetText();
            labelImageSize2.ResetText();
            labelTextSize.ResetText();
            labelTextSize2.ResetText();
            pictureBoxOriginalImage.Image = Properties.Resources.MyStegoInsertIMG;
            pictureBoxStegoImage.Image = Properties.Resources.MyStegoInsertIMG;
            textBoxBrowseOriginal.ResetText();
            textBoxBrowseStego.ResetText();
            textBoxFileOpenEncryption.ResetText();
            richTextBoxExtraction.ResetText();
            richTextBoxEncryption.ResetText();
            richTextBoxFileExtraction.ResetText();
            labelProgress.ResetText();
            progressBarExtraction.Value = 0;
            progressBarEncryption.Value = 0;
            dataNormalPIC.DataSource = GetNormalImg();
            dataStegoPIC.DataSource = GetStegoImg();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string desktopApp = "MyStego";
            string author = "Sylvia Petrova";
            string year = " 2022 ";

            MessageBox.Show("\t" + desktopApp + "\t\n\n\n\t" + author + (char)169 + year + "\n\t" + "\t\t", "About", MessageBoxButtons.OK);
        }


        private void MyStego_Load(object sender, EventArgs e)
        {
            tabPage_Welcome.Show();
            dataNormalPIC.DataSource = GetNormalImg();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataNormalPIC.Columns[0];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataStegoPIC.DataSource = GetStegoImg();
            DataGridViewImageColumn imageColumn2 = new DataGridViewImageColumn();
            imageColumn2 = (DataGridViewImageColumn)dataStegoPIC.Columns[0];
            imageColumn2.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private DataTable GetNormalImg()
        {

            DataTable dtNormal = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = connection.CreateCommand()) 
            {
                connection.Open();
                cmd.CommandText = "SELECT image FROM image_normal";
                MySqlDataReader reader = cmd.ExecuteReader();
                dtNormal.Load(reader);
                connection.Close();
            }
            return dtNormal;

        }

        private DataTable GetStegoImg()
        {
            
            DataTable dtStego = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.CommandText = "SELECT stego_image FROM images_stego";
                MySqlDataReader reader = cmd.ExecuteReader();
                dtStego.Load(reader);
                connection.Close();
                
            }
            return dtStego;

        }

    }
}