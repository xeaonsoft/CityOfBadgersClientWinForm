namespace CityOfBadgersClientWinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bBrowseLogFile = new System.Windows.Forms.Button();
            this.txtBrowseLogFile = new System.Windows.Forms.TextBox();
            this.lblBrowseLogFile = new System.Windows.Forms.Label();
            this.lblSelectedAccount = new System.Windows.Forms.Label();
            this.txtSelectedAccount = new System.Windows.Forms.TextBox();
            this.bSelectAccount = new System.Windows.Forms.Button();
            this.bReadLogFile = new System.Windows.Forms.Button();
            this.lblClientToken = new System.Windows.Forms.Label();
            this.txtClientToken = new System.Windows.Forms.TextBox();
            this.bInputClientKey = new System.Windows.Forms.Button();
            this.lblDiscoveredCount = new System.Windows.Forms.Label();
            this.bPublish = new System.Windows.Forms.Button();
            this.bValidateClientToken = new System.Windows.Forms.Button();
            this.imgLed = new System.Windows.Forms.PictureBox();
            this.bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLed)).BeginInit();
            this.SuspendLayout();
            // 
            // bBrowseLogFile
            // 
            this.bBrowseLogFile.Location = new System.Drawing.Point(420, 34);
            this.bBrowseLogFile.Name = "bBrowseLogFile";
            this.bBrowseLogFile.Size = new System.Drawing.Size(75, 23);
            this.bBrowseLogFile.TabIndex = 0;
            this.bBrowseLogFile.Text = "Browse";
            this.bBrowseLogFile.UseVisualStyleBackColor = true;
            this.bBrowseLogFile.Click += new System.EventHandler(this.bBrowseLogFile_Click);
            // 
            // txtBrowseLogFile
            // 
            this.txtBrowseLogFile.Location = new System.Drawing.Point(15, 34);
            this.txtBrowseLogFile.Name = "txtBrowseLogFile";
            this.txtBrowseLogFile.ReadOnly = true;
            this.txtBrowseLogFile.Size = new System.Drawing.Size(399, 20);
            this.txtBrowseLogFile.TabIndex = 1;
            // 
            // lblBrowseLogFile
            // 
            this.lblBrowseLogFile.AutoSize = true;
            this.lblBrowseLogFile.Location = new System.Drawing.Point(12, 18);
            this.lblBrowseLogFile.Name = "lblBrowseLogFile";
            this.lblBrowseLogFile.Size = new System.Drawing.Size(72, 13);
            this.lblBrowseLogFile.TabIndex = 2;
            this.lblBrowseLogFile.Text = "Log File Path:";
            // 
            // lblSelectedAccount
            // 
            this.lblSelectedAccount.AutoSize = true;
            this.lblSelectedAccount.Location = new System.Drawing.Point(12, 66);
            this.lblSelectedAccount.Name = "lblSelectedAccount";
            this.lblSelectedAccount.Size = new System.Drawing.Size(95, 13);
            this.lblSelectedAccount.TabIndex = 5;
            this.lblSelectedAccount.Text = "Selected Account:";
            // 
            // txtSelectedAccount
            // 
            this.txtSelectedAccount.Location = new System.Drawing.Point(15, 82);
            this.txtSelectedAccount.Name = "txtSelectedAccount";
            this.txtSelectedAccount.ReadOnly = true;
            this.txtSelectedAccount.Size = new System.Drawing.Size(140, 20);
            this.txtSelectedAccount.TabIndex = 4;
            // 
            // bSelectAccount
            // 
            this.bSelectAccount.Location = new System.Drawing.Point(161, 82);
            this.bSelectAccount.Name = "bSelectAccount";
            this.bSelectAccount.Size = new System.Drawing.Size(75, 23);
            this.bSelectAccount.TabIndex = 3;
            this.bSelectAccount.Text = "Select";
            this.bSelectAccount.UseVisualStyleBackColor = true;
            this.bSelectAccount.Click += new System.EventHandler(this.bSelectAccount_Click);
            // 
            // bReadLogFile
            // 
            this.bReadLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReadLogFile.Location = new System.Drawing.Point(15, 125);
            this.bReadLogFile.Name = "bReadLogFile";
            this.bReadLogFile.Size = new System.Drawing.Size(221, 34);
            this.bReadLogFile.TabIndex = 6;
            this.bReadLogFile.Text = "Read log file now";
            this.bReadLogFile.UseVisualStyleBackColor = true;
            this.bReadLogFile.Click += new System.EventHandler(this.bReadLogFile_Click);
            // 
            // lblClientToken
            // 
            this.lblClientToken.AutoSize = true;
            this.lblClientToken.Location = new System.Drawing.Point(12, 207);
            this.lblClientToken.Name = "lblClientToken";
            this.lblClientToken.Size = new System.Drawing.Size(144, 13);
            this.lblClientToken.TabIndex = 8;
            this.lblClientToken.Text = "City of Badgers Client Token:";
            // 
            // txtClientToken
            // 
            this.txtClientToken.Location = new System.Drawing.Point(15, 223);
            this.txtClientToken.Name = "txtClientToken";
            this.txtClientToken.ReadOnly = true;
            this.txtClientToken.Size = new System.Drawing.Size(399, 20);
            this.txtClientToken.TabIndex = 7;
            // 
            // bInputClientKey
            // 
            this.bInputClientKey.Location = new System.Drawing.Point(420, 223);
            this.bInputClientKey.Name = "bInputClientKey";
            this.bInputClientKey.Size = new System.Drawing.Size(75, 23);
            this.bInputClientKey.TabIndex = 9;
            this.bInputClientKey.Text = "Input";
            this.bInputClientKey.UseVisualStyleBackColor = true;
            this.bInputClientKey.Click += new System.EventHandler(this.bInputClientKey_Click);
            // 
            // lblDiscoveredCount
            // 
            this.lblDiscoveredCount.AutoSize = true;
            this.lblDiscoveredCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscoveredCount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiscoveredCount.Location = new System.Drawing.Point(11, 162);
            this.lblDiscoveredCount.Name = "lblDiscoveredCount";
            this.lblDiscoveredCount.Size = new System.Drawing.Size(12, 16);
            this.lblDiscoveredCount.TabIndex = 10;
            this.lblDiscoveredCount.Text = "-";
            // 
            // bPublish
            // 
            this.bPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPublish.Location = new System.Drawing.Point(142, 321);
            this.bPublish.Name = "bPublish";
            this.bPublish.Size = new System.Drawing.Size(243, 34);
            this.bPublish.TabIndex = 11;
            this.bPublish.Text = "Publish discovered entries...";
            this.bPublish.UseVisualStyleBackColor = true;
            this.bPublish.Click += new System.EventHandler(this.bPublish_Click);
            // 
            // bValidateClientToken
            // 
            this.bValidateClientToken.Location = new System.Drawing.Point(356, 252);
            this.bValidateClientToken.Name = "bValidateClientToken";
            this.bValidateClientToken.Size = new System.Drawing.Size(139, 23);
            this.bValidateClientToken.TabIndex = 12;
            this.bValidateClientToken.Text = "Validate Token";
            this.bValidateClientToken.UseVisualStyleBackColor = true;
            this.bValidateClientToken.Click += new System.EventHandler(this.bValidateClientToken_Click);
            // 
            // imgLed
            // 
            this.imgLed.Image = global::CityOfBadgersClientWinForm.Properties.Resources.led_Gray;
            this.imgLed.Location = new System.Drawing.Point(501, 227);
            this.imgLed.Name = "imgLed";
            this.imgLed.Size = new System.Drawing.Size(16, 16);
            this.imgLed.TabIndex = 13;
            this.imgLed.TabStop = false;
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(447, 404);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(88, 34);
            this.bClose.TabIndex = 14;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.imgLed);
            this.Controls.Add(this.bValidateClientToken);
            this.Controls.Add(this.bPublish);
            this.Controls.Add(this.lblDiscoveredCount);
            this.Controls.Add(this.bInputClientKey);
            this.Controls.Add(this.lblClientToken);
            this.Controls.Add(this.txtClientToken);
            this.Controls.Add(this.bReadLogFile);
            this.Controls.Add(this.lblSelectedAccount);
            this.Controls.Add(this.txtSelectedAccount);
            this.Controls.Add(this.bSelectAccount);
            this.Controls.Add(this.lblBrowseLogFile);
            this.Controls.Add(this.txtBrowseLogFile);
            this.Controls.Add(this.bBrowseLogFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City of Badgers Client Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBrowseLogFile;
        private System.Windows.Forms.TextBox txtBrowseLogFile;
        private System.Windows.Forms.Label lblBrowseLogFile;
        private System.Windows.Forms.Label lblSelectedAccount;
        private System.Windows.Forms.TextBox txtSelectedAccount;
        private System.Windows.Forms.Button bSelectAccount;
        private System.Windows.Forms.Button bReadLogFile;
        private System.Windows.Forms.Label lblClientToken;
        private System.Windows.Forms.TextBox txtClientToken;
        private System.Windows.Forms.Button bInputClientKey;
        private System.Windows.Forms.Label lblDiscoveredCount;
        private System.Windows.Forms.Button bPublish;
        private System.Windows.Forms.Button bValidateClientToken;
        private System.Windows.Forms.PictureBox imgLed;
        private System.Windows.Forms.Button bClose;
    }
}

