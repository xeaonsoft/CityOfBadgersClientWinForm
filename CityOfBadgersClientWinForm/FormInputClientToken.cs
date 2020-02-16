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
    public partial class FormInputClientToken : Form
    {

        public FormInputClientToken()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            txtClientToken.Text = MainConfig.Instance.ClientToken;
            txtClientToken.Select();
            txtClientToken.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MainConfig.Instance.ClientToken = txtClientToken.Text.Trim();
            MainConfig.Instance.Save();
            this.Close();
        }


    }
}
