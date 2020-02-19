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
    public partial class FormBindKeys : Form
    {
        public LogData Data { get; set; }

        public FormBindKeys()
        {
            InitializeComponent();

            lblProcessing.Visible = false;
            //lblDone.Visible = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void LoadUI()
        {

            txtFolder.Text = BindFileConfig.Instance.FolderPath;
            txtBind.Text = BindFileConfig.Instance.BindText;
            txtMaxValue.Text = $"{BindFileConfig.Instance.MaxValue}";
            txtItemsPerFile.Text = $"{BindFileConfig.Instance.ItemsPerFile}";

            if (!string.IsNullOrEmpty(txtFolder.Text))
            {
                string bindPath = txtFolder.Text.Trim();
                txtBind0.Text = $"/bind_Load_file \"{Path.Combine(bindPath, $"bind0.txt")}\""; ;
            }
        }
        private void SaveUI()
        {
            BindFileConfig.Instance.FolderPath = txtFolder.Text;
            BindFileConfig.Instance.BindText = txtBind.Text;
            BindFileConfig.Instance.MaxValue = BindFileConfig.TryParseInt(txtMaxValue.Text);
            BindFileConfig.Instance.ItemsPerFile = BindFileConfig.TryParseInt(txtItemsPerFile.Text);



            BindFileConfig.Instance.Validate();
        }
        private void bOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bGenerate_Click(object sender, EventArgs e)
        {
            bGenerate.Visible = false;
            lblProcessing.Visible = true;
            this.Refresh();


            this.SaveUI();
            this.LoadUI();

            string bindPath = BindFileConfig.Instance.FolderPath.Trim();
            if (string.IsNullOrEmpty(bindPath))
            {
                MessageBox.Show("Path is empty");
                return;
            }
            if (!Directory.Exists(bindPath))
            {
                MessageBox.Show("Folder does not exists");
                return;
            }
            BinFileHandler.DeleteFiles(bindPath);
            BinFileHandler.Generate(bindPath);

            txtBind0.Text = $"/bind_Load_file \"{Path.Combine(bindPath, $"bind0.txt")}\""; ;


            MessageBox.Show("Done!");
            bGenerate.Visible = true;
            lblProcessing.Visible = false;
            //lblDone.Visible = true;

            this.LoadUI();
            this.Refresh();
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fbd = new FolderBrowserDialog();

            using (var dialogue = new Ionic.Utils.FolderBrowserDialogEx())
            {

                dialogue.Description = "Select a directory:";
                dialogue.ShowNewFolderButton = false;
                dialogue.ShowEditBox = true;
                if (!string.IsNullOrEmpty(BindFileConfig.Instance.FolderPath) && Directory.Exists(BindFileConfig.Instance.FolderPath))
                    dialogue.SelectedPath = BindFileConfig.Instance.FolderPath;
                dialogue.ShowFullPathInEditBox = true;



                dialogue.RootFolder = System.Environment.SpecialFolder.MyComputer;

                


                DialogResult dr = dialogue.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //txtFolder.Text = fbd.SelectedPath;
                    BindFileConfig.Instance.FolderPath = dialogue.SelectedPath;
                    BindFileConfig.Instance.Save();
                }
            }
            LoadUI();
        }

        private void bCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtBind0.Text.Trim());
        }
    }
}
