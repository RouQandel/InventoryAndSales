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
            supIdForm = new TextBox();
            Quantity_in_Stock = new TextBox();
            Price_0f_Produt = new TextBox();
            label5 = new Label();
            Name_of_Product = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            CategoryForm2 = new ComboBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            groupBox3 = new GroupBox();
            textBox9 = new TextBox();
            label11 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 398);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1096, 291);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CategoryForm);
            groupBox1.Controls.Add(supIdForm);
            groupBox1.Controls.Add(Quantity_in_Stock);
            groupBox1.Controls.Add(Price_0f_Produt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Name_of_Product);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(43, 22);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(292, 337);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            // 
            // CategoryForm
            // 
            CategoryForm.FormattingEnabled = true;
            CategoryForm.Location = new Point(137, 229);
            CategoryForm.Margin = new Padding(2);
            CategoryForm.Name = "CategoryForm";
            CategoryForm.Size = new Size(127, 25);
            CategoryForm.TabIndex = 3;
            // 
            // supIdForm
            // 
            supIdForm.Location = new Point(137, 184);
            supIdForm.Margin = new Padding(2);
            supIdForm.Name = "supIdForm";
            supIdForm.Size = new Size(127, 25);
            supIdForm.TabIndex = 6;
            // 
            // Quantity_in_Stock
            // 
            Quantity_in_Stock.Location = new Point(137, 141);
            Quantity_in_Stock.Margin = new Padding(2);
            Quantity_in_Stock.Name = "Quantity_in_Stock";
            Quantity_in_Stock.Size = new Size(127, 25);
            Quantity_in_Stock.TabIndex = 5;
            // 
            // Price_0f_Produt
            // 
            Price_0f_Produt.Location = new Point(137, 98);
            Price_0f_Produt.Margin = new Padding(2);
            Price_0f_Produt.Name = "Price_0f_Produt";
            Price_0f_Produt.Size = new Size(127, 25);
            Price_0f_Produt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 184);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 3;
            label5.Text = "Supplier Id";
            // 
            // Name_of_Product
            // 
            Name_of_Product.Location = new Point(137, 58);
            Name_of_Product.Margin = new Padding(2);
            Name_of_Product.Name = "Name_of_Product";
            Name_of_Product.Size = new Size(127, 25);
            Name_of_Product.TabIndex = 3;
            Name_of_Product.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 231);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 3;
            label3.Text = "Quantity in Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(188, 297);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CategoryForm2);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(406, 22);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(326, 337);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Product";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // CategoryForm2
            // 
            CategoryForm2.FormattingEnabled = true;
            CategoryForm2.Location = new Point(165, 225);
            CategoryForm2.Margin = new Padding(2);
            CategoryForm2.Name = "CategoryForm2";
            CategoryForm2.Size = new Size(127, 25);
            CategoryForm2.TabIndex = 7;
            CategoryForm2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(165, 182);
            textBox8.Margin = new Padding(2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(127, 25);
            textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(165, 141);
            textBox7.Margin = new Padding(2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(127, 25);
            textBox7.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(165, 98);
            textBox6.Margin = new Padding(2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(127, 25);
            textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(165, 61);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 25);
            textBox5.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 229);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 19);
            label10.TabIndex = 7;
            label10.Text = "Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 184);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 19);
            label9.TabIndex = 7;
            label9.Text = "Supplier Id";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 143);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 19);
            label8.TabIndex = 7;
            label8.Text = "Quantity in Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 104);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 19);
            label7.TabIndex = 7;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 63);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 19);
            label6.TabIndex = 7;
            label6.Text = "Product Name";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(216, 297);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox9);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(button3);
            groupBox3.Font = new Font("Segoe UI", 10F);
            groupBox3.Location = new Point(794, 22);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(294, 337);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Delete Product";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(151, 61);
            textBox9.Margin = new Padding(2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(127, 25);
            textBox9.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 63);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(73, 19);
            label11.TabIndex = 8;
            label11.Text = "Product Id";
            // 
            // button3
            // 
            button3.Location = new Point(202, 297);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1093, 596);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "Form2";
            Padding = new Padding(4);
            Text = "Form2";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private ComboBox CategoryForm;
		private TextBox supIdForm;
		private Label label6;
		private TextBox textBox5;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private ComboBox CategoryForm2;
		private TextBox textBox8;
		private TextBox textBox7;
		private TextBox textBox6;
		private TextBox textBox9;
		private Label label11;
	}  
}
