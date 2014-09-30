namespace VK_Music
{
    partial class VK_Music_Download
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
            this.audioCheckedList = new System.Windows.Forms.CheckedListBox();
            this.checkMusicGroup = new System.Windows.Forms.GroupBox();
            this.uncheckAllBut = new System.Windows.Forms.Button();
            this.checkAllBut = new System.Windows.Forms.Button();
            this.downloadGroup = new System.Windows.Forms.GroupBox();
            this.individualPrBar = new System.Windows.Forms.ProgressBar();
            this.cancleDownloadBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.downloadCheckBut = new System.Windows.Forms.Button();
            this.chosePatchBut = new System.Windows.Forms.Button();
            this.patchTxtBox = new System.Windows.Forms.TextBox();
            this.albumsListBox = new System.Windows.Forms.ComboBox();
            this.fileDownload = new System.Windows.Forms.Label();
            this.checkMusicGroup.SuspendLayout();
            this.downloadGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // audioCheckedList
            // 
            this.audioCheckedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.audioCheckedList.FormattingEnabled = true;
            this.audioCheckedList.Location = new System.Drawing.Point(7, 49);
            this.audioCheckedList.Name = "audioCheckedList";
            this.audioCheckedList.Size = new System.Drawing.Size(470, 409);
            this.audioCheckedList.TabIndex = 2;
            // 
            // checkMusicGroup
            // 
            this.checkMusicGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkMusicGroup.Controls.Add(this.albumsListBox);
            this.checkMusicGroup.Controls.Add(this.uncheckAllBut);
            this.checkMusicGroup.Controls.Add(this.checkAllBut);
            this.checkMusicGroup.Controls.Add(this.audioCheckedList);
            this.checkMusicGroup.Location = new System.Drawing.Point(5, 12);
            this.checkMusicGroup.Name = "checkMusicGroup";
            this.checkMusicGroup.Size = new System.Drawing.Size(483, 467);
            this.checkMusicGroup.TabIndex = 3;
            this.checkMusicGroup.TabStop = false;
            this.checkMusicGroup.Text = "Все аудиозаписи пользователя";
            // 
            // uncheckAllBut
            // 
            this.uncheckAllBut.Location = new System.Drawing.Point(362, 19);
            this.uncheckAllBut.Name = "uncheckAllBut";
            this.uncheckAllBut.Size = new System.Drawing.Size(115, 23);
            this.uncheckAllBut.TabIndex = 4;
            this.uncheckAllBut.Text = "Снять выделение";
            this.uncheckAllBut.UseVisualStyleBackColor = true;
            this.uncheckAllBut.Click += new System.EventHandler(this.uncheckAllBut_Click);
            // 
            // checkAllBut
            // 
            this.checkAllBut.Location = new System.Drawing.Point(241, 20);
            this.checkAllBut.Name = "checkAllBut";
            this.checkAllBut.Size = new System.Drawing.Size(115, 23);
            this.checkAllBut.TabIndex = 3;
            this.checkAllBut.Text = "Выбрать все";
            this.checkAllBut.UseVisualStyleBackColor = true;
            this.checkAllBut.Click += new System.EventHandler(this.checkAllBut_Click);
            // 
            // downloadGroup
            // 
            this.downloadGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.downloadGroup.Controls.Add(this.fileDownload);
            this.downloadGroup.Controls.Add(this.individualPrBar);
            this.downloadGroup.Controls.Add(this.cancleDownloadBut);
            this.downloadGroup.Controls.Add(this.label1);
            this.downloadGroup.Controls.Add(this.downloadProgress);
            this.downloadGroup.Controls.Add(this.downloadCheckBut);
            this.downloadGroup.Controls.Add(this.chosePatchBut);
            this.downloadGroup.Controls.Add(this.patchTxtBox);
            this.downloadGroup.Location = new System.Drawing.Point(508, 12);
            this.downloadGroup.Name = "downloadGroup";
            this.downloadGroup.Size = new System.Drawing.Size(359, 467);
            this.downloadGroup.TabIndex = 4;
            this.downloadGroup.TabStop = false;
            this.downloadGroup.Text = "Скачивание";
            // 
            // individualPrBar
            // 
            this.individualPrBar.Location = new System.Drawing.Point(65, 108);
            this.individualPrBar.Name = "individualPrBar";
            this.individualPrBar.Size = new System.Drawing.Size(288, 23);
            this.individualPrBar.TabIndex = 6;
            // 
            // cancleDownloadBut
            // 
            this.cancleDownloadBut.Enabled = false;
            this.cancleDownloadBut.Location = new System.Drawing.Point(157, 49);
            this.cancleDownloadBut.Name = "cancleDownloadBut";
            this.cancleDownloadBut.Size = new System.Drawing.Size(145, 23);
            this.cancleDownloadBut.TabIndex = 5;
            this.cancleDownloadBut.Text = "Прервать скачивание";
            this.cancleDownloadBut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0/0";
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(65, 137);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(288, 23);
            this.downloadProgress.TabIndex = 3;
            // 
            // downloadCheckBut
            // 
            this.downloadCheckBut.Location = new System.Drawing.Point(6, 49);
            this.downloadCheckBut.Name = "downloadCheckBut";
            this.downloadCheckBut.Size = new System.Drawing.Size(145, 23);
            this.downloadCheckBut.TabIndex = 2;
            this.downloadCheckBut.Text = "Скачать отмеченное";
            this.downloadCheckBut.UseVisualStyleBackColor = true;
            this.downloadCheckBut.Click += new System.EventHandler(this.downloadCheckBut_Click);
            // 
            // chosePatchBut
            // 
            this.chosePatchBut.Location = new System.Drawing.Point(308, 21);
            this.chosePatchBut.Name = "chosePatchBut";
            this.chosePatchBut.Size = new System.Drawing.Size(45, 23);
            this.chosePatchBut.TabIndex = 1;
            this.chosePatchBut.Text = "...";
            this.chosePatchBut.UseVisualStyleBackColor = true;
            this.chosePatchBut.Click += new System.EventHandler(this.chosePatchBut_Click);
            // 
            // patchTxtBox
            // 
            this.patchTxtBox.Location = new System.Drawing.Point(6, 23);
            this.patchTxtBox.Name = "patchTxtBox";
            this.patchTxtBox.Size = new System.Drawing.Size(296, 20);
            this.patchTxtBox.TabIndex = 0;
            this.patchTxtBox.TextChanged += new System.EventHandler(this.patchTxtBox_TextChanged);
            // 
            // albumsListBox
            // 
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.Items.AddRange(new object[] {
            "Все аудиозаписи"});
            this.albumsListBox.Location = new System.Drawing.Point(7, 23);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(157, 21);
            this.albumsListBox.TabIndex = 7;
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // fileDownload
            // 
            this.fileDownload.AutoSize = true;
            this.fileDownload.Location = new System.Drawing.Point(62, 92);
            this.fileDownload.Name = "fileDownload";
            this.fileDownload.Size = new System.Drawing.Size(35, 13);
            this.fileDownload.TabIndex = 7;
            this.fileDownload.Text = "label2";
            // 
            // VK_Music_Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 482);
            this.Controls.Add(this.downloadGroup);
            this.Controls.Add(this.checkMusicGroup);
            this.Name = "VK_Music_Download";
            this.Text = "VK_Music_Download";
            this.checkMusicGroup.ResumeLayout(false);
            this.downloadGroup.ResumeLayout(false);
            this.downloadGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox audioCheckedList;
        private System.Windows.Forms.GroupBox checkMusicGroup;
        private System.Windows.Forms.Button uncheckAllBut;
        private System.Windows.Forms.Button checkAllBut;
        private System.Windows.Forms.GroupBox downloadGroup;
        private System.Windows.Forms.Button chosePatchBut;
        private System.Windows.Forms.TextBox patchTxtBox;
        private System.Windows.Forms.Button downloadCheckBut;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancleDownloadBut;
        private System.Windows.Forms.ProgressBar individualPrBar;
        private System.Windows.Forms.ComboBox albumsListBox;
        private System.Windows.Forms.Label fileDownload;


    }
}