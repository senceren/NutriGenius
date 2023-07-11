namespace NutriGeniusForm
{
    partial class AcilisForm
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
            btnSignIn = new Button();
            btnLogIn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.Location = new Point(242, 438);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(311, 38);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sağlık Yolculuğuna Başla";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.Location = new Point(459, 482);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 37);
            btnLogIn.TabIndex = 1;
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
            label1.Location = new Point(242, 487);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 2;
            label1.Text = "Zaten bir hesabım var.";
            // 
            // AcilisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.acilis1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(842, 553);
            Controls.Add(label1);
            Controls.Add(btnLogIn);
            Controls.Add(btnSignIn);
            DoubleBuffered = true;
            Name = "AcilisForm";
            Text = "AcilisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private Button btnLogIn;
        private Label label1;
    }
}