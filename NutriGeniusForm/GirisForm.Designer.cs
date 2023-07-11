namespace NutriGeniusForm
{
    partial class GirisForm
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
            btnLogIn = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.Location = new Point(383, 331);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(196, 34);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Giriş Yap";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(265, 256);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(325, 293);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(383, 257);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(196, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(383, 293);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 27);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(249, 395);
            label3.Name = "label3";
            label3.Size = new Size(356, 126);
            label3.TabIndex = 5;
            label3.Text = "NutriGenius, sağlıklı beslenme yolcuğunuzda günlük kalori alımlarınızı takip ederek sizin için muhteşem bir yol arkadaşı ve motivasyon kaynağı olur!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.giris1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(842, 553);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogIn);
            DoubleBuffered = true;
            Name = "GirisForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GirisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label3;
    }
}