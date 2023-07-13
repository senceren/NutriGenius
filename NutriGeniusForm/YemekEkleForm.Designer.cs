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
            label2 = new Label();
            lblMealName = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnAddFood = new Button();
            label5 = new Label();
            cbPortions = new ComboBox();
            label6 = new Label();
            nudPiece = new NumericUpDown();
            btnAdd = new Button();
            cbFoods = new ComboBox();
            dgvFoods = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPiece).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 114);
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
            cbFoodCategory.Location = new Point(82, 147);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(298, 28);
            cbFoodCategory.TabIndex = 1;
            cbFoodCategory.SelectedIndexChanged += cbFoodCategory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 185);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 3;
            label2.Text = "Yemekler";
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.BackColor = Color.Transparent;
            lblMealName.BorderStyle = BorderStyle.FixedSingle;
            lblMealName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMealName.Location = new Point(642, 30);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(57, 30);
            lblMealName.TabIndex = 5;
            lblMealName.Text = "label";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BackColor = Color.Orange;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(439, 428);
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
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 68);
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
            label4.Location = new Point(91, 30);
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
            label3.Location = new Point(439, 102);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 9;
            label3.Text = "Seçilenler";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.YellowGreen;
            btnAddFood.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(81, 467);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(305, 40);
            btnAddFood.TabIndex = 11;
            btnAddFood.Text = "Aradığım yemek listede yok";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(82, 256);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 12;
            label5.Text = "Porsiyon";
            // 
            // cbPortions
            // 
            cbPortions.DisplayMember = "Unit";
            cbPortions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPortions.FormattingEnabled = true;
            cbPortions.Location = new Point(82, 289);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(298, 28);
            cbPortions.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(87, 327);
            label6.Name = "label6";
            label6.Size = new Size(46, 23);
            label6.TabIndex = 14;
            label6.Text = "Adet";
            // 
            // nudPiece
            // 
            nudPiece.Location = new Point(83, 360);
            nudPiece.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPiece.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPiece.Name = "nudPiece";
            nudPiece.Size = new Size(304, 27);
            nudPiece.TabIndex = 15;
            nudPiece.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orange;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(81, 418);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(304, 40);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbFoods
            // 
            cbFoods.DisplayMember = "FoodName";
            cbFoods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoods.FormattingEnabled = true;
            cbFoods.Location = new Point(87, 218);
            cbFoods.Name = "cbFoods";
            cbFoods.Size = new Size(293, 28);
            cbFoods.TabIndex = 17;
            cbFoods.SelectedIndexChanged += cbFoods_SelectedIndexChanged;
            // 
            // dgvFoods
            // 
            dgvFoods.AllowUserToAddRows = false;
            dgvFoods.AllowUserToDeleteRows = false;
            dgvFoods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoods.Location = new Point(439, 136);
            dgvFoods.MultiSelect = false;
            dgvFoods.Name = "dgvFoods";
            dgvFoods.ReadOnly = true;
            dgvFoods.RowHeadersVisible = false;
            dgvFoods.RowHeadersWidth = 51;
            dgvFoods.RowTemplate.Height = 29;
            dgvFoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoods.Size = new Size(323, 274);
            dgvFoods.TabIndex = 18;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(439, 474);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(323, 36);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Seçiliyi Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // YemekEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            ClientSize = new Size(842, 553);
            Controls.Add(btnDelete);
            Controls.Add(dgvFoods);
            Controls.Add(cbFoods);
            Controls.Add(btnAdd);
            Controls.Add(nudPiece);
            Controls.Add(label6);
            Controls.Add(cbPortions);
            Controls.Add(label5);
            Controls.Add(btnAddFood);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(lblMealName);
            Controls.Add(label2);
            Controls.Add(cbFoodCategory);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "YemekEkleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "YemekEkleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPiece).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbFoodCategory;
        private Label label2;
        private Button btnSave;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        public Label lblMealName;
        private Button btnAddFood;
        private Label label5;
        private ComboBox cbPortions;
        private Label label6;
        private NumericUpDown nudPiece;
        private Button btnAdd;
        private ComboBox cbFoods;
        private DataGridView dgvFoods;
        private Button btnDelete;
    }
}