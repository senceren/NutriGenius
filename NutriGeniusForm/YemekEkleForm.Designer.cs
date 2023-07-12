namespace NutriGeniusForm
{
    partial class YemekEkleForm
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
            label1 = new Label();
            cbFoodCategory = new ComboBox();
            clbFoods = new CheckedListBox();
            label2 = new Label();
            lstFoods = new ListBox();
            lblMealName = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnAddFood = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 99);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "Kategoriler";
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.DisplayMember = "CategoryName";
            cbFoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(63, 126);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(298, 28);
            cbFoodCategory.TabIndex = 1;
            cbFoodCategory.SelectedIndexChanged += cbFoodCategory_SelectedIndexChanged;
            // 
            // clbFoods
            // 
            clbFoods.FormattingEnabled = true;
            clbFoods.Location = new Point(63, 200);
            clbFoods.Name = "clbFoods";
            clbFoods.Size = new Size(298, 268);
            clbFoods.TabIndex = 2;
            clbFoods.ItemCheck += clbFoods_ItemCheck;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 174);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 3;
            label2.Text = "Yemekler";
            // 
            // lstFoods
            // 
            lstFoods.FormattingEnabled = true;
            lstFoods.ItemHeight = 20;
            lstFoods.Location = new Point(446, 136);
            lstFoods.Name = "lstFoods";
            lstFoods.Size = new Size(323, 344);
            lstFoods.TabIndex = 4;
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.BackColor = Color.Transparent;
            lblMealName.BorderStyle = BorderStyle.FixedSingle;
            lblMealName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMealName.Location = new Point(703, 37);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(57, 30);
            lblMealName.TabIndex = 5;
            lblMealName.Text = "label";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(446, 494);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(323, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Blue_Green_Grey_Chiropractic_Logo___2_;
            pictureBox1.Location = new Point(13, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(107, 38);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 8;
            label4.Text = "Yemek Ekle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(446, 99);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 9;
            label3.Text = "Seçilenler";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.YellowGreen;
            btnAddFood.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(63, 494);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(298, 40);
            btnAddFood.TabIndex = 11;
            btnAddFood.Text = "Aradığım yemek listede yok";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // YemekEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            ClientSize = new Size(842, 553);
            Controls.Add(btnAddFood);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(lblMealName);
            Controls.Add(lstFoods);
            Controls.Add(label2);
            Controls.Add(clbFoods);
            Controls.Add(cbFoodCategory);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "YemekEkleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "YemekEkleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbFoodCategory;
        private CheckedListBox clbFoods;
        private Label label2;
        private ListBox lstFoods;
        private Button btnSave;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        public Label lblMealName;
        private Button btnAddFood;
    }
}