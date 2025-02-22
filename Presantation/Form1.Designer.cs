namespace Presantation
{
    partial class Form1
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

			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();

			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.Font = new Font("SansSerif", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label2.ForeColor = Color.White;
			label2.Location = new Point(69, 83);
			label2.Name = "label2";
			label2.Size = new Size(335, 46);

			label2.TabIndex = 1;
			label2.Text = " Key Features:";
			// 
			// label3
			// 
			label3.AutoSize = true;

			label3.Font = new Font("SansSerif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label3.ForeColor = Color.White;
			label3.Location = new Point(114, 151);
			label3.Name = "label3";
			label3.Size = new Size(335, 31);
			label3.TabIndex = 2;
			label3.Text = "1 - Product Management:";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.Font = new Font("SansSerif", 16.1999989F);
			label4.ForeColor = Color.White;
			label4.Location = new Point(164, 205);

			label4.Name = "label4";
			label4.Size = new Size(1173, 45);
			label4.TabIndex = 3;
			label4.Text = "- Display All Products: View a comprehensive list of all available products with detailed information such as name, category, price, and stock quantity.";
			label4.Click += label4_Click;
			// 
			// label5
			// 

			label5.Font = new Font("SansSerif", 16.1999989F);
			label5.ForeColor = Color.White;
			label5.Location = new Point(164, 251);

			label5.Name = "label5";
			label5.Size = new Size(1173, 45);
			label5.TabIndex = 4;
			label5.Text = "- Add New Products: Easily add new products to the inventory by entering relevant details like product name, description, price, and stock level.\r\n";
			// 
			// label6
			// 

			label6.Font = new Font("SansSerif", 16.1999989F);
			label6.ForeColor = Color.White;
			label6.Location = new Point(164, 295);

			label6.Name = "label6";
			label6.Size = new Size(1173, 45);
			label6.TabIndex = 5;
			label6.Text = "- Update Products: Edit product details to keep the inventory accurate and up-to-date.\r\n";
			// 
			// label7
			// 

			label7.Font = new Font("SansSerif", 16.1999989F);
			label7.ForeColor = Color.White;
			label7.Location = new Point(164, 340);

			label7.Name = "label7";
			label7.Size = new Size(1173, 45);
			label7.TabIndex = 6;
			label7.Text = "- Delete Products: Remove products that are no longer available or needed.\r\n";
			// 
			// label8
			// 
			label8.AutoSize = true;

			label8.Font = new Font("SansSerif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
			label8.ForeColor = Color.White;
			label8.Location = new Point(114, 395);
			label8.Name = "label8";
			label8.Size = new Size(308, 31);
			label8.TabIndex = 7;
			label8.Text = "2 - Order Management:";
			// 
			// label9
			// 
			label9.Font = new Font("SansSerif", 16.1999989F);
			label9.ForeColor = Color.White;
			label9.Location = new Point(164, 443);
			label9.Name = "label9";
			label9.Size = new Size(1173, 45);
			label9.TabIndex = 8;
			label9.Text = "- Create Orders: Allow customers or staff to create new orders by selecting products, specifying quantities, and providing customer information.\r\n\r\n";
			// 
			// label10
			// 

			label10.Font = new Font("SansSerif", 16.1999989F);
			label10.ForeColor = Color.White;
			label10.Location = new Point(164, 487);
			label10.Name = "label10";
			label10.Size = new Size(1173, 45);
			label10.TabIndex = 9;
			label10.Text = "- Delete Orders: Cancel or remove orders that are no longer required.\r\n";
			// 
			// button1
			// 

			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button1.BackColor = Color.DodgerBlue;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			button1.ForeColor = Color.White;
			button1.Location = new Point(828, 889);
			button1.Name = "button1";
			button1.Size = new Size(135, 56);
			button1.TabIndex = 10;
			button1.Text = "Products";
			button1.UseVisualStyleBackColor = false;

			button1.Click += button1_Click_2;
			// 
			// button2
			// 

			button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button2.BackColor = Color.DodgerBlue;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			button2.ForeColor = Color.White;
			button2.Location = new Point(1021, 889);
			button2.Name = "button2";
			button2.Size = new Size(136, 56);
			button2.TabIndex = 11;
			button2.Text = "Orders";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click_1;
			// 
			// button3
			// 
			button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			button3.BackColor = Color.DodgerBlue;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			button3.ForeColor = Color.White;
			button3.Location = new Point(1220, 889);
			button3.Name = "button3";
			button3.Size = new Size(136, 56);
			button3.TabIndex = 12;
			button3.Text = "Back";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click_1;
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			pictureBox1.BackColor = Color.White;
			pictureBox1.BackgroundImageLayout = ImageLayout.None;
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Image = Properties.Resources.computer_inventory;
			pictureBox1.Location = new Point(204, 626);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(412, 319);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 13;
			pictureBox1.TabStop = false;

			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;

			BackColor = Color.FromArgb(174, 217, 255);
			ClientSize = new Size(1521, 978);
			Controls.Add(pictureBox1);

			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);

			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Form1";
			WindowState = FormWindowState.Maximized;
			Load += Form2_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Button button1;
		private Button button2;
		private Button button3;

		private PictureBox pictureBox1;

	}
}