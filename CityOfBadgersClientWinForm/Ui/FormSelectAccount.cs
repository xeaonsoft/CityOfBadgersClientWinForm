using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityOfBadgersClientTool
{
    public partial class FormSelectAccount : Form
    {
        public AccountData[] AccountList { get; set; }

        public AccountData Selection { get; set; }
        public FormSelectAccount()
        {
            InitializeComponent();
        }

        private void FormSelectAccount_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (AccountData account in this.AccountList)
            {
                listBox1.Items.Add(account.Name);
            }

            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteSelectionAndClose();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ExecuteSelectionAndClose();
        }
        private void ExecuteSelectionAndClose()
        {
            string name  = (string)listBox1.SelectedItem;

            this.Selection = this.AccountList.Single(a => a.Name == name);
            this.Close();
        }
    }
}
