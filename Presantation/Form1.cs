using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessDataLayer;
using BusinessLayer;
using BusinessLayer.Managers;
using Microsoft.EntityFrameworkCore;

namespace Presantation
{
	public partial class Form1 : Form
	{
		private readonly ProductManager _productManager;

		public Form1()
		{
			InitializeComponent();
			var productRepo = new AccessDataLayer.Repositories.Product.ProductRepository(new AccessDataLayer.AppDbContext());
			_productManager = new ProductManager(productRepo);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Product newForm = new Product();
			//newForm.Show();
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

		private async void button1_Click_2(object sender, EventArgs e)
		{
			//Form2 Form2 = new Form2();
		//	Form2.Show();
			this.Hide();


			using (var db = new AppDbContext())
			{
				var products = await db.Products
									   .Include(p => p.Supplier)
									   .ToListAsync();

				var productDtos = products.Select(p => new GetAllProductsDto
				{
					Id = p.ProductId,
					ProductName = p.ProductName,
					UnitPrice = p.UnitPrice,
					QuantityInStock = p.QuantityInStock,
					Category = p.Category.ToString(),
					SupplierName = p.Supplier != null ? p.Supplier.SupName : "Unknown"
				}).ToList();




				Form2 productsForm = new Form2(productDtos);
				productsForm.ShowDialog();

			}
		}
	}
}