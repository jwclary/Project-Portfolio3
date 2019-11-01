namespace ClaryJason_CE01
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_NewTeam = new System.Windows.Forms.Button();
            this.btn_DeleteTeam = new System.Windows.Forms.Button();
            this.lst_AFC = new System.Windows.Forms.ListBox();
            this.lst_NFC = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(661, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(245, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "NFL Football Teams by Division";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 549);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 549);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "AFC";
            // 
            // btn_NewTeam
            // 
            this.btn_NewTeam.Location = new System.Drawing.Point(109, 879);
            this.btn_NewTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NewTeam.Name = "btn_NewTeam";
            this.btn_NewTeam.Size = new System.Drawing.Size(207, 64);
            this.btn_NewTeam.TabIndex = 6;
            this.btn_NewTeam.Text = "New Team";
            this.btn_NewTeam.UseVisualStyleBackColor = true;
            this.btn_NewTeam.Click += new System.EventHandler(this.btn_NewTeam_Click);
            // 
            // btn_DeleteTeam
            // 
            this.btn_DeleteTeam.Enabled = false;
            this.btn_DeleteTeam.Location = new System.Drawing.Point(360, 879);
            this.btn_DeleteTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteTeam.Name = "btn_DeleteTeam";
            this.btn_DeleteTeam.Size = new System.Drawing.Size(207, 64);
            this.btn_DeleteTeam.TabIndex = 7;
            this.btn_DeleteTeam.Text = "Delete Team";
            this.btn_DeleteTeam.UseVisualStyleBackColor = true;
            // 
            // lst_AFC
            // 
            this.lst_AFC.FormattingEnabled = true;
            this.lst_AFC.ItemHeight = 25;
            this.lst_AFC.Location = new System.Drawing.Point(80, 596);
            this.lst_AFC.Margin = new System.Windows.Forms.Padding(4);
            this.lst_AFC.Name = "lst_AFC";
            this.lst_AFC.Size = new System.Drawing.Size(236, 204);
            this.lst_AFC.TabIndex = 2;
            this.lst_AFC.TabStop = false;
            this.lst_AFC.DoubleClick += new System.EventHandler(this.lst_AFC_DoubleClick);
            // 
            // lst_NFC
            // 
            this.lst_NFC.FormattingEnabled = true;
            this.lst_NFC.ItemHeight = 25;
            this.lst_NFC.Location = new System.Drawing.Point(360, 596);
            this.lst_NFC.Margin = new System.Windows.Forms.Padding(4);
            this.lst_NFC.Name = "lst_NFC";
            this.lst_NFC.Size = new System.Drawing.Size(236, 204);
            this.lst_NFC.TabIndex = 3;
            this.lst_NFC.TabStop = false;
            this.lst_NFC.DoubleClick += new System.EventHandler(this.lst_NFC_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(217, 825);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Double click team to edit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_DeleteTeam);
            this.Controls.Add(this.btn_NewTeam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_NFC);
            this.Controls.Add(this.lst_AFC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_NewTeam;
        private System.Windows.Forms.Button btn_DeleteTeam;
        private System.Windows.Forms.ListBox lst_AFC;
        private System.Windows.Forms.ListBox lst_NFC;
        private System.Windows.Forms.Label label4;
    }
}

