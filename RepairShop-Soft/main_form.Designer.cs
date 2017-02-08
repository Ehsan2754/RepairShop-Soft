namespace RepairShop_Soft
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RTB_notes = new System.Windows.Forms.RichTextBox();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_userNOT = new System.Windows.Forms.Label();
            this.RTC = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_about = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sssssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_crew = new System.Windows.Forms.Button();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_reception = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_connectionStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btn_about);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.tabControl2);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.lbl_day);
            this.groupBox1.Controls.Add(this.lbl_hour);
            this.groupBox1.Controls.Add(this.lbl_date);
            this.groupBox1.Controls.Add(this.lbl_userNOT);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعلانات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(106, 19);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(536, 320);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage4.ForeColor = System.Drawing.Color.DarkOrange;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(528, 294);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "آماده تحویل";
            this.tabPage4.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(528, 294);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "در انتظار تعمیر";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.richTextBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(528, 294);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "یادداشت ها";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richTextBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(516, 285);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RTB_notes_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTB_notes_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(106, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 320);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.ForeColor = System.Drawing.Color.DarkOrange;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(528, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "آماده تحویل";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(528, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "در انتظار تعمیر";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RTB_notes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(528, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "یادداشت ها";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RTB_notes
            // 
            this.RTB_notes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RTB_notes.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RTB_notes.ForeColor = System.Drawing.Color.OrangeRed;
            this.RTB_notes.Location = new System.Drawing.Point(6, 6);
            this.RTB_notes.Name = "RTB_notes";
            this.RTB_notes.Size = new System.Drawing.Size(516, 276);
            this.RTB_notes.TabIndex = 0;
            this.RTB_notes.Text = "";
            this.RTB_notes.TextChanged += new System.EventHandler(this.RTB_notes_TextChanged);
            this.RTB_notes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTB_notes_KeyPress);
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Location = new System.Drawing.Point(43, 84);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(23, 13);
            this.lbl_day.TabIndex = 1;
            this.lbl_day.Text = "روز";
            this.lbl_day.Click += new System.EventHandler(this.lbl_day_Click);
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Location = new System.Drawing.Point(31, 62);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(35, 13);
            this.lbl_hour.TabIndex = 1;
            this.lbl_hour.Text = "ساعت";
            this.lbl_hour.Click += new System.EventHandler(this.lbl_hour_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(31, 39);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(32, 13);
            this.lbl_date.TabIndex = 1;
            this.lbl_date.Text = "تاریخ";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // lbl_userNOT
            // 
            this.lbl_userNOT.AutoSize = true;
            this.lbl_userNOT.Location = new System.Drawing.Point(18, 16);
            this.lbl_userNOT.Name = "lbl_userNOT";
            this.lbl_userNOT.Size = new System.Drawing.Size(48, 13);
            this.lbl_userNOT.TabIndex = 1;
            this.lbl_userNOT.Text = "ناشناخته";
            this.lbl_userNOT.Click += new System.EventHandler(this.lbl_userNOT_Click);
            // 
            // RTC
            // 
            this.RTC.Enabled = true;
            this.RTC.Interval = 1000;
            this.RTC.Tick += new System.EventHandler(this.RTC_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.lbl_connectionStatus);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_setting);
            this.groupBox2.Controls.Add(this.btn_crew);
            this.groupBox2.Controls.Add(this.btn_store);
            this.groupBox2.Controls.Add(this.btn_reception);
            this.groupBox2.Location = new System.Drawing.Point(665, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "کنترل";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_about
            // 
            this.btn_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_about.Location = new System.Drawing.Point(6, 169);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(94, 82);
            this.btn_about.TabIndex = 2;
            this.btn_about.Text = "درباره";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sssssToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 26);
            // 
            // sssssToolStripMenuItem
            // 
            this.sssssToolStripMenuItem.Name = "sssssToolStripMenuItem";
            this.sssssToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.sssssToolStripMenuItem.Text = "sssss";
            // 
            // button1
            // 
            this.button1.Image = global::RepairShop_Soft.Properties.Resources.Earth_Spider_Security;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "اتصال به دیتابیس";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_setting
            // 
            this.btn_setting.Image = global::RepairShop_Soft.Properties.Resources.Network_2_Configuration;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(6, 205);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(139, 57);
            this.btn_setting.TabIndex = 3;
            this.btn_setting.Text = "تنظیمات";
            this.btn_setting.UseVisualStyleBackColor = true;
            // 
            // btn_crew
            // 
            this.btn_crew.Image = global::RepairShop_Soft.Properties.Resources.Network_ID_2;
            this.btn_crew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_crew.Location = new System.Drawing.Point(6, 82);
            this.btn_crew.Name = "btn_crew";
            this.btn_crew.Size = new System.Drawing.Size(139, 57);
            this.btn_crew.TabIndex = 2;
            this.btn_crew.Text = "کارمندان";
            this.btn_crew.UseVisualStyleBackColor = true;
            // 
            // btn_store
            // 
            this.btn_store.Image = global::RepairShop_Soft.Properties.Resources.Cookies_1_Configuration;
            this.btn_store.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_store.Location = new System.Drawing.Point(6, 142);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(139, 57);
            this.btn_store.TabIndex = 1;
            this.btn_store.Text = "واحد انبار";
            this.btn_store.UseVisualStyleBackColor = true;
            // 
            // btn_reception
            // 
            this.btn_reception.Image = global::RepairShop_Soft.Properties.Resources.Certificate_2_Check;
            this.btn_reception.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reception.Location = new System.Drawing.Point(6, 19);
            this.btn_reception.Name = "btn_reception";
            this.btn_reception.Size = new System.Drawing.Size(139, 57);
            this.btn_reception.TabIndex = 0;
            this.btn_reception.Text = "واحد پذیرش";
            this.btn_reception.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_exit.BackgroundImage = global::RepairShop_Soft.Properties.Resources.delete1;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Location = new System.Drawing.Point(6, 257);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 82);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_connectionStatus
            // 
            this.lbl_connectionStatus.AutoSize = true;
            this.lbl_connectionStatus.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_connectionStatus.Location = new System.Drawing.Point(6, 327);
            this.lbl_connectionStatus.Name = "lbl_connectionStatus";
            this.lbl_connectionStatus.Size = new System.Drawing.Size(133, 13);
            this.lbl_connectionStatus.TabIndex = 5;
            this.lbl_connectionStatus.Text = "عدم اتصال به بانک اطلاعاتی";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(824, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(840, 417);
            this.Name = "main_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_userNOT;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Timer RTC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox RTB_notes;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_reception;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.ToolStripMenuItem sssssToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_crew;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_connectionStatus;
    }
}

