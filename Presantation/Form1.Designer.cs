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
			label1 = new Label();
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
			SuspendLayout();
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(77, 79);
			label1.Name = "label1";
			label1.Size = new Size(1272, 93);
			label1.TabIndex = 0;
			label1.Text = "This application is designed to efficiently manage product data and orders. It is ideal for businesses looking to keep track of their inventory and streamline their order processing.";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(77, 157);
			label2.Name = "label2";
			label2.Size = new Size(253, 41);
			label2.TabIndex = 1;
			label2.Text = " Key Features:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(114, 198);
			label3.Name = "label3";
			label3.Size = new Size(216, 23);
			label3.TabIndex = 2;
			label3.Text = "1 - Product Management:";
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label4.Location = new Point(164, 245);
			label4.Name = "label4";
			label4.Size = new Size(1173, 45);
			label4.TabIndex = 3;
			label4.Text = "- Display All Products: View a comprehensive list of all available products with detailed information such as name, category, price, and stock quantity.";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(164, 290);
			label5.Name = "label5";
			label5.Size = new Size(1173, 45);
			label5.TabIndex = 4;
			label5.Text = "- Add New Products: Easily add new products to the inventory by entering relevant details like product name, description, price, and stock level.\r\n";
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(164, 335);
			label6.Name = "label6";
			label6.Size = new Size(1173, 45);
			label6.TabIndex = 5;
			label6.Text = "- Update Products: Edit product details to keep the inventory accurate and up-to-date.\r\n";
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.Location = new Point(164, 380);
			label7.Name = "label7";
			label7.Size = new Size(1173, 45);
			label7.TabIndex = 6;
			label7.Text = "- Delete Products: Remove products that are no longer available or needed.\r\n";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(114, 425);
			label8.Name = "label8";
			label8.Size = new Size(200, 23);
			label8.TabIndex = 7;
			label8.Text = "1 - Order Management:";
			// 
			// label9
			// 
			label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.Location = new Point(164, 472);
			label9.Name = "label9";
			label9.Size = new Size(1173, 45);
			label9.TabIndex = 8;
			label9.Text = "- Create Orders: Allow customers or staff to create new orders by selecting products, specifying quantities, and providing customer information.\r\n\r\n";
			// 
			// label10
			// 
			label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label10.Location = new Point(164, 517);
			label10.Name = "label10";
			label10.Size = new Size(1173, 45);
			label10.TabIndex = 9;
			label10.Text = "- Delete Orders: Cancel or remove orders that are no longer required.\r\n";
			// 
			// button1
			// 
			button1.Location = new Point(989, 694);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 10;
			button1.Text = "Products";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_2;
			// 
			// button2
			// 
			button2.Location = new Point(1127, 694);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 11;
			button2.Text = "Orders";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(1273, 694);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 12;
			button3.Text = "Back";
			button3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1514, 752);
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
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Form1";
			Load += Form2_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
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
	}
}