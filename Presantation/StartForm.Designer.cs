﻿namespace Presantation
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

			label3 = new Label();
			label1 = new Label();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

			pictureBox1.Image = Properties.Resources.Untitled_Project;
			pictureBox1.Location = new Point(-8, -13);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(1409, 709);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 4;
			pictureBox1.TabStop = false;
			// 
			// label3
			// 
			label3.BackColor = Color.FromArgb(173, 219, 255);
			label3.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(33, 176);
			label3.Name = "label3";
			label3.Size = new Size(577, 133);
			label3.TabIndex = 5;
			label3.Text = "Welcome !";
			// 
			// label1
			// 
			label1.BackColor = Color.FromArgb(173, 219, 255);
			label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(62, 354);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(503, 69);
			label1.TabIndex = 6;
			label1.Text = "You are about to use the best inventory mangement application in the world 👌💰\r\n";
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			button2.BackColor = SystemColors.MenuHighlight;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.White;
			button2.Location = new Point(151, 505);
			button2.Name = "button2";
			button2.Size = new Size(185, 78);
			button2.TabIndex = 7;
			button2.Text = "Start";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// StartForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;

			ClientSize = new Size(1413, 684);
			Controls.Add(button2);
			Controls.Add(label1);
			Controls.Add(label3);
			Controls.Add(pictureBox1);
			Name = "StartForm";
			Text = "StartForm";
			WindowState = FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label3;
		private Label label1;
		private Button button2;

	}
}