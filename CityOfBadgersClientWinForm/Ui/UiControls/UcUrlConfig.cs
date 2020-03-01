using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityOfBadgersClientTool.Ui.UiControls
{
    public partial class UcUrlConfig : UserControl
    {
        public UcUrlConfig()
        {
            InitializeComponent();
        }

        private void UcUrlConfig_Load(object sender, EventArgs e)
        {
            LoadUI();
        }
        private void LoadUI()
        {
            txtWebSiteUrl.Text = UrlConfig.Instance.WebSiteUrl;
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            UrlConfig.Instance.WebSiteUrl = txtWebSiteUrl.Text.Trim();
            UrlConfig.Instance.Save();
        }
    }
}
