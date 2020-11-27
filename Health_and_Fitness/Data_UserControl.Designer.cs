
namespace Health_and_Fitness
{
    partial class Data_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_UserControl));
            this.DataBG_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataBG_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DataBG_PictureBox
            // 
            this.DataBG_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.DataBG_PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataBG_PictureBox.BackgroundImage")));
            this.DataBG_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DataBG_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataBG_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.DataBG_PictureBox.Name = "DataBG_PictureBox";
            this.DataBG_PictureBox.Size = new System.Drawing.Size(636, 479);
            this.DataBG_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DataBG_PictureBox.TabIndex = 7;
            this.DataBG_PictureBox.TabStop = false;
            // 
            // Data_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataBG_PictureBox);
            this.Name = "Data_UserControl";
            this.Size = new System.Drawing.Size(636, 479);
            ((System.ComponentModel.ISupportInitialize)(this.DataBG_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DataBG_PictureBox;
    }
}
