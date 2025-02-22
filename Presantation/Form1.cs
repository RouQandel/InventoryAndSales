using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presantation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Product newForm = new Product();
			newForm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{


		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_2(object sender, EventArgs e)
		{
			Form2 Form2 = new Form2();
			Form2.Show();
			this.Hide();

		}

		private void button2_Click_1(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			StartForm start = new StartForm();
			start.Show();
			this.Close();
		}
	}
}
