namespace NutriGeniusForm
{
    partial class KullanıcıYemekEkleForm
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
            txtFoodName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbFoodCategories = new ComboBox();
            label3 = new Label();
            cbPortions = new ComboBox();
            label4 = new Label();
            txtCalorie = new TextBox();
            label5 = new Label();
            btnAddFood = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(337, 186);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(230, 27);
            txtFoodName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(225, 190);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 1;
            label1.Text = "Yemek Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(175, 244);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 2;
            label2.Text = "Yemek Kategorisi:";
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.DisplayMember = "CategoryName";
            cbFoodCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(337, 243);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(230, 28);
            cbFoodCategories.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(240, 299);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 4;
            label3.Text = "Porsiyon:";
            // 
            // cbPortions
            // 
            cbPortions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPortions.FormattingEnabled = true;
            cbPortions.Items.AddRange(new object[] { "Porsiyon", "Gram", "Adet", "Bardak ", "Yemek Kaşığı" });
            cbPortions.Location = new Point(360, 299);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(207, 28);
            cbPortions.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(252, 357);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 6;
            label4.Text = "Kalori:";
            // 
            // txtCalorie
            // 
            txtCalorie.Location = new Point(337, 357);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(230, 27);
            txtCalorie.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(337, 300);
            label5.Name = "label5";
            label5.Size = new Size(17, 23);
            label5.TabIndex = 8;
            label5.Text = "1";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.Orange;
            btnAddFood.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(337, 411);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(230, 45);
            btnAddFood.TabIndex = 9;
            btnAddFood.Text = "Ekle";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(122, 59);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 11;
            label6.Text = "Yemek Ekle";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Blue_Green_Grey_Chiropractic_Logo___2_;
            pictureBox1.Location = new Point(28, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.calories;
            pictureBox2.Location = new Point(327, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 126);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // KullanıcıYemekEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            ClientSize = new Size(842, 553);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddFood);
            Controls.Add(label5);
            Controls.Add(txtCalorie);
            Controls.Add(label4);
            Controls.Add(cbPortions);
            Controls.Add(label3);
            Controls.Add(cbFoodCategories);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFoodName);
            Name = "KullanıcıYemekEkleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "KullanıcıYemekEkleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFoodName;
        private Label label1;
        private Label label2;
        private ComboBox cbFoodCategories;
        private Label label3;
        private ComboBox cbPortions;
        private Label label4;
        private TextBox txtCalorie;
        private Label label5;
        private Button btnAddFood;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}