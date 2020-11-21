
namespace Health_and_Fitness
{
    partial class Main_Form
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
            this.title_bar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimize_BTN = new System.Windows.Forms.Button();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_BTN = new System.Windows.Forms.Button();
            this.Nutrition_BTN = new System.Windows.Forms.Button();
            this.Data_BTN = new System.Windows.Forms.Button();
            this.Schedule_BTN = new System.Windows.Forms.Button();
            this.Home_BTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.title_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_bar
            // 
            this.title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.title_bar.Controls.Add(this.label2);
            this.title_bar.Controls.Add(this.label1);
            this.title_bar.Controls.Add(this.pictureBox1);
            this.title_bar.Controls.Add(this.Minimize_BTN);
            this.title_bar.Controls.Add(this.Exit_BTN);
            this.title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_bar.Location = new System.Drawing.Point(0, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(800, 26);
            this.title_bar.TabIndex = 0;
            this.title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.title_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(272, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Health and Fitness";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Minimize_BTN
            // 
            this.Minimize_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_BTN.FlatAppearance.BorderSize = 0;
            this.Minimize_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_BTN.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Minimize_BTN.Location = new System.Drawing.Point(700, 0);
            this.Minimize_BTN.Name = "Minimize_BTN";
            this.Minimize_BTN.Size = new System.Drawing.Size(50, 26);
            this.Minimize_BTN.TabIndex = 1;
            this.Minimize_BTN.Text = "_";
            this.Minimize_BTN.UseVisualStyleBackColor = true;
            this.Minimize_BTN.Click += new System.EventHandler(this.Minimize_BTN_Click);
            // 
            // Exit_BTN
            // 
            this.Exit_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_BTN.FlatAppearance.BorderSize = 0;
            this.Exit_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_BTN.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Exit_BTN.Location = new System.Drawing.Point(750, 0);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(50, 26);
            this.Exit_BTN.TabIndex = 0;
            this.Exit_BTN.Text = "X";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Settings_BTN, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Nutrition_BTN, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Data_BTN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Schedule_BTN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Home_BTN, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(164, 479);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Settings_BTN
            // 
            this.Settings_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_BTN.FlatAppearance.BorderSize = 0;
            this.Settings_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Settings_BTN.Location = new System.Drawing.Point(0, 380);
            this.Settings_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_BTN.Name = "Settings_BTN";
            this.Settings_BTN.Size = new System.Drawing.Size(164, 99);
            this.Settings_BTN.TabIndex = 4;
            this.Settings_BTN.Text = "Settings";
            this.Settings_BTN.UseVisualStyleBackColor = true;
            // 
            // Nutrition_BTN
            // 
            this.Nutrition_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nutrition_BTN.FlatAppearance.BorderSize = 0;
            this.Nutrition_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nutrition_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nutrition_BTN.Location = new System.Drawing.Point(0, 285);
            this.Nutrition_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Nutrition_BTN.Name = "Nutrition_BTN";
            this.Nutrition_BTN.Size = new System.Drawing.Size(164, 95);
            this.Nutrition_BTN.TabIndex = 3;
            this.Nutrition_BTN.Text = "Nutrition";
            this.Nutrition_BTN.UseVisualStyleBackColor = true;
            // 
            // Data_BTN
            // 
            this.Data_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_BTN.FlatAppearance.BorderSize = 0;
            this.Data_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Data_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Data_BTN.Location = new System.Drawing.Point(0, 190);
            this.Data_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Data_BTN.Name = "Data_BTN";
            this.Data_BTN.Size = new System.Drawing.Size(164, 95);
            this.Data_BTN.TabIndex = 2;
            this.Data_BTN.Text = "Data";
            this.Data_BTN.UseVisualStyleBackColor = true;
            // 
            // Schedule_BTN
            // 
            this.Schedule_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schedule_BTN.FlatAppearance.BorderSize = 0;
            this.Schedule_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Schedule_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Schedule_BTN.Location = new System.Drawing.Point(0, 95);
            this.Schedule_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Schedule_BTN.Name = "Schedule_BTN";
            this.Schedule_BTN.Size = new System.Drawing.Size(164, 95);
            this.Schedule_BTN.TabIndex = 1;
            this.Schedule_BTN.Text = "Schedule";
            this.Schedule_BTN.UseVisualStyleBackColor = true;
            // 
            // Home_BTN
            // 
            this.Home_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Home_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_BTN.FlatAppearance.BorderSize = 0;
            this.Home_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home_BTN.Location = new System.Drawing.Point(0, 0);
            this.Home_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Home_BTN.Name = "Home_BTN";
            this.Home_BTN.Size = new System.Drawing.Size(164, 95);
            this.Home_BTN.TabIndex = 0;
            this.Home_BTN.Text = "Home";
            this.Home_BTN.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(164, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 479);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(45, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "< Icon Placeholder";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.title_bar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Activated += new System.EventHandler(this.Main_Form_Activated);
            this.title_bar.ResumeLayout(false);
            this.title_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button Minimize_BTN;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Settings_BTN;
        private System.Windows.Forms.Button Nutrition_BTN;
        private System.Windows.Forms.Button Data_BTN;
        private System.Windows.Forms.Button Schedule_BTN;
        private System.Windows.Forms.Button Home_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

