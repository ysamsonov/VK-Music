using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace VK_Music
{
    class VK_Audio
    {
        public VK_Audio()
        {
            this.audioList = new List<string>();
            this.linksList = new List<string>();
            this.albumsIdList = new List<string>();
            this.albumTitleList = new List<string>();
        }

        public List<string> audioList, 
                            linksList,
                            albumsIdList,
                            albumTitleList;

        private void getAlbumsList()
        {
            this.albumsIdList.Clear();
            this.albumTitleList.Clear();
            var xml = new XmlDocument();
            xml.Load(string.Format("https://api.vk.com/method/audio.getAlbums.xml?owner_id={0}&access_token={1}", VKSettings.UserID, VKSettings.AccesToken));
            foreach (XmlNode ex in xml.SelectNodes("response/album"))
            {
                this.albumsIdList.Add(ex.SelectSingleNode("album_id").InnerText);
                this.albumTitleList.Add(ex.SelectSingleNode("title").InnerText);
            }
        }
        
        public void setLists()
        {
            getAlbumsList();
            this.audioList.Clear();
            this.linksList.Clear();
            var xml = new XmlDocument();
            xml.Load(string.Format("https://api.vk.com/method/audio.get.xml?owner_id={0}&access_token={1}", VKSettings.UserID, VKSettings.AccesToken));
            foreach (XmlNode ex in xml.SelectNodes("response/audio"))
            {
                this.audioList.Add(ex.SelectSingleNode("artist").InnerText + " - " + ex.SelectSingleNode("title").InnerText);
                this.linksList.Add(ex.SelectSingleNode("url").InnerText);
            }
        }

        public void setListsAlbum(string album_id)
        {
            this.audioList.Clear();
            this.linksList.Clear();
            var xml = new XmlDocument();
            xml.Load(string.Format("https://api.vk.com/method/audio.get.xml?owner_id={0}&album_id={1}&access_token={2}", VKSettings.UserID, album_id, VKSettings.AccesToken));
            foreach (XmlNode ex in xml.SelectNodes("response/audio"))
            {
                this.audioList.Add(ex.SelectSingleNode("artist").InnerText + " - " + ex.SelectSingleNode("title").InnerText);
                this.linksList.Add(ex.SelectSingleNode("url").InnerText);
            }
        }
    }
}