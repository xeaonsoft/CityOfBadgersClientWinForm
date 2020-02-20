namespace CityOfBadgersClientWinForm.Ui.UiControls
{
    partial class UcUrlConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWebSiteUrl = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.txtWebSiteUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWebSiteUrl
            // 
            this.lblWebSiteUrl.AutoSize = true;
            this.lblWebSiteUrl.Location = new System.Drawing.Point(31, 42);
            this.lblWebSiteUrl.Name = "lblWebSiteUrl";
            this.lblWebSiteUrl.Size = new System.Drawing.Size(61, 13);
            this.lblWebSiteUrl.TabIndex = 0;
            this.lblWebSiteUrl.Text = "WebSiteUrl";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(327, 116);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // txtWebSiteUrl
            // 
            this.txtWebSiteUrl.Location = new System.Drawing.Point(155, 38);
            this.txtWebSiteUrl.Name = "txtWebSiteUrl";
            this.txtWebSiteUrl.Size = new System.Drawing.Size(247, 20);
            this.txtWebSiteUrl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Url Config";
            // 
            // UcUrlConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWebSiteUrl);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lblWebSiteUrl);
            this.Name = "UcUrlConfig";
            this.Size = new System.Drawing.Size(442, 148);
            this.Load += new System.EventHandler(this.UcUrlConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWebSiteUrl;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox txtWebSiteUrl;
        private System.Windows.Forms.Label label1;
    }
}
