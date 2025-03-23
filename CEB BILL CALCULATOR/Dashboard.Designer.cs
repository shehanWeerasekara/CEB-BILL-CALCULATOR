namespace CEB_BILL_CALCULATOR
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.pnl_submenu = new System.Windows.Forms.Panel();
            this.pnl_rel_cat_R1 = new System.Windows.Forms.Button();
            this.pnl_dom_submenu = new System.Windows.Forms.Panel();
            this.btn_bill_rate = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_dom_cat_1 = new System.Windows.Forms.Button();
            this.btn_gov_gv_1 = new System.Windows.Forms.Button();
            this.btn_hot_cat_h_1 = new System.Windows.Forms.Button();
            this.btn_gen_cat_gp_1 = new System.Windows.Forms.Button();
            this.btn_ind_cat_i_1 = new System.Windows.Forms.Button();
            this.btn_bill_cal = new System.Windows.Forms.Button();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_left.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_submenu.SuspendLayout();
            this.pnl_dom_submenu.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.Cornsilk;
            this.pnl_left.Controls.Add(this.pnl_buttons);
            this.pnl_left.Controls.Add(this.pnl_logo);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(227, 582);
            this.pnl_left.TabIndex = 0;
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.Cornsilk;
            this.pnl_buttons.Controls.Add(this.pnl_submenu);
            this.pnl_buttons.Controls.Add(this.btn_bill_cal);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 138);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(227, 444);
            this.pnl_buttons.TabIndex = 1;
            // 
            // pnl_submenu
            // 
            this.pnl_submenu.BackColor = System.Drawing.Color.FloralWhite;
            this.pnl_submenu.Controls.Add(this.pnl_rel_cat_R1);
            this.pnl_submenu.Controls.Add(this.pnl_dom_submenu);
            this.pnl_submenu.Controls.Add(this.btn_dom_cat_1);
            this.pnl_submenu.Controls.Add(this.btn_gov_gv_1);
            this.pnl_submenu.Controls.Add(this.btn_hot_cat_h_1);
            this.pnl_submenu.Controls.Add(this.btn_gen_cat_gp_1);
            this.pnl_submenu.Controls.Add(this.btn_ind_cat_i_1);
            this.pnl_submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_submenu.Location = new System.Drawing.Point(0, 44);
            this.pnl_submenu.Name = "pnl_submenu";
            this.pnl_submenu.Size = new System.Drawing.Size(227, 425);
            this.pnl_submenu.TabIndex = 1;
            this.pnl_submenu.Visible = false;
            // 
            // pnl_rel_cat_R1
            // 
            this.pnl_rel_cat_R1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_rel_cat_R1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_rel_cat_R1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnl_rel_cat_R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_rel_cat_R1.Location = new System.Drawing.Point(0, 350);
            this.pnl_rel_cat_R1.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_rel_cat_R1.Name = "pnl_rel_cat_R1";
            this.pnl_rel_cat_R1.Size = new System.Drawing.Size(227, 50);
            this.pnl_rel_cat_R1.TabIndex = 6;
            this.pnl_rel_cat_R1.Text = "RELIGIOUS PURPOSE\r\nCATEGORY R-1\r\n";
            this.pnl_rel_cat_R1.UseVisualStyleBackColor = true;
            this.pnl_rel_cat_R1.Click += new System.EventHandler(this.pnl_rel_cat_R1_Click);
            // 
            // pnl_dom_submenu
            // 
            this.pnl_dom_submenu.Controls.Add(this.btn_bill_rate);
            this.pnl_dom_submenu.Controls.Add(this.btn_cal);
            this.pnl_dom_submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_dom_submenu.Location = new System.Drawing.Point(0, 250);
            this.pnl_dom_submenu.Name = "pnl_dom_submenu";
            this.pnl_dom_submenu.Size = new System.Drawing.Size(227, 100);
            this.pnl_dom_submenu.TabIndex = 5;
            this.pnl_dom_submenu.Visible = false;
            // 
            // btn_bill_rate
            // 
            this.btn_bill_rate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_bill_rate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bill_rate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bill_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill_rate.Location = new System.Drawing.Point(0, 50);
            this.btn_bill_rate.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bill_rate.Name = "btn_bill_rate";
            this.btn_bill_rate.Size = new System.Drawing.Size(227, 50);
            this.btn_bill_rate.TabIndex = 3;
            this.btn_bill_rate.Text = "BILL RATE";
            this.btn_bill_rate.UseVisualStyleBackColor = false;
            this.btn_bill_rate.Click += new System.EventHandler(this.btn_bill_rate_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_cal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.Location = new System.Drawing.Point(0, 0);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(227, 50);
            this.btn_cal.TabIndex = 2;
            this.btn_cal.Text = "CALCULATOR";
            this.btn_cal.UseVisualStyleBackColor = false;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_dom_cat_1
            // 
            this.btn_dom_cat_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dom_cat_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dom_cat_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dom_cat_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dom_cat_1.Location = new System.Drawing.Point(0, 200);
            this.btn_dom_cat_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dom_cat_1.Name = "btn_dom_cat_1";
            this.btn_dom_cat_1.Size = new System.Drawing.Size(227, 50);
            this.btn_dom_cat_1.TabIndex = 4;
            this.btn_dom_cat_1.Text = "DOMESTIC PURPOSE";
            this.btn_dom_cat_1.UseVisualStyleBackColor = true;
            this.btn_dom_cat_1.Click += new System.EventHandler(this.btn_dom_cat_1_Click);
            // 
            // btn_gov_gv_1
            // 
            this.btn_gov_gv_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gov_gv_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_gov_gv_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gov_gv_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gov_gv_1.Location = new System.Drawing.Point(0, 150);
            this.btn_gov_gv_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_gov_gv_1.Name = "btn_gov_gv_1";
            this.btn_gov_gv_1.Size = new System.Drawing.Size(227, 50);
            this.btn_gov_gv_1.TabIndex = 3;
            this.btn_gov_gv_1.Text = "GOVERNMENT PURPOSE\r\nCATEGORY GP-1";
            this.btn_gov_gv_1.UseVisualStyleBackColor = true;
            this.btn_gov_gv_1.Click += new System.EventHandler(this.btn_gov_gv_1_Click);
            // 
            // btn_hot_cat_h_1
            // 
            this.btn_hot_cat_h_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hot_cat_h_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hot_cat_h_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hot_cat_h_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hot_cat_h_1.Location = new System.Drawing.Point(0, 100);
            this.btn_hot_cat_h_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_hot_cat_h_1.Name = "btn_hot_cat_h_1";
            this.btn_hot_cat_h_1.Size = new System.Drawing.Size(227, 50);
            this.btn_hot_cat_h_1.TabIndex = 2;
            this.btn_hot_cat_h_1.Text = "HOTEL PURPOSE\r\nCATEGORY H-1\r\n";
            this.btn_hot_cat_h_1.UseVisualStyleBackColor = true;
            this.btn_hot_cat_h_1.Click += new System.EventHandler(this.btn_hot_cat_h_1_Click);
            // 
            // btn_gen_cat_gp_1
            // 
            this.btn_gen_cat_gp_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gen_cat_gp_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_gen_cat_gp_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gen_cat_gp_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gen_cat_gp_1.Location = new System.Drawing.Point(0, 50);
            this.btn_gen_cat_gp_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_gen_cat_gp_1.Name = "btn_gen_cat_gp_1";
            this.btn_gen_cat_gp_1.Size = new System.Drawing.Size(227, 50);
            this.btn_gen_cat_gp_1.TabIndex = 1;
            this.btn_gen_cat_gp_1.Text = "GENERAL PURPOSE\r\nCATEGORY GP-1\r\n";
            this.btn_gen_cat_gp_1.UseVisualStyleBackColor = true;
            this.btn_gen_cat_gp_1.Click += new System.EventHandler(this.btn_gen_cat_gp_1_Click);
            // 
            // btn_ind_cat_i_1
            // 
            this.btn_ind_cat_i_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ind_cat_i_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ind_cat_i_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ind_cat_i_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ind_cat_i_1.Location = new System.Drawing.Point(0, 0);
            this.btn_ind_cat_i_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ind_cat_i_1.Name = "btn_ind_cat_i_1";
            this.btn_ind_cat_i_1.Size = new System.Drawing.Size(227, 50);
            this.btn_ind_cat_i_1.TabIndex = 0;
            this.btn_ind_cat_i_1.Text = "INDUSTRIAL PURPOSE \r\nCATEGORY I - 1\r\n";
            this.btn_ind_cat_i_1.UseVisualStyleBackColor = true;
            this.btn_ind_cat_i_1.Click += new System.EventHandler(this.btn_ind_cat_i_1_Click);
            // 
            // btn_bill_cal
            // 
            this.btn_bill_cal.BackColor = System.Drawing.Color.Gold;
            this.btn_bill_cal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bill_cal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bill_cal.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_bill_cal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_bill_cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill_cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bill_cal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bill_cal.Location = new System.Drawing.Point(0, 0);
            this.btn_bill_cal.Name = "btn_bill_cal";
            this.btn_bill_cal.Size = new System.Drawing.Size(227, 44);
            this.btn_bill_cal.TabIndex = 0;
            this.btn_bill_cal.Text = "BILL CALCULATOR";
            this.btn_bill_cal.UseVisualStyleBackColor = false;
            this.btn_bill_cal.Click += new System.EventHandler(this.btn_bill_cal_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.Gold;
            this.pnl_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_logo.Controls.Add(this.label1);
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(227, 138);
            this.pnl_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEB BILL CALCULATOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_right
            // 
            this.pnl_right.AutoScroll = true;
            this.pnl_right.BackColor = System.Drawing.Color.Cornsilk;
            this.pnl_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_right.Location = new System.Drawing.Point(227, 0);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(861, 582);
            this.pnl_right.TabIndex = 1;
            this.pnl_right.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_right_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1088, 582);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_left);
            this.MinimumSize = new System.Drawing.Size(1106, 629);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CEB BILL CALCULATOR";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_submenu.ResumeLayout(false);
            this.pnl_dom_submenu.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_bill_cal;
        private System.Windows.Forms.Panel pnl_submenu;
        private System.Windows.Forms.Button btn_ind_cat_i_1;
        private System.Windows.Forms.Button btn_gov_gv_1;
        private System.Windows.Forms.Button btn_hot_cat_h_1;
        private System.Windows.Forms.Button btn_gen_cat_gp_1;
        private System.Windows.Forms.Panel pnl_dom_submenu;
        private System.Windows.Forms.Button btn_bill_rate;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_dom_cat_1;
        private System.Windows.Forms.Button pnl_rel_cat_R1;
    }
}

