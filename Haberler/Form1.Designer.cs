
namespace Haberler
{
    partial class Form1
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
            this.cbKanallar = new System.Windows.Forms.ComboBox();
            this.lstHaberler = new System.Windows.Forms.ListBox();
            this.NewsPhoto = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NewsPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKanallar
            // 
            this.cbKanallar.FormattingEnabled = true;
            this.cbKanallar.Location = new System.Drawing.Point(38, 26);
            this.cbKanallar.Name = "cbKanallar";
            this.cbKanallar.Size = new System.Drawing.Size(200, 24);
            this.cbKanallar.TabIndex = 1;
            this.cbKanallar.SelectedIndexChanged += new System.EventHandler(this.cbKanallar_SelectedIndexChanged);
            // 
            // lstHaberler
            // 
            this.lstHaberler.FormattingEnabled = true;
            this.lstHaberler.ItemHeight = 16;
            this.lstHaberler.Location = new System.Drawing.Point(38, 79);
            this.lstHaberler.Name = "lstHaberler";
            this.lstHaberler.Size = new System.Drawing.Size(616, 356);
            this.lstHaberler.TabIndex = 5;
            this.lstHaberler.SelectedIndexChanged += new System.EventHandler(this.lstHaberler_SelectedIndexChanged_1);
            // 
            // NewsPhoto
            // 
            this.NewsPhoto.Location = new System.Drawing.Point(677, 12);
            this.NewsPhoto.Name = "NewsPhoto";
            this.NewsPhoto.Size = new System.Drawing.Size(529, 298);
            this.NewsPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewsPhoto.TabIndex = 6;
            this.NewsPhoto.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(674, 329);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(532, 367);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 732);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.NewsPhoto);
            this.Controls.Add(this.lstHaberler);
            this.Controls.Add(this.cbKanallar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NewsPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbKanallar;
        private System.Windows.Forms.ListBox lstHaberler;
        private System.Windows.Forms.PictureBox NewsPhoto;
        private System.Windows.Forms.Label lblDescription;
    }
}

