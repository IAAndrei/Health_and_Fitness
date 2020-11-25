
namespace Health_and_Fitness
{
    partial class ExerciseDetail_UserControl
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
            this.DetailedExercise_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DetailedExercise_Label
            // 
            this.DetailedExercise_Label.AutoSize = true;
            this.DetailedExercise_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailedExercise_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.DetailedExercise_Label.Location = new System.Drawing.Point(3, 25);
            this.DetailedExercise_Label.Name = "DetailedExercise_Label";
            this.DetailedExercise_Label.Size = new System.Drawing.Size(286, 20);
            this.DetailedExercise_Label.TabIndex = 0;
            this.DetailedExercise_Label.Text = "Exercise 1 - Push ups - 15 minutes";
            // 
            // ExerciseDetail_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(91)))));
            this.Controls.Add(this.DetailedExercise_Label);
            this.Name = "ExerciseDetail_UserControl";
            this.Size = new System.Drawing.Size(441, 68);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DetailedExercise_Label;
    }
}
