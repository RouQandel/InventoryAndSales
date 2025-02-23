using AccessDataLayer.Repositories.Product;
using AccessDataLayer;
using BusinessLayer.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using AccessDataLayer.Repositories;
using AccessDataLayer.Entities;
using Microsoft.Extensions.Logging;
using OfficeOpenXml.FormulaParsing.Logging;

namespace Presantation
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{

		}

		private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form1 frm = new Form1();
			frm.Show();
			this.Close();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
		
			var dbContext = new AppDbContext();
			var orderRepository = new GenericRepo<Order>(dbContext);
			var orderManager = new OrderManager(orderRepository);

			string numofproduct = textBox1.Text.Trim();
			if (!int.TryParse(numofproduct, out int numofproduct1))
			{
				MessageBox.Show("Plese Enter a Valid number for number of product");
				return;
			}
			var orderDto = new CreateOrder()
			{
				TotalAmount = numofproduct1

			};
			await orderManager.AddOrderAsync(orderDto);
			MessageBox.Show("Product added successfully.");
			textBox1.Clear();
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}
