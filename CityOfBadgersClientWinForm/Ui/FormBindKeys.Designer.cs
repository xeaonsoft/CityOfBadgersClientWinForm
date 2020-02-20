namespace CityOfBadgersClientWinForm
{
    partial class FormBindKeys
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBindKeys));
            this.lblCaption = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemsPerFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bBrowse = new System.Windows.Forms.Button();
            this.txtBind0 = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bGenerate = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(14, 20);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(162, 17);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Generate bind files...";
            // 
            // bOk
            // 
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOk.Location = new System.Drawing.Point(265, 296);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(123, 30);
            this.bOk.TabIndex = 4;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Bind items per file:";
            // 
            // txtItemsPerFile
            // 
            this.txtItemsPerFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemsPerFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.txtItemsPerFile.Location = new System.Drawing.Point(172, 77);
            this.txtItemsPerFile.Name = "txtItemsPerFile";
            this.txtItemsPerFile.Size = new System.Drawing.Size(53, 22);
            this.txtItemsPerFile.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Max Value:";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.txtMaxValue.Location = new System.Drawing.Point(98, 77);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(53, 22);
            this.txtMaxValue.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Bind:";
            // 
            // txtBind
            // 
            this.txtBind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(71)))), ((int)(((byte)(135)))));
            this.txtBind.Location = new System.Drawing.Point(14, 77);
            this.txtBind.Name = "txtBind";
            this.txtBind.Size = new System.Drawing.Size(75, 22);
            this.txtBind.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(14, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "It is recommanded to use a folder with a short path like  \"C:\\temp\\coh\"";
            // 
            // bBrowse
            // 
            this.bBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBrowse.Location = new System.Drawing.Point(375, 148);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(38, 30);
            this.bBrowse.TabIndex = 31;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // txtBind0
            // 
            this.txtBind0.Location = new System.Drawing.Point(14, 194);
            this.txtBind0.Name = "txtBind0";
            this.txtBind0.ReadOnly = true;
            this.txtBind0.Size = new System.Drawing.Size(347, 20);
            this.txtBind0.TabIndex = 30;
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(14, 153);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(347, 20);
            this.txtFolder.TabIndex = 29;
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.Location = new System.Drawing.Point(440, 212);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(108, 18);
            this.lblProcessing.TabIndex = 39;
            this.lblProcessing.Text = "Processing...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Select the destination folder:";
            // 
            // bGenerate
            // 
            this.bGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGenerate.Location = new System.Drawing.Point(440, 147);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(157, 52);
            this.bGenerate.TabIndex = 41;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // bCopy
            // 
            this.bCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCopy.Image = global::CityOfBadgersClientWinForm.Properties.Resources.Copy16;
            this.bCopy.Location = new System.Drawing.Point(375, 189);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(38, 30);
            this.bCopy.TabIndex = 42;
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // FormBindKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 375);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtItemsPerFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.txtBind0);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.lblCaption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBindKeys";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemsPerFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox txtBind0;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.Button bCopy;
    }
}