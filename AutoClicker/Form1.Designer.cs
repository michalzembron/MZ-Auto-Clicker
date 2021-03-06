﻿
namespace AutoClicker
{
    partial class MZAC_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MZAC_Form));
            this.btnGetMousePos = new System.Windows.Forms.Button();
            this.lv_MousePositions = new System.Windows.Forms.ListView();
            this.btnStartClicking = new System.Windows.Forms.Button();
            this.btnStopClicking = new System.Windows.Forms.Button();
            this.textBox_Hours = new System.Windows.Forms.TextBox();
            this.label_h = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            this.textBox_Minutes = new System.Windows.Forms.TextBox();
            this.label_s = new System.Windows.Forms.Label();
            this.textBox_Seconds = new System.Windows.Forms.TextBox();
            this.label_ms = new System.Windows.Forms.Label();
            this.textBox_Miliseconds = new System.Windows.Forms.TextBox();
            this.radioButton_Repeats = new System.Windows.Forms.RadioButton();
            this.textBox_Repeats = new System.Windows.Forms.TextBox();
            this.radioButton_Infinite = new System.Windows.Forms.RadioButton();
            this.comboBox_MouseButton = new System.Windows.Forms.ComboBox();
            this.lbl_MouseButton = new System.Windows.Forms.Label();
            this.groupBox_ClickInterval = new System.Windows.Forms.GroupBox();
            this.groupBox_Repeats = new System.Windows.Forms.GroupBox();
            this.groupBox_ClickOptions = new System.Windows.Forms.GroupBox();
            this.radioButton_ClickLocList = new System.Windows.Forms.RadioButton();
            this.radioButton_CurrentMousePos = new System.Windows.Forms.RadioButton();
            this.lbl_ClickLocation = new System.Windows.Forms.Label();
            this.lbl_ClickType = new System.Windows.Forms.Label();
            this.comboBox_ClickType = new System.Windows.Forms.ComboBox();
            this.groupBox_ClickLocations = new System.Windows.Forms.GroupBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_ClickInterval.SuspendLayout();
            this.groupBox_Repeats.SuspendLayout();
            this.groupBox_ClickOptions.SuspendLayout();
            this.groupBox_ClickLocations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetMousePos
            // 
            this.btnGetMousePos.ForeColor = System.Drawing.Color.Black;
            this.btnGetMousePos.Location = new System.Drawing.Point(6, 305);
            this.btnGetMousePos.Name = "btnGetMousePos";
            this.btnGetMousePos.Size = new System.Drawing.Size(119, 53);
            this.btnGetMousePos.TabIndex = 5;
            this.btnGetMousePos.Text = "Drag and drop\r\nor\r\nCtrl + Shift + F1";
            this.btnGetMousePos.UseVisualStyleBackColor = true;
            this.btnGetMousePos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnGetMousePos_MouseUp);
            // 
            // lv_MousePositions
            // 
            this.lv_MousePositions.HideSelection = false;
            this.lv_MousePositions.Location = new System.Drawing.Point(6, 22);
            this.lv_MousePositions.Name = "lv_MousePositions";
            this.lv_MousePositions.Size = new System.Drawing.Size(119, 277);
            this.lv_MousePositions.TabIndex = 6;
            this.lv_MousePositions.UseCompatibleStateImageBehavior = false;
            this.lv_MousePositions.View = System.Windows.Forms.View.Details;
            // 
            // btnStartClicking
            // 
            this.btnStartClicking.Location = new System.Drawing.Point(12, 364);
            this.btnStartClicking.Name = "btnStartClicking";
            this.btnStartClicking.Size = new System.Drawing.Size(109, 23);
            this.btnStartClicking.TabIndex = 7;
            this.btnStartClicking.Text = "Start (Ctrl + F10)";
            this.btnStartClicking.UseVisualStyleBackColor = true;
            this.btnStartClicking.Click += new System.EventHandler(this.btnStartClicking_Click);
            // 
            // btnStopClicking
            // 
            this.btnStopClicking.Location = new System.Drawing.Point(127, 364);
            this.btnStopClicking.Name = "btnStopClicking";
            this.btnStopClicking.Size = new System.Drawing.Size(109, 23);
            this.btnStopClicking.TabIndex = 14;
            this.btnStopClicking.Text = "Stop (Ctrl + F11)";
            this.btnStopClicking.UseVisualStyleBackColor = true;
            this.btnStopClicking.Click += new System.EventHandler(this.btnStopClicking_Click);
            // 
            // textBox_Hours
            // 
            this.textBox_Hours.Location = new System.Drawing.Point(8, 22);
            this.textBox_Hours.Name = "textBox_Hours";
            this.textBox_Hours.Size = new System.Drawing.Size(64, 23);
            this.textBox_Hours.TabIndex = 15;
            this.textBox_Hours.Text = "0";
            this.textBox_Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Hours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // label_h
            // 
            this.label_h.AutoSize = true;
            this.label_h.ForeColor = System.Drawing.Color.White;
            this.label_h.Location = new System.Drawing.Point(71, 25);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(14, 15);
            this.label_h.TabIndex = 16;
            this.label_h.Text = "h";
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.ForeColor = System.Drawing.Color.White;
            this.label_m.Location = new System.Drawing.Point(154, 25);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(17, 15);
            this.label_m.TabIndex = 18;
            this.label_m.Text = "m";
            // 
            // textBox_Minutes
            // 
            this.textBox_Minutes.Location = new System.Drawing.Point(91, 22);
            this.textBox_Minutes.Name = "textBox_Minutes";
            this.textBox_Minutes.Size = new System.Drawing.Size(64, 23);
            this.textBox_Minutes.TabIndex = 17;
            this.textBox_Minutes.Text = "0";
            this.textBox_Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // label_s
            // 
            this.label_s.AutoSize = true;
            this.label_s.ForeColor = System.Drawing.Color.White;
            this.label_s.Location = new System.Drawing.Point(240, 25);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(13, 15);
            this.label_s.TabIndex = 20;
            this.label_s.Text = "s";
            // 
            // textBox_Seconds
            // 
            this.textBox_Seconds.Location = new System.Drawing.Point(177, 22);
            this.textBox_Seconds.Name = "textBox_Seconds";
            this.textBox_Seconds.Size = new System.Drawing.Size(64, 23);
            this.textBox_Seconds.TabIndex = 19;
            this.textBox_Seconds.Text = "0";
            this.textBox_Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Seconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // label_ms
            // 
            this.label_ms.AutoSize = true;
            this.label_ms.ForeColor = System.Drawing.Color.White;
            this.label_ms.Location = new System.Drawing.Point(322, 25);
            this.label_ms.Name = "label_ms";
            this.label_ms.Size = new System.Drawing.Size(23, 15);
            this.label_ms.TabIndex = 22;
            this.label_ms.Text = "ms";
            // 
            // textBox_Miliseconds
            // 
            this.textBox_Miliseconds.Location = new System.Drawing.Point(259, 22);
            this.textBox_Miliseconds.Name = "textBox_Miliseconds";
            this.textBox_Miliseconds.Size = new System.Drawing.Size(64, 23);
            this.textBox_Miliseconds.TabIndex = 21;
            this.textBox_Miliseconds.Text = "1000";
            this.textBox_Miliseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Miliseconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // radioButton_Repeats
            // 
            this.radioButton_Repeats.AutoSize = true;
            this.radioButton_Repeats.Checked = true;
            this.radioButton_Repeats.ForeColor = System.Drawing.Color.White;
            this.radioButton_Repeats.Location = new System.Drawing.Point(6, 22);
            this.radioButton_Repeats.Name = "radioButton_Repeats";
            this.radioButton_Repeats.Size = new System.Drawing.Size(71, 19);
            this.radioButton_Repeats.TabIndex = 23;
            this.radioButton_Repeats.TabStop = true;
            this.radioButton_Repeats.Text = "Repeats:";
            this.radioButton_Repeats.UseVisualStyleBackColor = true;
            this.radioButton_Repeats.CheckedChanged += new System.EventHandler(this.radioButton_Repeats_CheckedChanged);
            // 
            // textBox_Repeats
            // 
            this.textBox_Repeats.Location = new System.Drawing.Point(83, 21);
            this.textBox_Repeats.Name = "textBox_Repeats";
            this.textBox_Repeats.Size = new System.Drawing.Size(64, 23);
            this.textBox_Repeats.TabIndex = 24;
            this.textBox_Repeats.Text = "1";
            this.textBox_Repeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Repeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_AcceptOnlyNumbers);
            // 
            // radioButton_Infinite
            // 
            this.radioButton_Infinite.AutoSize = true;
            this.radioButton_Infinite.ForeColor = System.Drawing.Color.White;
            this.radioButton_Infinite.Location = new System.Drawing.Point(6, 47);
            this.radioButton_Infinite.Name = "radioButton_Infinite";
            this.radioButton_Infinite.Size = new System.Drawing.Size(64, 19);
            this.radioButton_Infinite.TabIndex = 25;
            this.radioButton_Infinite.TabStop = true;
            this.radioButton_Infinite.Text = "Infinite";
            this.radioButton_Infinite.UseVisualStyleBackColor = true;
            this.radioButton_Infinite.CheckedChanged += new System.EventHandler(this.radioButton_Infinite_CheckedChanged);
            // 
            // comboBox_MouseButton
            // 
            this.comboBox_MouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MouseButton.FormattingEnabled = true;
            this.comboBox_MouseButton.Items.AddRange(new object[] {
            "Left",
            "Middle",
            "Right"});
            this.comboBox_MouseButton.Location = new System.Drawing.Point(92, 16);
            this.comboBox_MouseButton.Name = "comboBox_MouseButton";
            this.comboBox_MouseButton.Size = new System.Drawing.Size(121, 23);
            this.comboBox_MouseButton.TabIndex = 27;
            // 
            // lbl_MouseButton
            // 
            this.lbl_MouseButton.AutoSize = true;
            this.lbl_MouseButton.ForeColor = System.Drawing.Color.White;
            this.lbl_MouseButton.Location = new System.Drawing.Point(3, 19);
            this.lbl_MouseButton.Name = "lbl_MouseButton";
            this.lbl_MouseButton.Size = new System.Drawing.Size(86, 15);
            this.lbl_MouseButton.TabIndex = 28;
            this.lbl_MouseButton.Text = "Mouse Button:";
            // 
            // groupBox_ClickInterval
            // 
            this.groupBox_ClickInterval.Controls.Add(this.textBox_Miliseconds);
            this.groupBox_ClickInterval.Controls.Add(this.textBox_Hours);
            this.groupBox_ClickInterval.Controls.Add(this.label_h);
            this.groupBox_ClickInterval.Controls.Add(this.textBox_Minutes);
            this.groupBox_ClickInterval.Controls.Add(this.label_m);
            this.groupBox_ClickInterval.Controls.Add(this.textBox_Seconds);
            this.groupBox_ClickInterval.Controls.Add(this.label_s);
            this.groupBox_ClickInterval.Controls.Add(this.label_ms);
            this.groupBox_ClickInterval.ForeColor = System.Drawing.Color.White;
            this.groupBox_ClickInterval.Location = new System.Drawing.Point(7, 27);
            this.groupBox_ClickInterval.Name = "groupBox_ClickInterval";
            this.groupBox_ClickInterval.Size = new System.Drawing.Size(351, 56);
            this.groupBox_ClickInterval.TabIndex = 29;
            this.groupBox_ClickInterval.TabStop = false;
            this.groupBox_ClickInterval.Text = "Click Interval";
            // 
            // groupBox_Repeats
            // 
            this.groupBox_Repeats.Controls.Add(this.radioButton_Repeats);
            this.groupBox_Repeats.Controls.Add(this.textBox_Repeats);
            this.groupBox_Repeats.Controls.Add(this.radioButton_Infinite);
            this.groupBox_Repeats.ForeColor = System.Drawing.Color.White;
            this.groupBox_Repeats.Location = new System.Drawing.Point(7, 89);
            this.groupBox_Repeats.Name = "groupBox_Repeats";
            this.groupBox_Repeats.Size = new System.Drawing.Size(351, 71);
            this.groupBox_Repeats.TabIndex = 30;
            this.groupBox_Repeats.TabStop = false;
            this.groupBox_Repeats.Text = "Repeats";
            // 
            // groupBox_ClickOptions
            // 
            this.groupBox_ClickOptions.Controls.Add(this.radioButton_ClickLocList);
            this.groupBox_ClickOptions.Controls.Add(this.radioButton_CurrentMousePos);
            this.groupBox_ClickOptions.Controls.Add(this.lbl_ClickLocation);
            this.groupBox_ClickOptions.Controls.Add(this.lbl_ClickType);
            this.groupBox_ClickOptions.Controls.Add(this.comboBox_ClickType);
            this.groupBox_ClickOptions.Controls.Add(this.lbl_MouseButton);
            this.groupBox_ClickOptions.Controls.Add(this.comboBox_MouseButton);
            this.groupBox_ClickOptions.ForeColor = System.Drawing.Color.White;
            this.groupBox_ClickOptions.Location = new System.Drawing.Point(7, 166);
            this.groupBox_ClickOptions.Name = "groupBox_ClickOptions";
            this.groupBox_ClickOptions.Size = new System.Drawing.Size(351, 129);
            this.groupBox_ClickOptions.TabIndex = 31;
            this.groupBox_ClickOptions.TabStop = false;
            this.groupBox_ClickOptions.Text = "Click Options";
            // 
            // radioButton_ClickLocList
            // 
            this.radioButton_ClickLocList.AutoSize = true;
            this.radioButton_ClickLocList.ForeColor = System.Drawing.Color.White;
            this.radioButton_ClickLocList.Location = new System.Drawing.Point(92, 103);
            this.radioButton_ClickLocList.Name = "radioButton_ClickLocList";
            this.radioButton_ClickLocList.Size = new System.Drawing.Size(121, 19);
            this.radioButton_ClickLocList.TabIndex = 32;
            this.radioButton_ClickLocList.TabStop = true;
            this.radioButton_ClickLocList.Text = "Click location list";
            this.radioButton_ClickLocList.UseVisualStyleBackColor = true;
            this.radioButton_ClickLocList.CheckedChanged += new System.EventHandler(this.radioButton_ClickLocList_CheckedChanged);
            // 
            // radioButton_CurrentMousePos
            // 
            this.radioButton_CurrentMousePos.AutoSize = true;
            this.radioButton_CurrentMousePos.Checked = true;
            this.radioButton_CurrentMousePos.ForeColor = System.Drawing.Color.White;
            this.radioButton_CurrentMousePos.Location = new System.Drawing.Point(92, 78);
            this.radioButton_CurrentMousePos.Name = "radioButton_CurrentMousePos";
            this.radioButton_CurrentMousePos.Size = new System.Drawing.Size(153, 19);
            this.radioButton_CurrentMousePos.TabIndex = 26;
            this.radioButton_CurrentMousePos.TabStop = true;
            this.radioButton_CurrentMousePos.Text = "Current mouse position";
            this.radioButton_CurrentMousePos.UseVisualStyleBackColor = true;
            this.radioButton_CurrentMousePos.CheckedChanged += new System.EventHandler(this.radioButton_CurrentMousePos_CheckedChanged);
            // 
            // lbl_ClickLocation
            // 
            this.lbl_ClickLocation.AutoSize = true;
            this.lbl_ClickLocation.ForeColor = System.Drawing.Color.White;
            this.lbl_ClickLocation.Location = new System.Drawing.Point(3, 80);
            this.lbl_ClickLocation.Name = "lbl_ClickLocation";
            this.lbl_ClickLocation.Size = new System.Drawing.Size(86, 15);
            this.lbl_ClickLocation.TabIndex = 31;
            this.lbl_ClickLocation.Text = "Click Location:";
            // 
            // lbl_ClickType
            // 
            this.lbl_ClickType.AutoSize = true;
            this.lbl_ClickType.ForeColor = System.Drawing.Color.White;
            this.lbl_ClickType.Location = new System.Drawing.Point(3, 52);
            this.lbl_ClickType.Name = "lbl_ClickType";
            this.lbl_ClickType.Size = new System.Drawing.Size(64, 15);
            this.lbl_ClickType.TabIndex = 30;
            this.lbl_ClickType.Text = "Click Type:";
            // 
            // comboBox_ClickType
            // 
            this.comboBox_ClickType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ClickType.FormattingEnabled = true;
            this.comboBox_ClickType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.comboBox_ClickType.Location = new System.Drawing.Point(92, 49);
            this.comboBox_ClickType.Name = "comboBox_ClickType";
            this.comboBox_ClickType.Size = new System.Drawing.Size(121, 23);
            this.comboBox_ClickType.TabIndex = 29;
            // 
            // groupBox_ClickLocations
            // 
            this.groupBox_ClickLocations.Controls.Add(this.lv_MousePositions);
            this.groupBox_ClickLocations.Controls.Add(this.btnGetMousePos);
            this.groupBox_ClickLocations.ForeColor = System.Drawing.Color.White;
            this.groupBox_ClickLocations.Location = new System.Drawing.Point(364, 27);
            this.groupBox_ClickLocations.Name = "groupBox_ClickLocations";
            this.groupBox_ClickLocations.Size = new System.Drawing.Size(131, 364);
            this.groupBox_ClickLocations.TabIndex = 32;
            this.groupBox_ClickLocations.TabStop = false;
            this.groupBox_ClickLocations.Text = "Click Locations:";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MZ Auto Clicker";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MZAC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(504, 399);
            this.Controls.Add(this.groupBox_ClickLocations);
            this.Controls.Add(this.groupBox_ClickOptions);
            this.Controls.Add(this.groupBox_Repeats);
            this.Controls.Add(this.groupBox_ClickInterval);
            this.Controls.Add(this.btnStopClicking);
            this.Controls.Add(this.btnStartClicking);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MZAC_Form";
            this.Text = "MZ Auto Clicker 0.0.0";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox_ClickInterval.ResumeLayout(false);
            this.groupBox_ClickInterval.PerformLayout();
            this.groupBox_Repeats.ResumeLayout(false);
            this.groupBox_Repeats.PerformLayout();
            this.groupBox_ClickOptions.ResumeLayout(false);
            this.groupBox_ClickOptions.PerformLayout();
            this.groupBox_ClickLocations.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetMousePos;
        private System.Windows.Forms.ListView lv_MousePositions;
        private System.Windows.Forms.Button btnStartClicking;
        private System.Windows.Forms.Button btnStopClicking;
        private System.Windows.Forms.TextBox textBox_Hours;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.TextBox textBox_Minutes;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.TextBox textBox_Seconds;
        private System.Windows.Forms.Label label_ms;
        private System.Windows.Forms.TextBox textBox_Miliseconds;
        private System.Windows.Forms.RadioButton radioButton_Repeats;
        private System.Windows.Forms.TextBox textBox_Repeats;
        private System.Windows.Forms.RadioButton radioButton_Infinite;
        private System.Windows.Forms.ComboBox comboBox_MouseButton;
        private System.Windows.Forms.Label lbl_MouseButton;
        private System.Windows.Forms.GroupBox groupBox_ClickInterval;
        private System.Windows.Forms.GroupBox groupBox_Repeats;
        private System.Windows.Forms.GroupBox groupBox_ClickOptions;
        private System.Windows.Forms.Label lbl_ClickType;
        private System.Windows.Forms.ComboBox comboBox_ClickType;
        private System.Windows.Forms.GroupBox groupBox_ClickLocations;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton_CurrentMousePos;
        private System.Windows.Forms.RadioButton radioButton_ClickLocList;
        private System.Windows.Forms.Label lbl_ClickLocation;
    }
}

