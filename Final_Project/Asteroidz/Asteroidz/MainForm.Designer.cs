namespace Asteroidz
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
            this.label1 = new System.Windows.Forms.Label();
            this.rad_Stats = new System.Windows.Forms.RadioButton();
            this.rad_Asteroids = new System.Windows.Forms.RadioButton();
            this.rad_NEO = new System.Windows.Forms.RadioButton();
            this.lst_Asteroids = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Onyx", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asteroidz";
            // 
            // rad_Stats
            // 
            this.rad_Stats.AutoSize = true;
            this.rad_Stats.Location = new System.Drawing.Point(78, 380);
            this.rad_Stats.Name = "rad_Stats";
            this.rad_Stats.Size = new System.Drawing.Size(177, 29);
            this.rad_Stats.TabIndex = 1;
            this.rad_Stats.Text = "Asteroid Stats";
            this.rad_Stats.UseVisualStyleBackColor = true;
            // 
            // rad_Asteroids
            // 
            this.rad_Asteroids.AutoSize = true;
            this.rad_Asteroids.Checked = true;
            this.rad_Asteroids.Location = new System.Drawing.Point(261, 426);
            this.rad_Asteroids.Name = "rad_Asteroids";
            this.rad_Asteroids.Size = new System.Drawing.Size(133, 29);
            this.rad_Asteroids.TabIndex = 2;
            this.rad_Asteroids.TabStop = true;
            this.rad_Asteroids.Text = "Asteroids";
            this.rad_Asteroids.UseVisualStyleBackColor = true;
            // 
            // rad_NEO
            // 
            this.rad_NEO.AutoSize = true;
            this.rad_NEO.Location = new System.Drawing.Point(414, 380);
            this.rad_NEO.Name = "rad_NEO";
            this.rad_NEO.Size = new System.Drawing.Size(184, 29);
            this.rad_NEO.TabIndex = 3;
            this.rad_NEO.Text = "NEO Asteroids";
            this.rad_NEO.UseVisualStyleBackColor = true;
            // 
            // lst_Asteroids
            // 
            this.lst_Asteroids.FormattingEnabled = true;
            this.lst_Asteroids.ItemHeight = 25;
            this.lst_Asteroids.Location = new System.Drawing.Point(92, 495);
            this.lst_Asteroids.Name = "lst_Asteroids";
            this.lst_Asteroids.Size = new System.Drawing.Size(484, 429);
            this.lst_Asteroids.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(158, 936);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "* Double click to display information";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(541, 178);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(47, 49);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "|||";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_Asteroids);
            this.Controls.Add(this.rad_NEO);
            this.Controls.Add(this.rad_Asteroids);
            this.Controls.Add(this.rad_Stats);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Asteroidz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_Stats;
        private System.Windows.Forms.RadioButton rad_Asteroids;
        private System.Windows.Forms.RadioButton rad_NEO;
        private System.Windows.Forms.ListBox lst_Asteroids;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
    }
}

