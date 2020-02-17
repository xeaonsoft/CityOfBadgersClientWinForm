using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityOfBadgersClientWinForm
{
    public partial class FormPublishProgress : Form
    {
        public LogData Data { get; set; }
        //private int _index = 0;
        public FormPublishProgress()
        {
            InitializeComponent();

            lblPublishing.Visible = true;
            lblCompleted.Visible = false;
            bCancel.Visible = true;
            bOk.Visible = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();


            Publish();

            lblPublishing.Visible = false;
            lblCompleted.Visible = true;
            bCancel.Visible = false;
            bOk.Visible = true;


        }

        private void Publish()
        {



            try
            {

                BadgeDto dto = new BadgeDto();
                dto.BadgeKeys = this.Data.DiscoveredEntries;
                dto.ClientToken = MainConfig.Instance.ClientToken;
                dto.GlobalName = MainConfig.Instance.SelectedAccount.Name;
                dto.CharacterName = this.Data.ToonName;


                if (!dto.IsValid())
                    throw new Exception("Processing Data is not valid!");

                string json = dto.ToJSON();


                //string compressed = GZipCompression.Compress(json);
                //string stringData = Base64.Base64Encode(compressed);

                string uri = UrlConfig.Build(UrlConfig.Instance.PublishRoute);

                string content = RestBasicDto.Prep(json);
                RestClient.MakePostRequest(uri, content);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

        }

        //private void RefreshProgressBar()
        //{
        //    int prc = (int)Math.Floor(((double)_index / (double)this.Data.DiscoveredEntries.Length) * 100);
        //    progressBar1.Value = prc;
        //    this.Refresh();
        //}
    }
}
