namespace Presantation
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dataGridView1 = new DataGridView();
			groupBox1 = new GroupBox();
			CategoryForm = new ComboBox();
			Quantity_in_Stock = new TextBox();
			Price_0f_Produt = new TextBox();
			Name_of_Product = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			button1 = new Button();
			groupBox2 = new GroupBox();
			label5 = new Label();
			CategoryForm2 = new ComboBox();
			textBox8 = new TextBox();
			textBox7 = new TextBox();
			textBox6 = new TextBox();
			textBox5 = new TextBox();
			label10 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			button2 = new Button();
			groupBox3 = new GroupBox();
			textBox9 = new TextBox();
			label11 = new Label();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(24, 498);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1370, 364);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellClick += dataGridView1_CellContentClick;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(CategoryForm);
			groupBox1.Controls.Add(Quantity_in_Stock);
			groupBox1.Controls.Add(Price_0f_Produt);
			groupBox1.Controls.Add(Name_of_Product);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(button1);
			groupBox1.Font = new Font("SansSerif", 17.9999981F, FontStyle.Bold);
			groupBox1.ForeColor = Color.White;
			groupBox1.Location = new Point(54, 27);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(395, 421);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Add Product";
			// 
			// CategoryForm
			// 
			CategoryForm.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			CategoryForm.FormattingEnabled = true;
			CategoryForm.Location = new Point(207, 283);
			CategoryForm.Name = "CategoryForm";
			CategoryForm.Size = new Size(158, 31);
			CategoryForm.TabIndex = 3;
			// 
			// Quantity_in_Stock
			// 
			Quantity_in_Stock.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			Quantity_in_Stock.Location = new Point(207, 176);
			Quantity_in_Stock.Name = "Quantity_in_Stock";
			Quantity_in_Stock.Size = new Size(158, 31);
			Quantity_in_Stock.TabIndex = 5;
			// 
			// Price_0f_Produt
			// 
			Price_0f_Produt.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			Price_0f_Produt.Location = new Point(207, 122);
			Price_0f_Produt.Name = "Price_0f_Produt";
			Price_0f_Produt.Size = new Size(158, 31);
			Price_0f_Produt.TabIndex = 4;
			// 
			// Name_of_Product
			// 
			Name_of_Product.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			Name_of_Product.Location = new Point(207, 72);
			Name_of_Product.Name = "Name_of_Product";
			Name_of_Product.Size = new Size(158, 31);
			Name_of_Product.TabIndex = 3;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label4.Location = new Point(25, 289);
			label4.Name = "label4";
			label4.Size = new Size(96, 23);
			label4.TabIndex = 3;
			label4.Text = "Category";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label3.Location = new Point(25, 176);
			label3.Name = "label3";
			label3.Size = new Size(176, 23);
			label3.TabIndex = 3;
			label3.Text = "Quantity in Stock";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label2.Location = new Point(25, 126);
			label2.Name = "label2";
			label2.Size = new Size(59, 23);
			label2.TabIndex = 3;
			label2.Text = "Price";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label1.Location = new Point(25, 75);
			label1.Name = "label1";
			label1.Size = new Size(145, 23);
			label1.TabIndex = 1;
			label1.Text = "Product Name";
			label1.Click += label1_Click_1;
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.BackColor = Color.DodgerBlue;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
			button1.ForeColor = Color.White;
			button1.Location = new Point(234, 353);
			button1.Name = "button1";
			button1.Size = new Size(131, 51);
			button1.TabIndex = 3;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click_1;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top;
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(CategoryForm2);
			groupBox2.Controls.Add(textBox8);
			groupBox2.Controls.Add(textBox7);
			groupBox2.Controls.Add(textBox6);
			groupBox2.Controls.Add(textBox5);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(button2);
			groupBox2.Font = new Font("SansSerif", 17.9999981F, FontStyle.Bold);
			groupBox2.ForeColor = Color.White;
			groupBox2.Location = new Point(508, 27);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(429, 421);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Update Product";
			groupBox2.Enter += groupBox2_Enter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label5.Location = new Point(33, 122);
			label5.Name = "label5";
			label5.Size = new Size(109, 23);
			label5.TabIndex = 8;
			label5.Text = "Product Id";
			label5.Click += label5_Click;
			// 
			// CategoryForm2
			// 
			CategoryForm2.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			CategoryForm2.FormattingEnabled = true;
			CategoryForm2.Location = new Point(244, 281);
			CategoryForm2.Name = "CategoryForm2";
			CategoryForm2.Size = new Size(158, 31);
			CategoryForm2.TabIndex = 7;
			// 
			// textBox8
			// 
			textBox8.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			textBox8.Location = new Point(244, 118);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(158, 31);
			textBox8.TabIndex = 7;
			textBox8.TextChanged += textBox8_TextChanged;
			// 
			// textBox7
			// 
			textBox7.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			textBox7.Location = new Point(244, 173);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(158, 31);
			textBox7.TabIndex = 7;
			// 
			// textBox6
			// 
			textBox6.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			textBox6.Location = new Point(244, 230);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(158, 31);
			textBox6.TabIndex = 7;
			// 
			// textBox5
			// 
			textBox5.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			textBox5.Location = new Point(244, 71);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(158, 31);
			textBox5.TabIndex = 7;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label10.Location = new Point(33, 286);
			label10.Name = "label10";
			label10.Size = new Size(96, 23);
			label10.TabIndex = 7;
			label10.Text = "Category";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label8.Location = new Point(33, 179);
			label8.Name = "label8";
			label8.Size = new Size(176, 23);
			label8.TabIndex = 7;
			label8.Text = "Quantity in Stock";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label7.Location = new Point(33, 230);
			label7.Name = "label7";
			label7.Size = new Size(59, 23);
			label7.TabIndex = 7;
			label7.Text = "Price";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label6.Location = new Point(33, 79);
			label6.Name = "label6";
			label6.Size = new Size(145, 23);
			label6.TabIndex = 7;
			label6.Text = "Product Name";
			label6.Click += label6_Click;
			// 
			// button2
			// 
			button2.AutoSize = true;
			button2.BackColor = Color.DodgerBlue;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
			button2.ForeColor = Color.White;
			button2.Location = new Point(271, 353);
			button2.Name = "button2";
			button2.Size = new Size(131, 51);
			button2.TabIndex = 0;
			button2.Text = "Update";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			groupBox3.Controls.Add(textBox9);
			groupBox3.Controls.Add(label11);
			groupBox3.Controls.Add(button3);
			groupBox3.Font = new Font("SansSerif", 17.9999981F, FontStyle.Bold);
			groupBox3.ForeColor = Color.White;
			groupBox3.Location = new Point(992, 27);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(368, 294);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Delete Product";
			groupBox3.Enter += groupBox3_Enter;
			// 
			// textBox9
			// 
			textBox9.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			textBox9.Location = new Point(189, 76);
			textBox9.Name = "textBox9";
			textBox9.Size = new Size(158, 31);
			textBox9.TabIndex = 8;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label11.Location = new Point(32, 79);
			label11.Name = "label11";
			label11.Size = new Size(109, 23);
			label11.TabIndex = 8;
			label11.Text = "Product Id";
			// 
			// button3
			// 
			button3.AutoSize = true;
			button3.BackColor = Color.DodgerBlue;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
			button3.ForeColor = Color.White;
			button3.Location = new Point(216, 202);
			button3.Name = "button3";
			button3.Size = new Size(131, 51);
			button3.TabIndex = 0;
			button3.Text = "Delete";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Anchor = AnchorStyles.Right;
			button4.AutoSize = true;
			button4.BackColor = Color.DodgerBlue;
			button4.FlatStyle = FlatStyle.Flat;
			button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
			button4.ForeColor = Color.White;
			button4.Location = new Point(992, 380);
			button4.Name = "button4";
			button4.Size = new Size(152, 51);
			button4.TabIndex = 3;
			button4.Text = "Export to Excel";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Anchor = AnchorStyles.Right;
			button5.AutoSize = true;
			button5.BackColor = Color.DodgerBlue;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
			button5.ForeColor = Color.White;
			button5.Location = new Point(1208, 380);
			button5.Name = "button5";
			button5.Size = new Size(152, 51);
			button5.TabIndex = 4;
			button5.Text = "Back";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(120F, 120F);
			AutoScaleMode = AutoScaleMode.Dpi;
			BackColor = Color.FromArgb(174, 217, 249);
			ClientSize = new Size(1411, 883);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(dataGridView1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Name = "Form2";
			Padding = new Padding(5);
			Text = "Form2";
			WindowState = FormWindowState.Maximized;
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private Button button1;
		private Button button2;
		private Button button3;
		private Label label1;

		private TextBox Quantity_in_Stock;
		private TextBox Price_0f_Produt;
		private TextBox Name_of_Product;
		private Label label4;
		private Label label3;
		private Label label2;
		private ComboBox CategoryForm;
		private Label label6;
		private TextBox textBox5;
		private Label label10;
		private Label label8;
		private Label label7;
		private ComboBox CategoryForm2;

		private TextBox textBox8;
		private TextBox textBox7;
		private TextBox textBox6;
		private TextBox textBox9;
		private Label label11;

		private Button button4;
		private Button button5;
		private Label label5;

	}  
}
