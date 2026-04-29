namespace laba15
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewFtp = new System.Windows.Forms.TreeView();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileSize = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.txtDirName = new System.Windows.Forms.TextBox();
            this.btnCreateDir = new System.Windows.Forms.Button();
            this.btnDeleteDir = new System.Windows.Forms.Button();
            this.btnUploadMultiple = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkDetailedView = new System.Windows.Forms.CheckBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnUploadFolder = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewFtp
            // 
            this.treeViewFtp.BackColor = System.Drawing.Color.White;
            this.treeViewFtp.Location = new System.Drawing.Point(8, 53);
            this.treeViewFtp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeViewFtp.Name = "treeViewFtp";
            this.treeViewFtp.Size = new System.Drawing.Size(385, 331);
            this.treeViewFtp.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(7, 55);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(388, 27);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Налаштування";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.SlateBlue;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(7, 22);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(388, 27);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Підключитися / Оновити";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.White;
            this.txtFileName.Location = new System.Drawing.Point(6, 22);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(322, 23);
            this.txtFileName.TabIndex = 4;
            // 
            // btnFileSize
            // 
            this.btnFileSize.BackColor = System.Drawing.Color.SlateBlue;
            this.btnFileSize.FlatAppearance.BorderSize = 0;
            this.btnFileSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSize.Location = new System.Drawing.Point(6, 51);
            this.btnFileSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFileSize.Name = "btnFileSize";
            this.btnFileSize.Size = new System.Drawing.Size(322, 27);
            this.btnFileSize.TabIndex = 5;
            this.btnFileSize.Text = "Розмір файлу";
            this.btnFileSize.UseVisualStyleBackColor = false;
            this.btnFileSize.Click += new System.EventHandler(this.btnFileSize_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDeleteFile.FlatAppearance.BorderSize = 0;
            this.btnDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFile.Location = new System.Drawing.Point(6, 84);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(321, 27);
            this.btnDeleteFile.TabIndex = 6;
            this.btnDeleteFile.Text = "Видалити файл";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // txtDirName
            // 
            this.txtDirName.BackColor = System.Drawing.Color.White;
            this.txtDirName.Location = new System.Drawing.Point(6, 22);
            this.txtDirName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDirName.Name = "txtDirName";
            this.txtDirName.Size = new System.Drawing.Size(321, 23);
            this.txtDirName.TabIndex = 7;
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCreateDir.FlatAppearance.BorderSize = 0;
            this.btnCreateDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDir.Location = new System.Drawing.Point(6, 51);
            this.btnCreateDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(321, 27);
            this.btnCreateDir.TabIndex = 8;
            this.btnCreateDir.Text = "Створити папку";
            this.btnCreateDir.UseVisualStyleBackColor = false;
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // btnDeleteDir
            // 
            this.btnDeleteDir.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDeleteDir.FlatAppearance.BorderSize = 0;
            this.btnDeleteDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDir.Location = new System.Drawing.Point(6, 85);
            this.btnDeleteDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteDir.Name = "btnDeleteDir";
            this.btnDeleteDir.Size = new System.Drawing.Size(321, 27);
            this.btnDeleteDir.TabIndex = 9;
            this.btnDeleteDir.Text = "Видалити папку";
            this.btnDeleteDir.UseVisualStyleBackColor = false;
            this.btnDeleteDir.Click += new System.EventHandler(this.btnDeleteDir_Click);
            // 
            // btnUploadMultiple
            // 
            this.btnUploadMultiple.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUploadMultiple.FlatAppearance.BorderSize = 0;
            this.btnUploadMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadMultiple.Location = new System.Drawing.Point(6, 22);
            this.btnUploadMultiple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUploadMultiple.Name = "btnUploadMultiple";
            this.btnUploadMultiple.Size = new System.Drawing.Size(321, 27);
            this.btnUploadMultiple.TabIndex = 10;
            this.btnUploadMultiple.Text = "Завантажити файли на сервер";
            this.btnUploadMultiple.UseVisualStyleBackColor = false;
            this.btnUploadMultiple.Click += new System.EventHandler(this.btnUploadMultiple_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkDetailedView
            // 
            this.chkDetailedView.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDetailedView.AutoSize = true;
            this.chkDetailedView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDetailedView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.chkDetailedView.Location = new System.Drawing.Point(8, 22);
            this.chkDetailedView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDetailedView.Name = "chkDetailedView";
            this.chkDetailedView.Size = new System.Drawing.Size(116, 25);
            this.chkDetailedView.TabIndex = 13;
            this.chkDetailedView.Text = "Детальний вигляд";
            this.chkDetailedView.UseVisualStyleBackColor = true;
            this.chkDetailedView.CheckedChanged += new System.EventHandler(this.chkDetailedView_CheckedChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(6, 89);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(321, 27);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Завантажити з сервера на ПК";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnRename
            // 
            this.btnRename.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRename.FlatAppearance.BorderSize = 0;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRename.Location = new System.Drawing.Point(6, 51);
            this.btnRename.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(321, 27);
            this.btnRename.TabIndex = 15;
            this.btnRename.Text = "Перейменувати";
            this.btnRename.UseVisualStyleBackColor = false;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnUploadFolder
            // 
            this.btnUploadFolder.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUploadFolder.FlatAppearance.BorderSize = 0;
            this.btnUploadFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadFolder.Location = new System.Drawing.Point(6, 55);
            this.btnUploadFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUploadFolder.Name = "btnUploadFolder";
            this.btnUploadFolder.Size = new System.Drawing.Size(321, 27);
            this.btnUploadFolder.TabIndex = 16;
            this.btnUploadFolder.Text = "Завантажити папку на сервер";
            this.btnUploadFolder.UseVisualStyleBackColor = false;
            this.btnUploadFolder.Click += new System.EventHandler(this.btnUploadFolder_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.BackColor = System.Drawing.Color.White;
            this.txtNewName.Location = new System.Drawing.Point(6, 22);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(321, 23);
            this.txtNewName.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteFile);
            this.groupBox1.Controls.Add(this.btnFileSize);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Location = new System.Drawing.Point(15, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 124);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операції з файлами";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteDir);
            this.groupBox2.Controls.Add(this.btnCreateDir);
            this.groupBox2.Controls.Add(this.txtDirName);
            this.groupBox2.Location = new System.Drawing.Point(15, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 125);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операції з папками";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNewName);
            this.groupBox3.Controls.Add(this.btnRename);
            this.groupBox3.Location = new System.Drawing.Point(15, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 88);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Перейменування";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUploadFolder);
            this.groupBox4.Controls.Add(this.btnDownload);
            this.groupBox4.Controls.Add(this.btnUploadMultiple);
            this.groupBox4.Location = new System.Drawing.Point(15, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 127);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Завантаження";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnConnect);
            this.groupBox5.Controls.Add(this.btnSettings);
            this.groupBox5.Location = new System.Drawing.Point(369, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(402, 94);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FTP Сервер";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkDetailedView);
            this.groupBox6.Controls.Add(this.treeViewFtp);
            this.groupBox6.Location = new System.Drawing.Point(371, 112);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(400, 394);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Вміст сервера";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(786, 521);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Лабораторна робота №15 Зубко Олександр 201-ТК";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFtp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFileSize;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.TextBox txtDirName;
        private System.Windows.Forms.Button btnCreateDir;
        private System.Windows.Forms.Button btnDeleteDir;
        private System.Windows.Forms.Button btnUploadMultiple;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkDetailedView;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnUploadFolder;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

