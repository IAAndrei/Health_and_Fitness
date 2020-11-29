
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
            this.HomeBG_PictureBox = new System.Windows.Forms.PictureBox();
            this.ExercisesAverage_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBG_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeBG_PictureBox
            // 
            this.HomeBG_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HomeBG_PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBG_PictureBox.BackgroundImage")));
            this.HomeBG_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBG_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeBG_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.HomeBG_PictureBox.Name = "HomeBG_PictureBox";
            this.HomeBG_PictureBox.Size = new System.Drawing.Size(636, 479);
            this.HomeBG_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBG_PictureBox.TabIndex = 6;
            this.HomeBG_PictureBox.TabStop = false;
            // 
            // ExercisesAverage_Label
            // 
            this.ExercisesAverage_Label.AutoSize = true;
            this.ExercisesAverage_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExercisesAverage_Label.Location = new System.Drawing.Point(44, 50);
            this.ExercisesAverage_Label.Name = "ExercisesAverage_Label";
            this.ExercisesAverage_Label.Size = new System.Drawing.Size(264, 20);
            this.ExercisesAverage_Label.TabIndex = 7;
            this.ExercisesAverage_Label.Text = "Exercises done on average, per day:";
            // 
            // Data_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExercisesAverage_Label);
            this.Controls.Add(this.HomeBG_PictureBox);
            this.Name = "Data_UserControl";
            this.Size = new System.Drawing.Size(636, 479);
            ((System.ComponentModel.ISupportInitialize)(this.HomeBG_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomeBG_PictureBox;
        private System.Windows.Forms.Label ExercisesAverage_Label;
    }
}
