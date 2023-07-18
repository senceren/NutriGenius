namespace NutriGeniusForm
{
    partial class GünlükForm
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
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lstBreakfast = new ListBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lstLunch = new ListBox();
            label3 = new Label();
            lstDinner = new ListBox();
            label4 = new Label();
            lstSnack = new ListBox();
            dtpDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.english_breakfast;
            pictureBox1.Location = new Point(59, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.lunch_time;
            pictureBox3.Location = new Point(313, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.snacks;
            pictureBox4.Location = new Point(821, 108);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // lstBreakfast
            // 
            lstBreakfast.FormattingEnabled = true;
            lstBreakfast.ItemHeight = 20;
            lstBreakfast.Location = new Point(45, 215);
            lstBreakfast.Name = "lstBreakfast";
            lstBreakfast.Size = new Size(175, 264);
            lstBreakfast.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.christmas_dinner;
            pictureBox2.Location = new Point(556, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(86, 182);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 24;
            label1.Text = "Sabah ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(344, 182);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 26;
            label2.Text = "Öğle";
            // 
            // lstLunch
            // 
            lstLunch.FormattingEnabled = true;
            lstLunch.ItemHeight = 20;
            lstLunch.Location = new Point(287, 215);
            lstLunch.Name = "lstLunch";
            lstLunch.Size = new Size(175, 264);
            lstLunch.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(588, 182);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 28;
            label3.Text = "Akşam";
            // 
            // lstDinner
            // 
            lstDinner.FormattingEnabled = true;
            lstDinner.ItemHeight = 20;
            lstDinner.Location = new Point(538, 215);
            lstDinner.Name = "lstDinner";
            lstDinner.Size = new Size(175, 264);
            lstDinner.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(837, 182);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 30;
            label4.Text = "Ara Öğün";
            // 
            // lstSnack
            // 
            lstSnack.FormattingEnabled = true;
            lstSnack.ItemHeight = 20;
            lstSnack.Location = new Point(798, 215);
            lstSnack.Name = "lstSnack";
            lstSnack.Size = new Size(175, 264);
            lstSnack.TabIndex = 29;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(38, 37);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 31;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // GünlükForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            ClientSize = new Size(1022, 553);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(lstSnack);
            Controls.Add(label3);
            Controls.Add(lstDinner);
            Controls.Add(label2);
            Controls.Add(lstLunch);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lstBreakfast);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "GünlükForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GünlükForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ListBox lstBreakfast;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private ListBox lstLunch;
        private Label label3;
        private ListBox lstDinner;
        private Label label4;
        private ListBox lstSnack;
        private DateTimePicker dtpDate;
    }
}