namespace ClaryJason_CE02
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lsv_Classes = new System.Windows.Forms.ListView();
            this.ilst_TrackIcons = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CName = new System.Windows.Forms.TextBox();
            this.txt_CNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_Term = new System.Windows.Forms.NumericUpDown();
            this.nud_Hours = new System.Windows.Forms.NumericUpDown();
            this.cbx_Track = new System.Windows.Forms.ComboBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_NewCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Term)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hours)).BeginInit();
            this.SuspendLayout();
            // 
            // lsv_Classes
            // 
            this.lsv_Classes.LargeImageList = this.ilst_TrackIcons;
            this.lsv_Classes.Location = new System.Drawing.Point(80, 574);
            this.lsv_Classes.Name = "lsv_Classes";
            this.lsv_Classes.Size = new System.Drawing.Size(505, 311);
            this.lsv_Classes.SmallImageList = this.ilst_TrackIcons;
            this.lsv_Classes.TabIndex = 0;
            this.lsv_Classes.UseCompatibleStateImageBehavior = false;
            this.lsv_Classes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsv_Classes_MouseClick);
            // 
            // ilst_TrackIcons
            // 
            this.ilst_TrackIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilst_TrackIcons.ImageStream")));
            this.ilst_TrackIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilst_TrackIcons.Images.SetKeyName(0, "Central");
            this.ilst_TrackIcons.Images.SetKeyName(1, "iOS");
            this.ilst_TrackIcons.Images.SetKeyName(2, "Android");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bachelors of Mobile Development Classes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Course Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Term:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Credit Hours:";
            // 
            // txt_CName
            // 
            this.txt_CName.Enabled = false;
            this.txt_CName.Location = new System.Drawing.Point(278, 231);
            this.txt_CName.Name = "txt_CName";
            this.txt_CName.Size = new System.Drawing.Size(307, 31);
            this.txt_CName.TabIndex = 1;
            // 
            // txt_CNumber
            // 
            this.txt_CNumber.Enabled = false;
            this.txt_CNumber.Location = new System.Drawing.Point(278, 273);
            this.txt_CNumber.Name = "txt_CNumber";
            this.txt_CNumber.Size = new System.Drawing.Size(167, 31);
            this.txt_CNumber.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Track:";
            // 
            // nud_Term
            // 
            this.nud_Term.Enabled = false;
            this.nud_Term.Location = new System.Drawing.Point(278, 315);
            this.nud_Term.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud_Term.Name = "nud_Term";
            this.nud_Term.Size = new System.Drawing.Size(120, 31);
            this.nud_Term.TabIndex = 3;
            // 
            // nud_Hours
            // 
            this.nud_Hours.DecimalPlaces = 2;
            this.nud_Hours.Enabled = false;
            this.nud_Hours.Location = new System.Drawing.Point(278, 360);
            this.nud_Hours.Name = "nud_Hours";
            this.nud_Hours.Size = new System.Drawing.Size(120, 31);
            this.nud_Hours.TabIndex = 4;
            // 
            // cbx_Track
            // 
            this.cbx_Track.Enabled = false;
            this.cbx_Track.FormattingEnabled = true;
            this.cbx_Track.Items.AddRange(new object[] {
            "Central",
            "iOS",
            "Android"});
            this.cbx_Track.Location = new System.Drawing.Point(277, 403);
            this.cbx_Track.Name = "cbx_Track";
            this.cbx_Track.Size = new System.Drawing.Size(121, 33);
            this.cbx_Track.TabIndex = 5;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(190, 460);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(121, 41);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(374, 460);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(121, 41);
            this.btn_Edit.TabIndex = 8;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(109, 460);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(45, 41);
            this.btn_Left.TabIndex = 6;
            this.btn_Left.Text = "<";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(530, 460);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(45, 41);
            this.btn_Right.TabIndex = 9;
            this.btn_Right.Text = ">";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_NewCourse
            // 
            this.btn_NewCourse.Location = new System.Drawing.Point(248, 906);
            this.btn_NewCourse.Name = "btn_NewCourse";
            this.btn_NewCourse.Size = new System.Drawing.Size(197, 49);
            this.btn_NewCourse.TabIndex = 10;
            this.btn_NewCourse.Text = "New Course";
            this.btn_NewCourse.UseVisualStyleBackColor = true;
            this.btn_NewCourse.Click += new System.EventHandler(this.btn_NewCourse_Click);
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
            this.Controls.Add(this.btn_NewCourse);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.cbx_Track);
            this.Controls.Add(this.nud_Hours);
            this.Controls.Add(this.nud_Term);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CNumber);
            this.Controls.Add(this.txt_CName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsv_Classes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Term)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsv_Classes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CName;
        private System.Windows.Forms.TextBox txt_CNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_Term;
        private System.Windows.Forms.NumericUpDown nud_Hours;
        private System.Windows.Forms.ComboBox cbx_Track;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_NewCourse;
        private System.Windows.Forms.ImageList ilst_TrackIcons;
    }
}

