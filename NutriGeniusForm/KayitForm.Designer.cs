namespace NutriGeniusForm
{
    partial class KayitForm
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            label1 = new Label();
            dtpBirthDate = new DateTimePicker();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnSignIn = new Button();
            cbMail = new ComboBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(426, 144);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(242, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(426, 182);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(242, 27);
            txtLastName.TabIndex = 1;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.BackColor = Color.Transparent;
            rbFemale.Location = new Point(435, 228);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(68, 24);
            rbFemale.TabIndex = 2;
            rbFemale.TabStop = true;
            rbFemale.Text = "Kadın";
            rbFemale.UseVisualStyleBackColor = false;
            // 
            // rbMale
            // 
            rbMale.BackColor = Color.Transparent;
            rbMale.Location = new Point(534, 224);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(146, 30);
            rbMale.TabIndex = 3;
            rbMale.TabStop = true;
            rbMale.Text = "Erkek";
            rbMale.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(268, 275);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 4;
            label1.Text = "Doğum Tarihi (*):";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(425, 271);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(243, 27);
            dtpBirthDate.TabIndex = 5;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(425, 358);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(242, 27);
            txtWeight.TabIndex = 6;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(425, 320);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(242, 27);
            txtHeight.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(341, 320);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 9;
            label3.Text = "Boy (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(349, 148);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 10;
            label4.Text = "Ad (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(323, 186);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 11;
            label5.Text = "Soyad (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(304, 231);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 12;
            label6.Text = "Cinsiyet (*):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(336, 362);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 13;
            label7.Text = "Kilo (*):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(329, 444);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 17;
            label8.Text = "Şifre (*):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(270, 403);
            label9.Name = "label9";
            label9.Size = new Size(131, 23);
            label9.TabIndex = 16;
            label9.Text = "Kullanıcı Adı (*):";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(426, 399);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(77, 27);
            txtUserName.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(426, 440);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(242, 27);
            txtPassword.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(485, 92);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 18;
            label2.Text = "KAYIT OL";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.Orange;
            btnSignIn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.Location = new Point(426, 473);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(242, 35);
            btnSignIn.TabIndex = 19;
            btnSignIn.Text = "Kayıt Ol";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // cbMail
            // 
            cbMail.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMail.FormattingEnabled = true;
            cbMail.Items.AddRange(new object[] { "@hotmail.com", "@gmail.com", "@outlook.com", "@yahoo.com", "@yandex.com" });
            cbMail.Location = new Point(517, 398);
            cbMail.Name = "cbMail";
            cbMail.Size = new Size(151, 28);
            cbMail.TabIndex = 20;
            // 
            // KayitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.commonbackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(842, 553);
            Controls.Add(cbMail);
            Controls.Add(btnSignIn);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(dtpBirthDate);
            Controls.Add(label1);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            DoubleBuffered = true;
            Name = "KayitForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "KayitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Label label1;
        private DateTimePicker dtpBirthDate;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label2;
        private Button btnSignIn;
        private ComboBox cbMail;
    }
}