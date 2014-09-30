using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.Net;

namespace VK_Music
{
    public partial class VK_Music_Download : Form
    {
        private string patch = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);// + "\\VK Music";
        private VK_Audio vk_audio = new VK_Audio();
        private Queue<string> nameFile, linkFile;
        public VK_Music_Download()
        {
            InitializeComponent();
            Checking();
            LoadMusic();
        }

        private void Checking()
        {
            if (VKSettings.AccesToken == "" && VKSettings.UserID == "")
            {
                using (AuthorizationForm af = new AuthorizationForm())
                {
                    af.ShowDialog();
                }
            }
        }

        private void LoadMusic()
        {
            vk_audio.setLists();
            audioCheckedList.Items.Clear();
            audioCheckedList.Items.AddRange(vk_audio.audioList.ToArray());
            addAlbums();
            if (patchTxtBox.Text == "") patchTxtBox.Text = patch;
            fileDownload.Text = "";
        }

        private void checkAllBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < audioCheckedList.Items.Count; i++)
                audioCheckedList.SetItemChecked(i, true);
        }

        private void uncheckAllBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < audioCheckedList.Items.Count; i++)
                audioCheckedList.SetItemChecked(i, false);
        }

        private void chosePatchBut_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = patch;
                if (fbd.ShowDialog() == DialogResult.OK) patchTxtBox.Text = fbd.SelectedPath;
            }
        }

        private void patchTxtBox_TextChanged(object sender, EventArgs e)
        {
            patch = patchTxtBox.Text;
        }

        private void addAlbums()
        {
            albumsListBox.Items.Clear();
            albumsListBox.Items.Add("Все аудиозаписи");
            albumsListBox.Items.AddRange(vk_audio.albumTitleList.ToArray());
            albumsListBox.SelectedIndex = 0;
        }

        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            audioCheckedList.Items.Clear();
            if (albumsListBox.SelectedIndex == 0)
            {
                vk_audio.setLists();
                audioCheckedList.Items.AddRange(vk_audio.audioList.ToArray());
                return;
            }
            vk_audio.setListsAlbum(vk_audio.albumsIdList[albumsListBox.SelectedIndex - 1]);
            audioCheckedList.Items.AddRange(vk_audio.audioList.ToArray());
        }

        private void downloadCheckBut_Click(object sender, EventArgs e)
        {
            if (audioCheckedList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберете элементы для загрузки", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            downloadCheckBut.Enabled = false;
            //cancleDownloadBut.Enabled = false;
            this.nameFile = new Queue<string>();
            this.linkFile = new Queue<string>();
            foreach(var el in audioCheckedList.CheckedIndices)
            {
                nameFile.Enqueue(vk_audio.audioList[Convert.ToInt32(el)]);
                linkFile.Enqueue(vk_audio.linksList[Convert.ToInt32(el)]);
            }
            downloadProgress.Maximum = audioCheckedList.CheckedIndices.Count;
            label1.Text = @"0/" + downloadProgress.Maximum.ToString();
            downloadProgress.Value = 0;
            downloadFile();
        }

        private void downloadFile()
        {
            individualPrBar.Maximum = 100;
            WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            
            var name = nameFile.Dequeue();
            char[] symbol = {'/', '\\', ':', '*', '?', '\"', '<', '>', '|'};
            foreach(var s in symbol) name = name.Replace(s, ' ');
            name.Trim();
            fileDownload.Text ="Скачиваю: " + name;
            client.DownloadFileAsync(new Uri(linkFile.Dequeue()), patch + "\\" + name + ".mp3");
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            downloadProgress.Value++;
            label1.Text = downloadProgress.Value.ToString() + @"/" + downloadProgress.Maximum.ToString();
            if (nameFile.Count != 0)
            {
                individualPrBar.Value = 0;
                downloadFile();
            }
            else downloadCheckBut.Enabled = true;
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            individualPrBar.Value = int.Parse(Math.Truncate(percentage).ToString());   
        }

    }
}