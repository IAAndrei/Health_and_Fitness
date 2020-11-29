
namespace Health_and_Fitness
{
    partial class Home_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.icon3 = new System.Windows.Forms.PictureBox();
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.HomeBG_PictureBox = new System.Windows.Forms.PictureBox();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBG_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.ColumnCount = 1;
            this.HeaderPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderPanel.Controls.Add(this.label1, 0, 0);
            this.HeaderPanel.Controls.Add(this.label2, 0, 1);
            this.HeaderPanel.Location = new System.Drawing.Point(220, 65);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.RowCount = 2;
            this.HeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HeaderPanel.Size = new System.Drawing.Size(176, 75);
            this.HeaderPanel.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(105, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "{X} days have passed since your last exercise!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(75, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(489, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your BMI {Y} is within normal levels for your age!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(526, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "The most calories you\'ve burned in a day are: 0000";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon3
            // 
            this.icon3.BackColor = System.Drawing.Color.Transparent;
            this.icon3.BackgroundImage = global::Health_and_Fitness.Properties.Resources.down_arrow;
            this.icon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon3.Location = new System.Drawing.Point(18, 343);
            this.icon3.Name = "icon3";
            this.icon3.Size = new System.Drawing.Size(32, 32);
            this.icon3.TabIndex = 10;
            this.icon3.TabStop = false;
            // 
            // icon2
            // 
            this.icon2.BackColor = System.Drawing.Color.Transparent;
            this.icon2.BackgroundImage = global::Health_and_Fitness.Properties.Resources.warning1;
            this.icon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon2.Location = new System.Drawing.Point(37, 279);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(32, 32);
            this.icon2.TabIndex = 10;
            this.icon2.TabStop = false;
            // 
            // icon1
            // 
            this.icon1.BackColor = System.Drawing.Color.Transparent;
            this.icon1.BackgroundImage = global::Health_and_Fitness.Properties.Resources.up_arrow;
            this.icon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon1.Location = new System.Drawing.Point(67, 217);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(32, 32);
            this.icon1.TabIndex = 10;
            this.icon1.TabStop = false;
            // 
            // HomeBG_PictureBox
            // 
            this.HomeBG_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.HomeBG_PictureBox.BackgroundImage = global::Health_and_Fitness.Properties.Resources.main_menu2;
            this.HomeBG_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeBG_PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeBG_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.HomeBG_PictureBox.Name = "HomeBG_PictureBox";
            this.HomeBG_PictureBox.Size = new System.Drawing.Size(609, 473);
            this.HomeBG_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBG_PictureBox.TabIndex = 7;
            this.HomeBG_PictureBox.TabStop = false;
            // 
            // Home_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.icon3);
            this.Controls.Add(this.icon2);
            this.Controls.Add(this.icon1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HomeBG_PictureBox);
            this.Name = "Home_UserControl";
            this.Size = new System.Drawing.Size(609, 473);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBG_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomeBG_PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel HeaderPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.PictureBox icon3;
    }
}
