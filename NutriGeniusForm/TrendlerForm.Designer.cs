namespace NutriGeniusForm
{
    partial class TrendlerForm
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
            btnWeekly = new Button();
            mtnMonthly = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblName = new Label();
            label8 = new Label();
            lblBreakfastUser = new Label();
            lblBreakfastSum = new Label();
            lblLunchSum = new Label();
            lblDinnerSum = new Label();
            lblSnackSum = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label9 = new Label();
            dgvTop5 = new DataGridView();
            lblSnackUser = new Label();
            lblDinnerUser = new Label();
            lblLunchUser = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            SuspendLayout();
            // 
            // btnWeekly
            // 
            btnWeekly.BackColor = Color.LightGray;
            btnWeekly.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeekly.Location = new Point(816, 224);
            btnWeekly.Name = "btnWeekly";
            btnWeekly.Size = new Size(106, 29);
            btnWeekly.TabIndex = 1;
            btnWeekly.Text = "Haftalık";
            btnWeekly.UseVisualStyleBackColor = false;
            btnWeekly.Click += btnWeekly_Click;
            // 
            // mtnMonthly
            // 
            mtnMonthly.BackColor = Color.LightGray;
            mtnMonthly.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mtnMonthly.Location = new Point(816, 259);
            mtnMonthly.Name = "mtnMonthly";
            mtnMonthly.Size = new Size(106, 29);
            mtnMonthly.TabIndex = 2;
            mtnMonthly.Text = "Aylık";
            mtnMonthly.UseVisualStyleBackColor = false;
            mtnMonthly.Click += mtnMonthly_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 27);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 3;
            label1.Text = "KALORİ YARIŞLARI!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 326);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 4;
            label2.Text = "TOP 5 YEMEK!";
            // 
            // label3
            // 
            label3.BackColor = Color.Orange;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(155, 73);
            label3.Name = "label3";
            label3.Size = new Size(92, 37);
            label3.TabIndex = 5;
            label3.Text = "Sabah";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Orange;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(278, 73);
            label4.Name = "label4";
            label4.Size = new Size(100, 37);
            label4.TabIndex = 6;
            label4.Text = "Öğle";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Orange;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(403, 73);
            label5.Name = "label5";
            label5.Size = new Size(103, 37);
            label5.TabIndex = 7;
            label5.Text = "Akşam";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Orange;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(532, 71);
            label6.Name = "label6";
            label6.Size = new Size(112, 37);
            label6.TabIndex = 8;
            label6.Text = "Ara Öğün";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = Color.OrangeRed;
            lblName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(38, 128);
            lblName.Name = "lblName";
            lblName.Size = new Size(97, 55);
            lblName.TabIndex = 9;
            lblName.Text = "label7";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.DarkOrange;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 227);
            label8.Name = "label8";
            label8.Size = new Size(97, 55);
            label8.TabIndex = 10;
            label8.Text = "Diğer Kullanıcılar";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBreakfastUser
            // 
            lblBreakfastUser.BackColor = Color.LightSalmon;
            lblBreakfastUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBreakfastUser.Location = new Point(155, 128);
            lblBreakfastUser.Name = "lblBreakfastUser";
            lblBreakfastUser.Size = new Size(103, 55);
            lblBreakfastUser.TabIndex = 11;
            lblBreakfastUser.Text = " ";
            lblBreakfastUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBreakfastSum
            // 
            lblBreakfastSum.BackColor = Color.Bisque;
            lblBreakfastSum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblBreakfastSum.Location = new Point(155, 227);
            lblBreakfastSum.Name = "lblBreakfastSum";
            lblBreakfastSum.Size = new Size(109, 55);
            lblBreakfastSum.TabIndex = 12;
            lblBreakfastSum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLunchSum
            // 
            lblLunchSum.BackColor = Color.Bisque;
            lblLunchSum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLunchSum.Location = new Point(285, 227);
            lblLunchSum.Name = "lblLunchSum";
            lblLunchSum.Size = new Size(100, 55);
            lblLunchSum.TabIndex = 14;
            lblLunchSum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDinnerSum
            // 
            lblDinnerSum.BackColor = Color.Bisque;
            lblDinnerSum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDinnerSum.Location = new Point(401, 227);
            lblDinnerSum.Name = "lblDinnerSum";
            lblDinnerSum.Size = new Size(103, 55);
            lblDinnerSum.TabIndex = 16;
            lblDinnerSum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSnackSum
            // 
            lblSnackSum.BackColor = Color.Bisque;
            lblSnackSum.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSnackSum.Location = new Point(532, 227);
            lblSnackSum.Name = "lblSnackSum";
            lblSnackSum.Size = new Size(112, 55);
            lblSnackSum.TabIndex = 18;
            lblSnackSum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.racing_flag;
            pictureBox1.Location = new Point(748, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.top_5;
            pictureBox2.Location = new Point(796, 408);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(650, 160);
            label7.Name = "label7";
            label7.Size = new Size(40, 23);
            label7.TabIndex = 22;
            label7.Text = "kcal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(650, 261);
            label9.Name = "label9";
            label9.Size = new Size(40, 23);
            label9.TabIndex = 23;
            label9.Text = "kcal";
            // 
            // dgvTop5
            // 
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5.Location = new Point(38, 373);
            dgvTop5.Name = "dgvTop5";
            dgvTop5.RowHeadersWidth = 51;
            dgvTop5.RowTemplate.Height = 29;
            dgvTop5.Size = new Size(686, 168);
            dgvTop5.TabIndex = 24;
            // 
            // lblSnackUser
            // 
            lblSnackUser.BackColor = Color.LightSalmon;
            lblSnackUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSnackUser.Location = new Point(532, 128);
            lblSnackUser.Name = "lblSnackUser";
            lblSnackUser.Size = new Size(112, 55);
            lblSnackUser.TabIndex = 17;
            lblSnackUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDinnerUser
            // 
            lblDinnerUser.BackColor = Color.LightSalmon;
            lblDinnerUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDinnerUser.Location = new Point(405, 128);
            lblDinnerUser.Name = "lblDinnerUser";
            lblDinnerUser.Size = new Size(103, 55);
            lblDinnerUser.TabIndex = 15;
            lblDinnerUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLunchUser
            // 
            lblLunchUser.BackColor = Color.LightSalmon;
            lblLunchUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLunchUser.Location = new Point(280, 128);
            lblLunchUser.Name = "lblLunchUser";
            lblLunchUser.Size = new Size(100, 55);
            lblLunchUser.TabIndex = 13;
            lblLunchUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrendlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            ClientSize = new Size(1022, 553);
            Controls.Add(dgvTop5);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(lblSnackSum);
            Controls.Add(lblSnackUser);
            Controls.Add(lblDinnerSum);
            Controls.Add(lblDinnerUser);
            Controls.Add(lblLunchSum);
            Controls.Add(lblLunchUser);
            Controls.Add(lblBreakfastSum);
            Controls.Add(lblBreakfastUser);
            Controls.Add(label8);
            Controls.Add(lblName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mtnMonthly);
            Controls.Add(btnWeekly);
            Controls.Add(pictureBox1);
            Name = "TrendlerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TrendlerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWeekly;
        private Button mtnMonthly;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblName;
        private Label label8;
        private Label lblBreakfastUser;
        private Label lblBreakfastSum;
        private Label lblLunchSum;
        private Label lblDinnerSum;
        private Label lblSnackSum;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label9;
        private DataGridView dgvTop5;
        private Label lblSnackUser;
        private Label lblDinnerUser;
        private Label lblLunchUser;
    }
}