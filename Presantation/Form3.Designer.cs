namespace Presantation
{
	partial class Form3
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
			dataGridView1 = new DataGridView();
			groupBox1 = new GroupBox();
			textBox1 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			groupBox3 = new GroupBox();
			textBox9 = new TextBox();
			label11 = new Label();
			button3 = new Button();
			button5 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox1.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(27, 412);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1376, 364);
			dataGridView1.TabIndex = 1;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top;
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(button1);
			groupBox1.Font = new Font("SansSerif", 17.9999981F, FontStyle.Bold);
			groupBox1.ForeColor = Color.White;
			groupBox1.Location = new Point(89, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(433, 304);
			groupBox1.TabIndex = 2;
			groupBox1.TabStop = false;
			groupBox1.Text = "Create Order";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			textBox1.Location = new Point(254, 70);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(158, 31);
			textBox1.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("SansSerif", 12F, FontStyle.Bold);
			label1.Location = new Point(25, 75);
			label1.Name = "label1";
			label1.Size = new Size(202, 23);
			label1.TabIndex = 1;
			label1.Text = "Number of Products";
			label1.Click += label1_Click;
			// 
			// button1
			// 
			button1.AutoSize = true;
			button1.BackColor = Color.DodgerBlue;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
			button1.ForeColor = Color.White;
			button1.Location = new Point(281, 215);
			button1.Name = "button1";
			button1.Size = new Size(131, 51);
			button1.TabIndex = 3;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top;
			groupBox3.Controls.Add(textBox9);
			groupBox3.Controls.Add(label11);
			groupBox3.Controls.Add(button3);
			groupBox3.Font = new Font("SansSerif", 17.9999981F, FontStyle.Bold);
			groupBox3.ForeColor = Color.White;
			groupBox3.Location = new Point(629, 12);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(368, 304);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "Delete Product";
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
			label11.Size = new Size(89, 23);
			label11.TabIndex = 8;
			label11.Text = "Order Id";
			// 
			// button3
			// 
			button3.AutoSize = true;
			button3.BackColor = Color.DodgerBlue;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
			button3.ForeColor = Color.White;
			button3.Location = new Point(216, 215);
			button3.Name = "button3";
			button3.Size = new Size(131, 51);
			button3.TabIndex = 0;
			button3.Text = "Delete";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// button5
			// 
			button5.Anchor = AnchorStyles.Top;
			button5.AutoSize = true;
			button5.BackColor = Color.DodgerBlue;
			button5.FlatStyle = FlatStyle.Flat;
			button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
			button5.ForeColor = Color.White;
			button5.Location = new Point(1207, 227);
			button5.Name = "button5";
			button5.Size = new Size(152, 51);
			button5.TabIndex = 9;
			button5.Text = "Back";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(173, 219, 255);
			ClientSize = new Size(1415, 824);
			Controls.Add(button5);
			Controls.Add(groupBox3);
			Controls.Add(groupBox1);
			Controls.Add(dataGridView1);
			Name = "Form3";
			Text = "Form3";
			WindowState = FormWindowState.Maximized;
			Load += Form3_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private GroupBox groupBox1;
		private TextBox textBox1;
		private Label label1;
		private Button button1;
		private GroupBox groupBox3;
		private TextBox textBox9;
		private Label label11;
		private Button button3;
		private Button button5;
	}
}