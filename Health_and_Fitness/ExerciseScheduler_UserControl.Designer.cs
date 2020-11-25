
namespace Health_and_Fitness
{
    partial class ExerciseScheduler_UserControl
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
            this.ExerciseFlowLayout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.ExerciseDetailFlowLayout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ExerciseFlowLayout_Panel
            // 
            this.ExerciseFlowLayout_Panel.AutoScroll = true;
            this.ExerciseFlowLayout_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExerciseFlowLayout_Panel.Location = new System.Drawing.Point(0, 0);
            this.ExerciseFlowLayout_Panel.Name = "ExerciseFlowLayout_Panel";
            this.ExerciseFlowLayout_Panel.Size = new System.Drawing.Size(186, 341);
            this.ExerciseFlowLayout_Panel.TabIndex = 0;
            // 
            // ExerciseDetailFlowLayout_Panel
            // 
            this.ExerciseDetailFlowLayout_Panel.AutoScroll = true;
            this.ExerciseDetailFlowLayout_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExerciseDetailFlowLayout_Panel.Location = new System.Drawing.Point(192, 0);
            this.ExerciseDetailFlowLayout_Panel.Name = "ExerciseDetailFlowLayout_Panel";
            this.ExerciseDetailFlowLayout_Panel.Size = new System.Drawing.Size(441, 341);
            this.ExerciseDetailFlowLayout_Panel.TabIndex = 1;
            // 
            // ExerciseScheduler_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.ExerciseDetailFlowLayout_Panel);
            this.Controls.Add(this.ExerciseFlowLayout_Panel);
            this.Name = "ExerciseScheduler_UserControl";
            this.Size = new System.Drawing.Size(633, 341);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ExerciseFlowLayout_Panel;
        private System.Windows.Forms.FlowLayoutPanel ExerciseDetailFlowLayout_Panel;
    }
}
