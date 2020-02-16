using System;
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
        private int _index = 0;
        public FormPublishProgress()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            bOk.Enabled = false;
            progressBar1.Value = 0;
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


            ProcessOne();

            timer1.Start();
        }

        private void ProcessOne()
        {



            try
            {

                BadgeDto dto = new BadgeDto();
                dto.BadgeKey = this.Data.DiscoveredEntries[_index];
                dto.ClientToken = MainConfig.Instance.ClientToken;
                dto.GlobalName = MainConfig.Instance.SelectedAccount.Name;


                if (string.IsNullOrEmpty(dto.BadgeKey) || string.IsNullOrEmpty(dto.ClientToken) || string.IsNullOrEmpty(dto.GlobalName))
                    throw new Exception("Processing Data is not valid!");

                string json = dto.ToJSON();

                string stringData = Base64.Base64Encode(json);
                string uri = UrlConfig.Build(UrlConfig.Instance.PublishRoute, stringData);




                //string result = RestClient.MakeRequest(uri);
                RestClient.MakeRequest(uri);


                _index++;
                RefreshProgressBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

        }

        private void RefreshProgressBar()
        {
            int prc = (int)Math.Floor(((double)_index / (double)this.Data.DiscoveredEntries.Length) * 100);
            progressBar1.Value = prc;
            this.Refresh();
        }
    }
}
