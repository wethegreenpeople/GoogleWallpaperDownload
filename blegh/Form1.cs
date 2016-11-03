using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blegh
{
    public partial class Form1 : Form
    {
        string wallpaperRes;
        string monitorNum;
        string keywords;

        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
        }

        private string GetHtmlCode()
        {
            wallpaperRes = ResolutionList.SelectedItem.ToString();
            List<string> _topics = new List<string> {keywords + monitorNum + " wallpaper " + wallpaperRes + " .png"};
            LabelScreenRes.Text = _topics[0].ToString();
            var rnd = new Random();

            int topic = rnd.Next(0, _topics.Count - 1);

            string url = "https://www.google.com/search?q=" + _topics[topic] + "&tbm=isch";
            string data = "";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; rv:11.0) like Gecko";

            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return "";
                using (var sr = new StreamReader(dataStream))
                {
                    data = sr.ReadToEnd();
                }
            }
            return data;
        }

        private List<string> GetUrls(string html)
        {
            var urls = new List<string>();

            int ndx = html.IndexOf("\"ou\"", StringComparison.Ordinal);

            while (ndx >= 0)
            {
                ndx = html.IndexOf("\"", ndx + 4, StringComparison.Ordinal);
                ndx++;
                int ndx2 = html.IndexOf("\"", ndx, StringComparison.Ordinal);
                string url = html.Substring(ndx, ndx2 - ndx);
                urls.Add(url);
                ndx = html.IndexOf("\"ou\"", ndx2, StringComparison.Ordinal);
            }
            return urls;
        }

        private byte[] GetImage(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return null;
                using (var sr = new BinaryReader(dataStream))
                {
                    byte[] bytes = sr.ReadBytes(100000000);

                    return bytes;
                }
            }

            return null;
        }

        public static bool IsValidImage(byte[] bytes)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(bytes))
                    Image.FromStream(ms);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }

        private void runWallpaperGetting()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Wallpapers/");
            PictureBox pictureBox1 = new PictureBox();
            string html = GetHtmlCode();
            List<string> urls = GetUrls(html);
            var rnd = new Random();

            int randomUrl;
            string luckyUrl;
            byte[] image;
            int downloadCount = 0;

            for (int numWallpapers = 0; numWallpapers < 10; ++numWallpapers)
            {
                randomUrl = rnd.Next(0, urls.Count - 1);
                luckyUrl = urls[randomUrl];
                image = GetImage(luckyUrl);

                // Grabbing two random words to give to the image name so we're not overwritting images
                WebClient client = new WebClient();
                string[] words = new string[2];
                for (int x = 0; x < 2; ++x)
                {
                    string randWord = client.DownloadString("http://randomword.setgetgo.com/get.php");
                    words[x] = randWord;
                }

                if (IsValidImage(image) == true)
                {
                    if (image.Length > 555000)
                    {
                        File.WriteAllBytes("Wallpapers/" + words[0] + words[1] + ".png", image);
                        ++downloadCount;
                    }
                }
                progressBarImageDownload.PerformStep();
            }
            if (progressBarImageDownload.Value >= 10)
            {
                DialogResult success = MessageBox.Show("Success! " + downloadCount + " wallpapers downloaded!", "Success", MessageBoxButtons.OKCancel);
                switch (success)
                {
                    case DialogResult.Yes: break;
                    case DialogResult.No: break;
                }
            }
            progressBarImageDownload.Value = 0;
        }

        private void ResolutionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelScreenRes_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMonitorNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMonitorNum.SelectedItem.Equals("Single Monitor"))
            {
                monitorNum = " ";
            }
            else
            {
                monitorNum = " dual monitor";
            }
        }

        private void textBoxAddKeywords_TextChanged(object sender, EventArgs e)
        {
            keywords = textBoxAddKeywords.Text;
        }

        private void progressBarImageDownload_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }
    }
}
