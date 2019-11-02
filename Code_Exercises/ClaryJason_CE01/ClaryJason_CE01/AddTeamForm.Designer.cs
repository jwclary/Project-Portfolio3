namespace ClaryJason_CE01
{
    partial class AddTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTeamForm));
            this.txt_TeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.rad_AFC = new System.Windows.Forms.RadioButton();
            this.rad_NFC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_TeamName
            // 
            this.txt_TeamName.Location = new System.Drawing.Point(272, 454);
            this.txt_TeamName.Name = "txt_TeamName";
            this.txt_TeamName.Size = new System.Drawing.Size(276, 31);
            this.txt_TeamName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "City:";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(272, 527);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(276, 31);
            this.txt_City.TabIndex = 2;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(145, 692);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(147, 59);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(391, 692);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(147, 59);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // rad_AFC
            // 
            this.rad_AFC.AutoSize = true;
            this.rad_AFC.Checked = true;
            this.rad_AFC.Location = new System.Drawing.Point(226, 600);
            this.rad_AFC.Name = "rad_AFC";
            this.rad_AFC.Size = new System.Drawing.Size(85, 29);
            this.rad_AFC.TabIndex = 6;
            this.rad_AFC.TabStop = true;
            this.rad_AFC.Text = "AFC";
            this.rad_AFC.UseVisualStyleBackColor = true;
            // 
            // rad_NFC
            // 
            this.rad_NFC.AutoSize = true;
            this.rad_NFC.Location = new System.Drawing.Point(387, 600);
            this.rad_NFC.Name = "rad_NFC";
            this.rad_NFC.Size = new System.Drawing.Size(86, 29);
            this.rad_NFC.TabIndex = 7;
            this.rad_NFC.Text = "NFC";
            this.rad_NFC.UseVisualStyleBackColor = true;
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.rad_NFC);
            this.Controls.Add(this.rad_AFC);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TeamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTeamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton rad_AFC;
        private System.Windows.Forms.RadioButton rad_NFC;
    }
}