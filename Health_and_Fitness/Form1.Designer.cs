﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Title_bar = new System.Windows.Forms.Panel();
            this.IconPlaceholderIndicator_Label = new System.Windows.Forms.Label();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Icon_PicBox = new System.Windows.Forms.PictureBox();
            this.Minimize_BTN = new System.Windows.Forms.Button();
            this.Exit_BTN = new System.Windows.Forms.Button();
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Settings_BTN = new System.Windows.Forms.Button();
            this.Nutrition_BTN = new System.Windows.Forms.Button();
            this.Data_BTN = new System.Windows.Forms.Button();
            this.Schedule_BTN = new System.Windows.Forms.Button();
            this.Home_BTN = new System.Windows.Forms.Button();
            this.UserControlBackground_Panel = new System.Windows.Forms.Panel();
            this.Title_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_PicBox)).BeginInit();
            this.TableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_bar
            // 
            this.Title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Title_bar.Controls.Add(this.IconPlaceholderIndicator_Label);
            this.Title_bar.Controls.Add(this.Title_Label);
            this.Title_bar.Controls.Add(this.Icon_PicBox);
            this.Title_bar.Controls.Add(this.Minimize_BTN);
            this.Title_bar.Controls.Add(this.Exit_BTN);
            this.Title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_bar.Location = new System.Drawing.Point(0, 0);
            this.Title_bar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Title_bar.Name = "Title_bar";
            this.Title_bar.Size = new System.Drawing.Size(800, 32);
            this.Title_bar.TabIndex = 0;
            this.Title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseDown);
            this.Title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseMove);
            this.Title_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_bar_MouseUp);
            // 
            // IconPlaceholderIndicator_Label
            // 
            this.IconPlaceholderIndicator_Label.AutoSize = true;
            this.IconPlaceholderIndicator_Label.ForeColor = System.Drawing.Color.Red;
            this.IconPlaceholderIndicator_Label.Location = new System.Drawing.Point(52, 9);
            this.IconPlaceholderIndicator_Label.Name = "IconPlaceholderIndicator_Label";
            this.IconPlaceholderIndicator_Label.Size = new System.Drawing.Size(96, 13);
            this.IconPlaceholderIndicator_Label.TabIndex = 5;
            this.IconPlaceholderIndicator_Label.Text = "< Icon Placeholder";
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.Title_Label.Location = new System.Drawing.Point(317, 9);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(149, 16);
            this.Title_Label.TabIndex = 4;
            this.Title_Label.Text = "[PH] Health and Fitness";
            this.Title_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_Label_MouseDown);
            this.Title_Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_Label_MouseMove);
            this.Title_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_Label_MouseUp);
            // 
            // Icon_PicBox
            // 
            this.Icon_PicBox.BackColor = System.Drawing.Color.Transparent;
            this.Icon_PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Icon_PicBox.Image")));
            this.Icon_PicBox.Location = new System.Drawing.Point(5, 6);
            this.Icon_PicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Icon_PicBox.Name = "Icon_PicBox";
            this.Icon_PicBox.Size = new System.Drawing.Size(41, 19);
            this.Icon_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon_PicBox.TabIndex = 3;
            this.Icon_PicBox.TabStop = false;
            this.Icon_PicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Icon_PicBox_MouseDown);
            this.Icon_PicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Icon_PicBox_MouseMove);
            this.Icon_PicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Icon_PicBox_MouseUp);
            // 
            // Minimize_BTN
            // 
            this.Minimize_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_BTN.FlatAppearance.BorderSize = 0;
            this.Minimize_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_BTN.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Minimize_BTN.Location = new System.Drawing.Point(684, 0);
            this.Minimize_BTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Minimize_BTN.Name = "Minimize_BTN";
            this.Minimize_BTN.Size = new System.Drawing.Size(58, 32);
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
            this.Exit_BTN.Location = new System.Drawing.Point(742, 0);
            this.Exit_BTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exit_BTN.Name = "Exit_BTN";
            this.Exit_BTN.Size = new System.Drawing.Size(58, 32);
            this.Exit_BTN.TabIndex = 0;
            this.Exit_BTN.Text = "X";
            this.Exit_BTN.UseVisualStyleBackColor = true;
            this.Exit_BTN.Click += new System.EventHandler(this.Exit_BTN_Click);
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TableLayoutPanel.Controls.Add(this.Settings_BTN, 0, 4);
            this.TableLayoutPanel.Controls.Add(this.Nutrition_BTN, 0, 3);
            this.TableLayoutPanel.Controls.Add(this.Data_BTN, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.Schedule_BTN, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.Home_BTN, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 32);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 5;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(191, 473);
            this.TableLayoutPanel.TabIndex = 2;
            // 
            // Settings_BTN
            // 
            this.Settings_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Settings_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_BTN.FlatAppearance.BorderSize = 0;
            this.Settings_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_BTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Settings_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Settings_BTN.Image")));
            this.Settings_BTN.Location = new System.Drawing.Point(0, 376);
            this.Settings_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Settings_BTN.Name = "Settings_BTN";
            this.Settings_BTN.Size = new System.Drawing.Size(191, 97);
            this.Settings_BTN.TabIndex = 4;
            this.Settings_BTN.Text = "Settings";
            this.Settings_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Settings_BTN.UseVisualStyleBackColor = false;
            this.Settings_BTN.Click += new System.EventHandler(this.Settings_BTN_Click);
            // 
            // Nutrition_BTN
            // 
            this.Nutrition_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Nutrition_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nutrition_BTN.FlatAppearance.BorderSize = 0;
            this.Nutrition_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nutrition_BTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nutrition_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Nutrition_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Nutrition_BTN.Image")));
            this.Nutrition_BTN.Location = new System.Drawing.Point(0, 282);
            this.Nutrition_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Nutrition_BTN.Name = "Nutrition_BTN";
            this.Nutrition_BTN.Size = new System.Drawing.Size(191, 94);
            this.Nutrition_BTN.TabIndex = 3;
            this.Nutrition_BTN.Text = "Nutrition";
            this.Nutrition_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Nutrition_BTN.UseVisualStyleBackColor = false;
            this.Nutrition_BTN.Click += new System.EventHandler(this.Nutrition_BTN_Click);
            // 
            // Data_BTN
            // 
            this.Data_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Data_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_BTN.FlatAppearance.BorderSize = 0;
            this.Data_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Data_BTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Data_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Data_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Data_BTN.Image")));
            this.Data_BTN.Location = new System.Drawing.Point(0, 188);
            this.Data_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Data_BTN.Name = "Data_BTN";
            this.Data_BTN.Size = new System.Drawing.Size(191, 94);
            this.Data_BTN.TabIndex = 2;
            this.Data_BTN.Text = "Data";
            this.Data_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Data_BTN.UseVisualStyleBackColor = false;
            this.Data_BTN.Click += new System.EventHandler(this.Data_BTN_Click);
            // 
            // Schedule_BTN
            // 
            this.Schedule_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Schedule_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Schedule_BTN.FlatAppearance.BorderSize = 0;
            this.Schedule_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Schedule_BTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Schedule_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Schedule_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Schedule_BTN.Image")));
            this.Schedule_BTN.Location = new System.Drawing.Point(0, 94);
            this.Schedule_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Schedule_BTN.Name = "Schedule_BTN";
            this.Schedule_BTN.Size = new System.Drawing.Size(191, 94);
            this.Schedule_BTN.TabIndex = 1;
            this.Schedule_BTN.Text = "Schedule";
            this.Schedule_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Schedule_BTN.UseVisualStyleBackColor = false;
            this.Schedule_BTN.Click += new System.EventHandler(this.Schedule_BTN_Click);
            // 
            // Home_BTN
            // 
            this.Home_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Home_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_BTN.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Home_BTN.FlatAppearance.BorderSize = 0;
            this.Home_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_BTN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Home_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home_BTN.Image = ((System.Drawing.Image)(resources.GetObject("Home_BTN.Image")));
            this.Home_BTN.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Home_BTN.Location = new System.Drawing.Point(0, 0);
            this.Home_BTN.Margin = new System.Windows.Forms.Padding(0);
            this.Home_BTN.Name = "Home_BTN";
            this.Home_BTN.Size = new System.Drawing.Size(191, 94);
            this.Home_BTN.TabIndex = 0;
            this.Home_BTN.Text = "Home";
            this.Home_BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Home_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Home_BTN.UseVisualStyleBackColor = false;
            this.Home_BTN.Click += new System.EventHandler(this.Home_BTN_Click);
            // 
            // UserControlBackground_Panel
            // 
            this.UserControlBackground_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.UserControlBackground_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControlBackground_Panel.Location = new System.Drawing.Point(191, 32);
            this.UserControlBackground_Panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserControlBackground_Panel.Name = "UserControlBackground_Panel";
            this.UserControlBackground_Panel.Size = new System.Drawing.Size(609, 473);
            this.UserControlBackground_Panel.TabIndex = 3;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.ControlBox = false;
            this.Controls.Add(this.UserControlBackground_Panel);
            this.Controls.Add(this.TableLayoutPanel);
            this.Controls.Add(this.Title_bar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Activated += new System.EventHandler(this.Main_Form_Activated);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Title_bar.ResumeLayout(false);
            this.Title_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_PicBox)).EndInit();
            this.TableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Title_bar;
        private System.Windows.Forms.Button Minimize_BTN;
        private System.Windows.Forms.Button Exit_BTN;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.PictureBox Icon_PicBox;
        private System.Windows.Forms.Button Settings_BTN;
        private System.Windows.Forms.Button Nutrition_BTN;
        private System.Windows.Forms.Button Data_BTN;
        private System.Windows.Forms.Button Schedule_BTN;
        private System.Windows.Forms.Button Home_BTN;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Panel UserControlBackground_Panel;
        private System.Windows.Forms.Label IconPlaceholderIndicator_Label;
    }
}

