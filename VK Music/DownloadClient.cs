using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace VK_Music
{
    class DownloadClient
    {
        public DownloadClient(CheckedListBox.CheckedIndexCollection _collect, string _patch)
        {
            this.Collect = _collect;
            this.Count = _collect.Count;
            this.Iter = 0;
            this.Patch = _patch;
        }

        public void DownloadF()
        {
            /*WebClient client = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted += client_DownloadFileCompleted;
            client.DownloadFileTaskAsync(new Uri(VK_Audio.linksList[Collect[Iter]]), Patch + "\\" + VK_Audio.audioList[Collect[Iter]] + ".mp3");*/
        }

        void client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            
        }

        private CheckedListBox.CheckedIndexCollection Collect;
        private int Count,
                    Iter;
        private string Patch;
    }
}
