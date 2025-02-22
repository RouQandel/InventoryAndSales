namespace Presantation
{
	partial class StartForm
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
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox1.Image = Properties.Resources.Screenshot_2025_02_21_221634;
			pictureBox1.Location = new Point(-9, -1);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1439, 754);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// label1
			// 
			label1.BackColor = Color.FromArgb(174, 217, 249);
			label1.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(34, 218);
			label1.Name = "label1";
			label1.Size = new Size(589, 145);
			label1.TabIndex = 1;
			label1.Text = "Welcome !";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.BackColor = Color.FromArgb(174, 217, 249);
			label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(69, 432);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(503, 69);
			label2.TabIndex = 2;
			label2.Text = "You are about to use the best inventory mangement application in the world 👌💰\r\n";
			label2.Click += label2_Click;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			button1.BackColor = SystemColors.MenuHighlight;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(111, 581);
			button1.Name = "button1";
			button1.Size = new Size(185, 78);
			button1.TabIndex = 3;
			button1.Text = "Start";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// StartForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1430, 765);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "StartForm";
			Text = "StartForm";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private Button button1;
	}
}