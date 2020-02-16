using System;
using System.Net;
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
    public partial class MainForm : Form
    {
        public bool? TokenValid { get; set; }
        public LogData Data { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LoadUI();
        }

        private void LoadUI()
        {
            txtBrowseLogFile.Text = MainConfig.Instance.LogFileFolder;

            string selectedAccount = string.Empty;
            if (MainConfig.Instance.SelectedAccount != null)
                selectedAccount = $"{MainConfig.Instance.SelectedAccount.Name}".Trim();


            txtSelectedAccount.Text = selectedAccount;
            bSelectAccount.Enabled = !string.IsNullOrEmpty(MainConfig.Instance.LogFileFolder);
            bReadLogFile.Visible = !string.IsNullOrEmpty(selectedAccount);
            txtClientToken.Text = MainConfig.Instance.ClientToken;

            lblDiscoveredCount.Text = string.Empty;
            if (this.Data != null)
                lblDiscoveredCount.Text = $"{this.Data.DiscoveredEntries.Length} Possible match discovered.";

            this.imgLed.Image = Properties.Resources.led_Gray;


            bValidateClientToken.Enabled = !string.IsNullOrEmpty(MainConfig.Instance.ClientToken);

            if (this.TokenValid.HasValue)
            {
                if (this.TokenValid.Value)
                    this.imgLed.Image = Properties.Resources.led_green;
                else
                    this.imgLed.Image = Properties.Resources.led_red;
            }

            bPublish.Enabled = false;
            if (this.Data != null)
                bPublish.Enabled = (this.Data.DiscoveredEntries.Length > 0);

        }

        private void bBrowseLogFile_Click(object sender, EventArgs e)
        {
            CohLogPathManagement.FetchLogFilePath();
            this.LoadUI();
        }

        private void bSelectAccount_Click(object sender, EventArgs e)
        {
            CohLogPathManagement.Process();
            this.LoadUI();
        }

        private void bReadLogFile_Click(object sender, EventArgs e)
        {
            this.Data = CohLogProcessing.Process();
            this.LoadUI();
        }

        private void bInputClientKey_Click(object sender, EventArgs e)
        {
            using (FormInputClientToken dialogue = new FormInputClientToken())
            {
                dialogue.ShowDialog();
                this.LoadUI();
            }
        }

        private void bValidateClientToken_Click(object sender, EventArgs e)
        {
            string token = Base64.Base64Encode(MainConfig.Instance.ClientToken);


            string uri = UrlConfig.Build(UrlConfig.Instance.ValidateTokenRoute, token);

            try
            {
                string result = RestClient.MakeRequest(uri);
                this.TokenValid = (result.Trim().ToLower() == "yes");
                if (this.TokenValid.Value)
                    MessageBox.Show("Token is valid");
                else
                    MessageBox.Show("Token is not valid");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.LoadUI();
        }

        private void bPublish_Click(object sender, EventArgs e)
        {
            using (FormPublishProgress form = new FormPublishProgress())
            {
                form.Data = this.Data;
                form.ShowDialog();
            }

          
        }
    }
}
