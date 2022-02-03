namespace MyStego
{
    partial class MyStego
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyStego));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Welcome = new System.Windows.Forms.TabPage();
            this.pictureBox_ICON = new System.Windows.Forms.PictureBox();
            this.pictureBox_INFO = new System.Windows.Forms.PictureBox();
            this.labelINFO = new System.Windows.Forms.Label();
            this.pictureBox_Welcome = new System.Windows.Forms.PictureBox();
            this.tabPage_Encryption = new System.Windows.Forms.TabPage();
            this.progressBarEncryption = new System.Windows.Forms.ProgressBar();
            this.radioButtonEncryptFile = new System.Windows.Forms.RadioButton();
            this.radioButtonEncryptText = new System.Windows.Forms.RadioButton();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.labelImageSize = new System.Windows.Forms.Label();
            this.textBoxBrowseOriginal = new System.Windows.Forms.TextBox();
            this.buttonBrowseEncryption = new System.Windows.Forms.Button();
            this.pictureBoxOriginalImage = new System.Windows.Forms.PictureBox();
            this.groupBoxFileEncryption = new System.Windows.Forms.GroupBox();
            this.HiddenFileEncryption = new System.Windows.Forms.PictureBox();
            this.textBoxFileOpenEncryption = new System.Windows.Forms.TextBox();
            this.buttonSaveAsEncrypted = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonEncryptFile = new System.Windows.Forms.Button();
            this.groupBoxTextEncryption = new System.Windows.Forms.GroupBox();
            this.labelTextSize = new System.Windows.Forms.Label();
            this.buttonSaveTextEncryption = new System.Windows.Forms.Button();
            this.buttonEncryptText = new System.Windows.Forms.Button();
            this.richTextBoxEncryption = new System.Windows.Forms.RichTextBox();
            this.tabPage_Extraction = new System.Windows.Forms.TabPage();
            this.radioButtonExtractFile = new System.Windows.Forms.RadioButton();
            this.radioButtonExtractText = new System.Windows.Forms.RadioButton();
            this.progressBarExtraction = new System.Windows.Forms.ProgressBar();
            this.groupBoxStegoImage = new System.Windows.Forms.GroupBox();
            this.labelImageSize2 = new System.Windows.Forms.Label();
            this.textBoxBrowseStego = new System.Windows.Forms.TextBox();
            this.buttonBrowseExraction = new System.Windows.Forms.Button();
            this.pictureBoxStegoImage = new System.Windows.Forms.PictureBox();
            this.groupBoxExtractFile = new System.Windows.Forms.GroupBox();
            this.richTextBoxFileExtraction = new System.Windows.Forms.RichTextBox();
            this.buttonExtractAndSave = new System.Windows.Forms.Button();
            this.labelExtractFile = new System.Windows.Forms.Label();
            this.groupBoxExtractText = new System.Windows.Forms.GroupBox();
            this.labelTextSize2 = new System.Windows.Forms.Label();
            this.richTextBoxExtraction = new System.Windows.Forms.RichTextBox();
            this.buttonTextExtraction = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage_Images = new System.Windows.Forms.TabPage();
            this.dataStegoPIC = new System.Windows.Forms.DataGridView();
            this.dataNormalPIC = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProgress = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxProgress = new System.Windows.Forms.TextBox();
            this.textBoxKEY = new System.Windows.Forms.TextBox();
            this.labelKEY = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage_Welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ICON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_INFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Welcome)).BeginInit();
            this.tabPage_Encryption.SuspendLayout();
            this.groupBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).BeginInit();
            this.groupBoxFileEncryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HiddenFileEncryption)).BeginInit();
            this.groupBoxTextEncryption.SuspendLayout();
            this.tabPage_Extraction.SuspendLayout();
            this.groupBoxStegoImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStegoImage)).BeginInit();
            this.groupBoxExtractFile.SuspendLayout();
            this.groupBoxExtractText.SuspendLayout();
            this.tabPage_Images.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStegoPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNormalPIC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Welcome);
            this.tabControl.Controls.Add(this.tabPage_Encryption);
            this.tabControl.Controls.Add(this.tabPage_Extraction);
            this.tabControl.Controls.Add(this.tabPage_Images);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPage_Welcome
            // 
            this.tabPage_Welcome.BackgroundImage = global::MyStego.Properties.Resources.MyStegoBG;
            this.tabPage_Welcome.Controls.Add(this.pictureBox_ICON);
            this.tabPage_Welcome.Controls.Add(this.pictureBox_INFO);
            this.tabPage_Welcome.Controls.Add(this.labelINFO);
            this.tabPage_Welcome.Controls.Add(this.pictureBox_Welcome);
            resources.ApplyResources(this.tabPage_Welcome, "tabPage_Welcome");
            this.tabPage_Welcome.Name = "tabPage_Welcome";
            this.tabPage_Welcome.UseVisualStyleBackColor = true;
            // 
            // pictureBox_ICON
            // 
            this.pictureBox_ICON.Image = global::MyStego.Properties.Resources.KEYICON;
            resources.ApplyResources(this.pictureBox_ICON, "pictureBox_ICON");
            this.pictureBox_ICON.Name = "pictureBox_ICON";
            this.pictureBox_ICON.TabStop = false;
            // 
            // pictureBox_INFO
            // 
            this.pictureBox_INFO.Image = global::MyStego.Properties.Resources.IMGINFO;
            resources.ApplyResources(this.pictureBox_INFO, "pictureBox_INFO");
            this.pictureBox_INFO.Name = "pictureBox_INFO";
            this.pictureBox_INFO.TabStop = false;
            // 
            // labelINFO
            // 
            resources.ApplyResources(this.labelINFO, "labelINFO");
            this.labelINFO.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelINFO.Name = "labelINFO";
            // 
            // pictureBox_Welcome
            // 
            this.pictureBox_Welcome.Image = global::MyStego.Properties.Resources.IMGWELCOME;
            resources.ApplyResources(this.pictureBox_Welcome, "pictureBox_Welcome");
            this.pictureBox_Welcome.Name = "pictureBox_Welcome";
            this.pictureBox_Welcome.TabStop = false;
            // 
            // tabPage_Encryption
            // 
            this.tabPage_Encryption.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage_Encryption.BackgroundImage = global::MyStego.Properties.Resources.MyStegoBG;
            this.tabPage_Encryption.Controls.Add(this.progressBarEncryption);
            this.tabPage_Encryption.Controls.Add(this.radioButtonEncryptFile);
            this.tabPage_Encryption.Controls.Add(this.radioButtonEncryptText);
            this.tabPage_Encryption.Controls.Add(this.groupBoxImage);
            this.tabPage_Encryption.Controls.Add(this.groupBoxFileEncryption);
            this.tabPage_Encryption.Controls.Add(this.groupBoxTextEncryption);
            resources.ApplyResources(this.tabPage_Encryption, "tabPage_Encryption");
            this.tabPage_Encryption.Name = "tabPage_Encryption";
            // 
            // progressBarEncryption
            // 
            this.progressBarEncryption.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.progressBarEncryption, "progressBarEncryption");
            this.progressBarEncryption.Name = "progressBarEncryption";
            // 
            // radioButtonEncryptFile
            // 
            resources.ApplyResources(this.radioButtonEncryptFile, "radioButtonEncryptFile");
            this.radioButtonEncryptFile.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEncryptFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonEncryptFile.Name = "radioButtonEncryptFile";
            this.radioButtonEncryptFile.UseVisualStyleBackColor = false;
            this.radioButtonEncryptFile.CheckedChanged += new System.EventHandler(this.radioButtonEncryptFile_CheckedChanged);
            // 
            // radioButtonEncryptText
            // 
            resources.ApplyResources(this.radioButtonEncryptText, "radioButtonEncryptText");
            this.radioButtonEncryptText.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEncryptText.Checked = true;
            this.radioButtonEncryptText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonEncryptText.Name = "radioButtonEncryptText";
            this.radioButtonEncryptText.TabStop = true;
            this.radioButtonEncryptText.UseVisualStyleBackColor = false;
            this.radioButtonEncryptText.CheckedChanged += new System.EventHandler(this.radioButtonEncryptText_CheckedChanged);
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.labelImageSize);
            this.groupBoxImage.Controls.Add(this.textBoxBrowseOriginal);
            this.groupBoxImage.Controls.Add(this.buttonBrowseEncryption);
            this.groupBoxImage.Controls.Add(this.pictureBoxOriginalImage);
            this.groupBoxImage.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.groupBoxImage, "groupBoxImage");
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.TabStop = false;
            // 
            // labelImageSize
            // 
            resources.ApplyResources(this.labelImageSize, "labelImageSize");
            this.labelImageSize.Name = "labelImageSize";
            // 
            // textBoxBrowseOriginal
            // 
            this.textBoxBrowseOriginal.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.textBoxBrowseOriginal, "textBoxBrowseOriginal");
            this.textBoxBrowseOriginal.Name = "textBoxBrowseOriginal";
            // 
            // buttonBrowseEncryption
            // 
            this.buttonBrowseEncryption.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.buttonBrowseEncryption, "buttonBrowseEncryption");
            this.buttonBrowseEncryption.Name = "buttonBrowseEncryption";
            this.buttonBrowseEncryption.UseVisualStyleBackColor = true;
            this.buttonBrowseEncryption.Click += new System.EventHandler(this.buttonBrowseEncryption_Click);
            // 
            // pictureBoxOriginalImage
            // 
            this.pictureBoxOriginalImage.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxOriginalImage.BackgroundImage = global::MyStego.Properties.Resources.MyStegoInsertIMG;
            resources.ApplyResources(this.pictureBoxOriginalImage, "pictureBoxOriginalImage");
            this.pictureBoxOriginalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            this.pictureBoxOriginalImage.TabStop = false;
            // 
            // groupBoxFileEncryption
            // 
            this.groupBoxFileEncryption.Controls.Add(this.HiddenFileEncryption);
            this.groupBoxFileEncryption.Controls.Add(this.textBoxFileOpenEncryption);
            this.groupBoxFileEncryption.Controls.Add(this.buttonSaveAsEncrypted);
            this.groupBoxFileEncryption.Controls.Add(this.buttonOpenFile);
            this.groupBoxFileEncryption.Controls.Add(this.buttonEncryptFile);
            this.groupBoxFileEncryption.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.groupBoxFileEncryption, "groupBoxFileEncryption");
            this.groupBoxFileEncryption.Name = "groupBoxFileEncryption";
            this.groupBoxFileEncryption.TabStop = false;
            // 
            // HiddenFileEncryption
            // 
            this.HiddenFileEncryption.BackColor = System.Drawing.Color.Ivory;
            this.HiddenFileEncryption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.HiddenFileEncryption, "HiddenFileEncryption");
            this.HiddenFileEncryption.Name = "HiddenFileEncryption";
            this.HiddenFileEncryption.TabStop = false;
            // 
            // textBoxFileOpenEncryption
            // 
            this.textBoxFileOpenEncryption.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.textBoxFileOpenEncryption, "textBoxFileOpenEncryption");
            this.textBoxFileOpenEncryption.Name = "textBoxFileOpenEncryption";
            // 
            // buttonSaveAsEncrypted
            // 
            resources.ApplyResources(this.buttonSaveAsEncrypted, "buttonSaveAsEncrypted");
            this.buttonSaveAsEncrypted.Name = "buttonSaveAsEncrypted";
            this.buttonSaveAsEncrypted.UseVisualStyleBackColor = true;
            this.buttonSaveAsEncrypted.Click += new System.EventHandler(this.buttonSaveAsEncrypted_Click);
            // 
            // buttonOpenFile
            // 
            resources.ApplyResources(this.buttonOpenFile, "buttonOpenFile");
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonEncryptFile
            // 
            resources.ApplyResources(this.buttonEncryptFile, "buttonEncryptFile");
            this.buttonEncryptFile.Name = "buttonEncryptFile";
            this.buttonEncryptFile.UseVisualStyleBackColor = true;
            this.buttonEncryptFile.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // groupBoxTextEncryption
            // 
            this.groupBoxTextEncryption.Controls.Add(this.labelTextSize);
            this.groupBoxTextEncryption.Controls.Add(this.buttonSaveTextEncryption);
            this.groupBoxTextEncryption.Controls.Add(this.buttonEncryptText);
            this.groupBoxTextEncryption.Controls.Add(this.richTextBoxEncryption);
            this.groupBoxTextEncryption.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.groupBoxTextEncryption, "groupBoxTextEncryption");
            this.groupBoxTextEncryption.Name = "groupBoxTextEncryption";
            this.groupBoxTextEncryption.TabStop = false;
            // 
            // labelTextSize
            // 
            resources.ApplyResources(this.labelTextSize, "labelTextSize");
            this.labelTextSize.Name = "labelTextSize";
            // 
            // buttonSaveTextEncryption
            // 
            resources.ApplyResources(this.buttonSaveTextEncryption, "buttonSaveTextEncryption");
            this.buttonSaveTextEncryption.Name = "buttonSaveTextEncryption";
            this.buttonSaveTextEncryption.UseVisualStyleBackColor = true;
            this.buttonSaveTextEncryption.Click += new System.EventHandler(this.buttonSaveTextEncryption_Click);
            // 
            // buttonEncryptText
            // 
            resources.ApplyResources(this.buttonEncryptText, "buttonEncryptText");
            this.buttonEncryptText.Name = "buttonEncryptText";
            this.buttonEncryptText.UseVisualStyleBackColor = true;
            this.buttonEncryptText.Click += new System.EventHandler(this.buttonEncryptText_Click);
            // 
            // richTextBoxEncryption
            // 
            this.richTextBoxEncryption.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.richTextBoxEncryption, "richTextBoxEncryption");
            this.richTextBoxEncryption.Name = "richTextBoxEncryption";
            this.richTextBoxEncryption.TextChanged += new System.EventHandler(this.richTextPlain_TextChanged);
            // 
            // tabPage_Extraction
            // 
            this.tabPage_Extraction.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage_Extraction.BackgroundImage = global::MyStego.Properties.Resources.MyStegoBG;
            this.tabPage_Extraction.Controls.Add(this.radioButtonExtractFile);
            this.tabPage_Extraction.Controls.Add(this.radioButtonExtractText);
            this.tabPage_Extraction.Controls.Add(this.progressBarExtraction);
            this.tabPage_Extraction.Controls.Add(this.groupBoxStegoImage);
            this.tabPage_Extraction.Controls.Add(this.groupBoxExtractFile);
            this.tabPage_Extraction.Controls.Add(this.groupBoxExtractText);
            resources.ApplyResources(this.tabPage_Extraction, "tabPage_Extraction");
            this.tabPage_Extraction.Name = "tabPage_Extraction";
            // 
            // radioButtonExtractFile
            // 
            resources.ApplyResources(this.radioButtonExtractFile, "radioButtonExtractFile");
            this.radioButtonExtractFile.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonExtractFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonExtractFile.Name = "radioButtonExtractFile";
            this.radioButtonExtractFile.UseVisualStyleBackColor = false;
            this.radioButtonExtractFile.CheckedChanged += new System.EventHandler(this.radioButtonExtractFile_CheckedChanged);
            // 
            // radioButtonExtractText
            // 
            resources.ApplyResources(this.radioButtonExtractText, "radioButtonExtractText");
            this.radioButtonExtractText.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonExtractText.Checked = true;
            this.radioButtonExtractText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.radioButtonExtractText.Name = "radioButtonExtractText";
            this.radioButtonExtractText.TabStop = true;
            this.radioButtonExtractText.UseVisualStyleBackColor = false;
            this.radioButtonExtractText.CheckedChanged += new System.EventHandler(this.radioButtonExtractText_CheckedChanged);
            // 
            // progressBarExtraction
            // 
            resources.ApplyResources(this.progressBarExtraction, "progressBarExtraction");
            this.progressBarExtraction.Name = "progressBarExtraction";
            // 
            // groupBoxStegoImage
            // 
            this.groupBoxStegoImage.Controls.Add(this.labelImageSize2);
            this.groupBoxStegoImage.Controls.Add(this.textBoxBrowseStego);
            this.groupBoxStegoImage.Controls.Add(this.buttonBrowseExraction);
            this.groupBoxStegoImage.Controls.Add(this.pictureBoxStegoImage);
            this.groupBoxStegoImage.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.groupBoxStegoImage, "groupBoxStegoImage");
            this.groupBoxStegoImage.Name = "groupBoxStegoImage";
            this.groupBoxStegoImage.TabStop = false;
            // 
            // labelImageSize2
            // 
            resources.ApplyResources(this.labelImageSize2, "labelImageSize2");
            this.labelImageSize2.Name = "labelImageSize2";
            // 
            // textBoxBrowseStego
            // 
            this.textBoxBrowseStego.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.textBoxBrowseStego, "textBoxBrowseStego");
            this.textBoxBrowseStego.Name = "textBoxBrowseStego";
            // 
            // buttonBrowseExraction
            // 
            resources.ApplyResources(this.buttonBrowseExraction, "buttonBrowseExraction");
            this.buttonBrowseExraction.Name = "buttonBrowseExraction";
            this.buttonBrowseExraction.UseVisualStyleBackColor = true;
            this.buttonBrowseExraction.Click += new System.EventHandler(this.buttonBrowseExraction_Click);
            // 
            // pictureBoxStegoImage
            // 
            this.pictureBoxStegoImage.BackColor = System.Drawing.Color.Ivory;
            this.pictureBoxStegoImage.BackgroundImage = global::MyStego.Properties.Resources.MyStegoInsertIMG;
            resources.ApplyResources(this.pictureBoxStegoImage, "pictureBoxStegoImage");
            this.pictureBoxStegoImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStegoImage.Name = "pictureBoxStegoImage";
            this.pictureBoxStegoImage.TabStop = false;
            // 
            // groupBoxExtractFile
            // 
            this.groupBoxExtractFile.Controls.Add(this.richTextBoxFileExtraction);
            this.groupBoxExtractFile.Controls.Add(this.buttonExtractAndSave);
            this.groupBoxExtractFile.Controls.Add(this.labelExtractFile);
            this.groupBoxExtractFile.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.groupBoxExtractFile, "groupBoxExtractFile");
            this.groupBoxExtractFile.Name = "groupBoxExtractFile";
            this.groupBoxExtractFile.TabStop = false;
            // 
            // richTextBoxFileExtraction
            // 
            this.richTextBoxFileExtraction.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.richTextBoxFileExtraction, "richTextBoxFileExtraction");
            this.richTextBoxFileExtraction.Name = "richTextBoxFileExtraction";
            this.richTextBoxFileExtraction.ReadOnly = true;
            // 
            // buttonExtractAndSave
            // 
            resources.ApplyResources(this.buttonExtractAndSave, "buttonExtractAndSave");
            this.buttonExtractAndSave.Name = "buttonExtractAndSave";
            this.buttonExtractAndSave.UseVisualStyleBackColor = true;
            this.buttonExtractAndSave.Click += new System.EventHandler(this.buttonExtractAndSave_Click);
            // 
            // labelExtractFile
            // 
            resources.ApplyResources(this.labelExtractFile, "labelExtractFile");
            this.labelExtractFile.Name = "labelExtractFile";
            // 
            // groupBoxExtractText
            // 
            this.groupBoxExtractText.Controls.Add(this.labelTextSize2);
            this.groupBoxExtractText.Controls.Add(this.richTextBoxExtraction);
            this.groupBoxExtractText.Controls.Add(this.buttonTextExtraction);
            this.groupBoxExtractText.Controls.Add(this.textBox1);
            this.groupBoxExtractText.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.groupBoxExtractText, "groupBoxExtractText");
            this.groupBoxExtractText.Name = "groupBoxExtractText";
            this.groupBoxExtractText.TabStop = false;
            // 
            // labelTextSize2
            // 
            resources.ApplyResources(this.labelTextSize2, "labelTextSize2");
            this.labelTextSize2.Name = "labelTextSize2";
            // 
            // richTextBoxExtraction
            // 
            this.richTextBoxExtraction.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.richTextBoxExtraction, "richTextBoxExtraction");
            this.richTextBoxExtraction.Name = "richTextBoxExtraction";
            this.richTextBoxExtraction.ReadOnly = true;
            // 
            // buttonTextExtraction
            // 
            resources.ApplyResources(this.buttonTextExtraction, "buttonTextExtraction");
            this.buttonTextExtraction.Name = "buttonTextExtraction";
            this.buttonTextExtraction.UseVisualStyleBackColor = true;
            this.buttonTextExtraction.Click += new System.EventHandler(this.buttonTextExtraction_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // tabPage_Images
            // 
            this.tabPage_Images.BackgroundImage = global::MyStego.Properties.Resources.MyStegoBG;
            this.tabPage_Images.Controls.Add(this.dataStegoPIC);
            this.tabPage_Images.Controls.Add(this.dataNormalPIC);
            resources.ApplyResources(this.tabPage_Images, "tabPage_Images");
            this.tabPage_Images.Name = "tabPage_Images";
            this.tabPage_Images.UseVisualStyleBackColor = true;
            // 
            // dataStegoPIC
            // 
            this.dataStegoPIC.AllowUserToAddRows = false;
            this.dataStegoPIC.AllowUserToDeleteRows = false;
            this.dataStegoPIC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStegoPIC.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataStegoPIC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataStegoPIC, "dataStegoPIC");
            this.dataStegoPIC.Name = "dataStegoPIC";
            this.dataStegoPIC.ReadOnly = true;
            this.dataStegoPIC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataStegoPIC.RowTemplate.Height = 200;
            this.dataStegoPIC.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataNormalPIC
            // 
            this.dataNormalPIC.AllowUserToAddRows = false;
            this.dataNormalPIC.AllowUserToDeleteRows = false;
            this.dataNormalPIC.AllowUserToResizeRows = false;
            this.dataNormalPIC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNormalPIC.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataNormalPIC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataNormalPIC, "dataNormalPIC");
            this.dataNormalPIC.Name = "dataNormalPIC";
            this.dataNormalPIC.ReadOnly = true;
            this.dataNormalPIC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataNormalPIC.RowTemplate.Height = 200;
            this.dataNormalPIC.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelVersion
            // 
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelVersion.Name = "labelVersion";
            // 
            // labelProgress
            // 
            resources.ApplyResources(this.labelProgress, "labelProgress");
            this.labelProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelProgress.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelProgress.Name = "labelProgress";
            // 
            // textBoxProgress
            // 
            this.textBoxProgress.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProgress.ForeColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.textBoxProgress, "textBoxProgress");
            this.textBoxProgress.Name = "textBoxProgress";
            // 
            // textBoxKEY
            // 
            this.textBoxKEY.BackColor = System.Drawing.Color.Ivory;
            resources.ApplyResources(this.textBoxKEY, "textBoxKEY");
            this.textBoxKEY.Name = "textBoxKEY";
            // 
            // labelKEY
            // 
            resources.ApplyResources(this.labelKEY, "labelKEY");
            this.labelKEY.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.labelKEY.Name = "labelKEY";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // MyStego
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::MyStego.Properties.Resources.MyStegoBG;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelKEY);
            this.Controls.Add(this.textBoxKEY);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.textBoxProgress);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MyStego";
            this.Load += new System.EventHandler(this.MyStego_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Welcome.ResumeLayout(false);
            this.tabPage_Welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ICON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_INFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Welcome)).EndInit();
            this.tabPage_Encryption.ResumeLayout(false);
            this.tabPage_Encryption.PerformLayout();
            this.groupBoxImage.ResumeLayout(false);
            this.groupBoxImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginalImage)).EndInit();
            this.groupBoxFileEncryption.ResumeLayout(false);
            this.groupBoxFileEncryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HiddenFileEncryption)).EndInit();
            this.groupBoxTextEncryption.ResumeLayout(false);
            this.groupBoxTextEncryption.PerformLayout();
            this.tabPage_Extraction.ResumeLayout(false);
            this.tabPage_Extraction.PerformLayout();
            this.groupBoxStegoImage.ResumeLayout(false);
            this.groupBoxStegoImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStegoImage)).EndInit();
            this.groupBoxExtractFile.ResumeLayout(false);
            this.groupBoxExtractFile.PerformLayout();
            this.groupBoxExtractText.ResumeLayout(false);
            this.groupBoxExtractText.PerformLayout();
            this.tabPage_Images.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStegoPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNormalPIC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private TabControl tabControl;

        private TabPage tabPage_Encryption;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxOriginalImage;
        private System.Windows.Forms.TextBox textBoxBrowseOriginal;
        private System.Windows.Forms.Button buttonBrowseEncryption;
        private System.Windows.Forms.Label labelImageSize;
        private System.Windows.Forms.GroupBox groupBoxTextEncryption;
        private System.Windows.Forms.RadioButton radioButtonEncryptText;
        private System.Windows.Forms.RichTextBox richTextBoxEncryption;
        private System.Windows.Forms.Button buttonEncryptText;
        private System.Windows.Forms.Button buttonSaveTextEncryption;
        private System.Windows.Forms.Label labelTextSize;
        private System.Windows.Forms.GroupBox groupBoxFileEncryption;
        private System.Windows.Forms.RadioButton radioButtonEncryptFile;
        private System.Windows.Forms.PictureBox HiddenFileEncryption;
        private System.Windows.Forms.TextBox textBoxFileOpenEncryption;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonEncryptFile;
        private System.Windows.Forms.Button buttonSaveAsEncrypted;
        private System.Windows.Forms.ProgressBar progressBarEncryption;

        private TabPage tabPage_Extraction;
        private System.Windows.Forms.GroupBox groupBoxStegoImage;
        private System.Windows.Forms.PictureBox pictureBoxStegoImage;
        private System.Windows.Forms.TextBox textBoxBrowseStego;
        private System.Windows.Forms.Button buttonBrowseExraction;
        private System.Windows.Forms.Label labelImageSize2;
        private System.Windows.Forms.GroupBox groupBoxExtractText;
        private System.Windows.Forms.RadioButton radioButtonExtractText;
        private System.Windows.Forms.RichTextBox richTextBoxExtraction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTextExtraction;
        private System.Windows.Forms.Label labelTextSize2;
        private System.Windows.Forms.GroupBox groupBoxExtractFile;
        private System.Windows.Forms.RadioButton radioButtonExtractFile;
        private System.Windows.Forms.RichTextBox richTextBoxFileExtraction;
        private System.Windows.Forms.Label labelExtractFile;
        private System.Windows.Forms.Button buttonExtractAndSave;
        private System.Windows.Forms.TextBox textBoxProgress;
        private System.Windows.Forms.ProgressBar progressBarExtraction;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TabPage tabPage_Images;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxKEY;
        private System.Windows.Forms.Label labelKEY;
        private DataGridView dataNormalPIC;
        private DataGridView dataStegoPIC;
        private TabPage tabPage_Welcome;
        private PictureBox pictureBox_Welcome;
        private Label labelINFO;
        private PictureBox pictureBox_INFO;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox_ICON;
    }
}