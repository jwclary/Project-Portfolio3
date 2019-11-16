﻿namespace TicTacToe
{
    partial class frmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redImages = new System.Windows.Forms.ImageList(this.components);
            this.blueImages = new System.Windows.Forms.ImageList(this.components);
            this.r1c1button = new System.Windows.Forms.Button();
            this.r1c2button = new System.Windows.Forms.Button();
            this.r1c3button = new System.Windows.Forms.Button();
            this.r2c1button = new System.Windows.Forms.Button();
            this.r2c2button = new System.Windows.Forms.Button();
            this.r2c3button = new System.Windows.Forms.Button();
            this.r3c1button = new System.Windows.Forms.Button();
            this.r3c2button = new System.Windows.Forms.Button();
            this.r3c3button = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.selectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(314, 38);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(314, 38);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(311, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(314, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.redToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(78, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Checked = true;
            this.blueToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(161, 38);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(161, 38);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.oToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(91, 38);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Checked = true;
            this.xToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.oToolStripMenuItem.Text = "O";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.oToolStripMenuItem_Click);
            // 
            // redImages
            // 
            this.redImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("redImages.ImageStream")));
            this.redImages.TransparentColor = System.Drawing.Color.Transparent;
            this.redImages.Images.SetKeyName(0, "redO.png");
            this.redImages.Images.SetKeyName(1, "redX.png");
            // 
            // blueImages
            // 
            this.blueImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("blueImages.ImageStream")));
            this.blueImages.TransparentColor = System.Drawing.Color.Transparent;
            this.blueImages.Images.SetKeyName(0, "blueO.png");
            this.blueImages.Images.SetKeyName(1, "blueX.png");
            // 
            // r1c1button
            // 
            this.r1c1button.ImageList = this.blueImages;
            this.r1c1button.Location = new System.Drawing.Point(94, 398);
            this.r1c1button.Name = "r1c1button";
            this.r1c1button.Size = new System.Drawing.Size(150, 150);
            this.r1c1button.TabIndex = 1;
            this.r1c1button.UseVisualStyleBackColor = true;
            this.r1c1button.Click += new System.EventHandler(this.button_Click);
            // 
            // r1c2button
            // 
            this.r1c2button.ImageList = this.blueImages;
            this.r1c2button.Location = new System.Drawing.Point(261, 398);
            this.r1c2button.Name = "r1c2button";
            this.r1c2button.Size = new System.Drawing.Size(150, 150);
            this.r1c2button.TabIndex = 2;
            this.r1c2button.UseVisualStyleBackColor = true;
            this.r1c2button.Click += new System.EventHandler(this.button_Click);
            // 
            // r1c3button
            // 
            this.r1c3button.ImageList = this.blueImages;
            this.r1c3button.Location = new System.Drawing.Point(427, 398);
            this.r1c3button.Name = "r1c3button";
            this.r1c3button.Size = new System.Drawing.Size(150, 150);
            this.r1c3button.TabIndex = 3;
            this.r1c3button.UseVisualStyleBackColor = true;
            this.r1c3button.Click += new System.EventHandler(this.button_Click);
            // 
            // r2c1button
            // 
            this.r2c1button.ImageList = this.blueImages;
            this.r2c1button.Location = new System.Drawing.Point(94, 564);
            this.r2c1button.Name = "r2c1button";
            this.r2c1button.Size = new System.Drawing.Size(150, 150);
            this.r2c1button.TabIndex = 4;
            this.r2c1button.UseVisualStyleBackColor = true;
            this.r2c1button.Click += new System.EventHandler(this.button_Click);
            // 
            // r2c2button
            // 
            this.r2c2button.ImageList = this.blueImages;
            this.r2c2button.Location = new System.Drawing.Point(261, 564);
            this.r2c2button.Name = "r2c2button";
            this.r2c2button.Size = new System.Drawing.Size(150, 150);
            this.r2c2button.TabIndex = 5;
            this.r2c2button.UseVisualStyleBackColor = true;
            this.r2c2button.Click += new System.EventHandler(this.button_Click);
            // 
            // r2c3button
            // 
            this.r2c3button.ImageList = this.blueImages;
            this.r2c3button.Location = new System.Drawing.Point(427, 564);
            this.r2c3button.Name = "r2c3button";
            this.r2c3button.Size = new System.Drawing.Size(150, 150);
            this.r2c3button.TabIndex = 6;
            this.r2c3button.UseVisualStyleBackColor = true;
            this.r2c3button.Click += new System.EventHandler(this.button_Click);
            // 
            // r3c1button
            // 
            this.r3c1button.ImageList = this.blueImages;
            this.r3c1button.Location = new System.Drawing.Point(94, 730);
            this.r3c1button.Name = "r3c1button";
            this.r3c1button.Size = new System.Drawing.Size(150, 150);
            this.r3c1button.TabIndex = 7;
            this.r3c1button.UseVisualStyleBackColor = true;
            this.r3c1button.Click += new System.EventHandler(this.button_Click);
            // 
            // r3c2button
            // 
            this.r3c2button.ImageList = this.blueImages;
            this.r3c2button.Location = new System.Drawing.Point(261, 730);
            this.r3c2button.Name = "r3c2button";
            this.r3c2button.Size = new System.Drawing.Size(150, 150);
            this.r3c2button.TabIndex = 8;
            this.r3c2button.UseVisualStyleBackColor = true;
            this.r3c2button.Click += new System.EventHandler(this.button_Click);
            // 
            // r3c3button
            // 
            this.r3c3button.ImageList = this.blueImages;
            this.r3c3button.Location = new System.Drawing.Point(427, 730);
            this.r3c3button.Name = "r3c3button";
            this.r3c3button.Size = new System.Drawing.Size(150, 150);
            this.r3c3button.TabIndex = 9;
            this.r3c3button.UseVisualStyleBackColor = true;
            this.r3c3button.Click += new System.EventHandler(this.button_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(661, 39);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(136, 36);
            this.toolStripButton1.Text = "New Game";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(250, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(6, 500);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(415, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(6, 500);
            this.label2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(92, 554);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 4);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(92, 720);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 4);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 60);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tic-Tac-Toe";
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.r3c3button);
            this.Controls.Add(this.r3c2button);
            this.Controls.Add(this.r3c1button);
            this.Controls.Add(this.r2c3button);
            this.Controls.Add(this.r2c2button);
            this.Controls.Add(this.r2c1button);
            this.Controls.Add(this.r1c3button);
            this.Controls.Add(this.r1c2button);
            this.Controls.Add(this.r1c1button);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ImageList redImages;
        private System.Windows.Forms.ImageList blueImages;
        private System.Windows.Forms.Button r1c1button;
        private System.Windows.Forms.Button r1c2button;
        private System.Windows.Forms.Button r1c3button;
        private System.Windows.Forms.Button r2c1button;
        private System.Windows.Forms.Button r2c2button;
        private System.Windows.Forms.Button r2c3button;
        private System.Windows.Forms.Button r3c1button;
        private System.Windows.Forms.Button r3c2button;
        private System.Windows.Forms.Button r3c3button;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}

