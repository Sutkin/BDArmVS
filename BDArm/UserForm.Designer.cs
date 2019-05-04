﻿namespace BDArm
{
    partial class UserForm
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
            this.ChekStatusLabel = new System.Windows.Forms.Label();
            this.MainMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.ActivatePCodeTextBox = new System.Windows.Forms.TextBox();
            this.ActivatePCodeButton = new System.Windows.Forms.Button();
            this.StatusPCodeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChekStatusLabel
            // 
            this.ChekStatusLabel.AutoSize = true;
            this.ChekStatusLabel.Location = new System.Drawing.Point(12, 24);
            this.ChekStatusLabel.Name = "ChekStatusLabel";
            this.ChekStatusLabel.Size = new System.Drawing.Size(136, 13);
            this.ChekStatusLabel.TabIndex = 8;
            this.ChekStatusLabel.Text = "Статус: Нет подключения";
            // 
            // MainMonthCalendar
            // 
            this.MainMonthCalendar.Location = new System.Drawing.Point(12, 43);
            this.MainMonthCalendar.Name = "MainMonthCalendar";
            this.MainMonthCalendar.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // LogToolStripMenuItem
            // 
            this.LogToolStripMenuItem.Name = "LogToolStripMenuItem";
            this.LogToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.LogToolStripMenuItem.Text = "Подключиться";
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.LogoutToolStripMenuItem.Text = "Выйти из профиля";
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelloLabel.Location = new System.Drawing.Point(200, 43);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(133, 39);
            this.HelloLabel.TabIndex = 9;
            this.HelloLabel.Text = "Привет";
            // 
            // ActivatePCodeTextBox
            // 
            this.ActivatePCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivatePCodeTextBox.Location = new System.Drawing.Point(207, 107);
            this.ActivatePCodeTextBox.Name = "ActivatePCodeTextBox";
            this.ActivatePCodeTextBox.Size = new System.Drawing.Size(382, 65);
            this.ActivatePCodeTextBox.TabIndex = 10;
            // 
            // ActivatePCodeButton
            // 
            this.ActivatePCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivatePCodeButton.Location = new System.Drawing.Point(595, 106);
            this.ActivatePCodeButton.Name = "ActivatePCodeButton";
            this.ActivatePCodeButton.Size = new System.Drawing.Size(193, 66);
            this.ActivatePCodeButton.TabIndex = 11;
            this.ActivatePCodeButton.Text = "Активировать!";
            this.ActivatePCodeButton.UseVisualStyleBackColor = true;
            this.ActivatePCodeButton.Click += new System.EventHandler(this.ActivatePCodeButton_Click);
            // 
            // StatusPCodeLabel
            // 
            this.StatusPCodeLabel.AutoSize = true;
            this.StatusPCodeLabel.Location = new System.Drawing.Point(404, 191);
            this.StatusPCodeLabel.Name = "StatusPCodeLabel";
            this.StatusPCodeLabel.Size = new System.Drawing.Size(90, 13);
            this.StatusPCodeLabel.TabIndex = 12;
            this.StatusPCodeLabel.Text = "Есть промокод?";
            this.StatusPCodeLabel.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 219);
            this.Controls.Add(this.StatusPCodeLabel);
            this.Controls.Add(this.ActivatePCodeButton);
            this.Controls.Add(this.ActivatePCodeTextBox);
            this.Controls.Add(this.HelloLabel);
            this.Controls.Add(this.ChekStatusLabel);
            this.Controls.Add(this.MainMonthCalendar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChekStatusLabel;
        private System.Windows.Forms.MonthCalendar MainMonthCalendar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.TextBox ActivatePCodeTextBox;
        private System.Windows.Forms.Button ActivatePCodeButton;
        private System.Windows.Forms.Label StatusPCodeLabel;
    }
}