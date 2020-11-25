
namespace Health_and_Fitness
{
    partial class ExerciseScheduler_Date_UserControl
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
            this.Date_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Date_Button
            // 
            this.Date_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(91)))));
            this.Date_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date_Button.FlatAppearance.BorderSize = 0;
            this.Date_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Date_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Date_Button.Location = new System.Drawing.Point(0, 0);
            this.Date_Button.Name = "Date_Button";
            this.Date_Button.Size = new System.Drawing.Size(186, 31);
            this.Date_Button.TabIndex = 0;
            this.Date_Button.Text = "00/00/0000";
            this.Date_Button.UseVisualStyleBackColor = false;
            // 
            // ExerciseScheduler_Date_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(91)))));
            this.Controls.Add(this.Date_Button);
            this.Name = "ExerciseScheduler_Date_UserControl";
            this.Size = new System.Drawing.Size(186, 31);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Date_Button;
    }
}
