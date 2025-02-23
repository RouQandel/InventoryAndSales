
using BusinessLayer.Managers;
using BusinessLayer;
using AccessDataLayer.Enums;
using AccessDataLayer.Repositories.Product;
using AccessDataLayer;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.Services.Excel_Handling;

namespace Presantation
{
	public partial class Form2 : Form
	{
		private readonly ProductManager _productManager;

		public Form2(IEnumerable<GetAllProductsDto> products)
		{
			InitializeComponent();
			LoadProducts(products);

			var productRepo = new AccessDataLayer.Repositories.Product.ProductRepository(new AccessDataLayer.AppDbContext());
			_productManager = new ProductManager(productRepo);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var categoryList = Enum.GetValues(typeof(CategoryEnum))
			 .Cast<CategoryEnum>()
			 .Select(c => new KeyValuePair<string, int>(c.ToString(), (int)c))
			 .ToList();
			// ??? ??? ComboBox ???? DataSource
			CategoryForm.DataSource = categoryList;
			CategoryForm.DisplayMember = "Key"; // ???? ??????? ???
			CategoryForm.ValueMember = "Value"; // ????? ???? ?????? ??? ??? ????????


			var categoryList2 = Enum.GetValues(typeof(CategoryEnum))
			  .Cast<CategoryEnum>()
			  .Select(c => new KeyValuePair<string, int>(c.ToString(), (int)c))
			  .ToList();

			CategoryForm2.DataSource = categoryList2;
			CategoryForm2.DisplayMember = "Key";
			CategoryForm2.ValueMember = "Value";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 newForm = new Form1();
			newForm.Show();

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


				textBox9.Text = row.Cells["Id"].Value.ToString();
				textBox5.Text = row.Cells["ProductName"].Value.ToString();
				textBox6.Text = row.Cells["UnitPrice"].Value.ToString();
				textBox7.Text = row.Cells["QuantityInStock"].Value.ToString();
				textBox8.Text = row.Cells["Id"].Value.ToString();
				string selectedCategoryText = row.Cells["Category"].Value.ToString();
				int index = CategoryForm2.FindStringExact(selectedCategoryText);
				if (index != -1)
				{
					CategoryForm2.SelectedIndex = index;
				}
				else
				{
					MessageBox.Show("Category not found in ComboBox");
				}

			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			form.Show();
			this.Close();
		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private async void button4_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{

				folderDialog.Description = "Select a folder to save files:";


				folderDialog.RootFolder = Environment.SpecialFolder.Desktop;


				if (folderDialog.ShowDialog() == DialogResult.OK)
				{

					string selectedPath = folderDialog.SelectedPath;
					MessageBox.Show("Selected Folder: " + selectedPath);

					//Get all 
					using (var db = new AppDbContext())
					{
						var products = await db.Products
											   //.Include(p => p.Supplier)
											   .ToListAsync();
					
						var productDtos = products.Select(p => new GetAllProductsDto
						{
							Id = p.ProductId,
							ProductName = p.ProductName,
							UnitPrice = p.UnitPrice,
							QuantityInStock = p.QuantityInStock,
							Category = p.Category.ToString(),
							//SupplierName = p.Supplier != null ? p.Supplier.SupName : "Unknown"
						}).ToList();

						ExcelService excelService = new ExcelService();
						var FilePath = Path.Combine(selectedPath, "Test.xlsx");
						excelService.ExportToExcel( productDtos, FilePath);



					}
						//start calling excel method
						


				}
				






			}
		}

		

		private void LoadProducts(IEnumerable<GetAllProductsDto> products)
		{
			dataGridView1.DataSource = products.ToList();
		}

		private async void button1_Click_1(object sender, EventArgs e)
		{
			var dbContext = new AppDbContext();
			var productRepository = new ProductRepository(dbContext);
			var productManager = new ProductManager(productRepository);
			string productName = (string)Name_of_Product.Text.Trim();
			string productprice = Price_0f_Produt.Text.Trim();
			string quantity = Quantity_in_Stock.Text.Trim();
			// string supId = supIdForm.Text.Trim();

			//validate input
			if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(productprice) || string.IsNullOrEmpty(quantity))
			{
				MessageBox.Show("This Fields Is Required");
				return;
			}

			//convert price text to long
			if (!decimal.TryParse(productprice, out decimal price))
			{
				MessageBox.Show("Plese Enter a Valid number for Price");
				return;
			}
			//convert quantity text to long
			if (!int.TryParse(quantity, out int quantityofproduct))
			{
				MessageBox.Show("Plese Enter a Valid number for Quantity");
				return;
			}

			//make sure user choose category
			if (CategoryForm.SelectedIndex == -1)
			{
				MessageBox.Show("choose one category");
				return;
			}

			//if (!string.TryParse(supId, out string suplierId))
			//{
			//    MessageBox.Show("Plese Enter a Valid number for supID");
			//    return;
			//}



			var productDto = new CreateProductDto()
			{


				ProductName = productName,
				UnitPrice = price,
				QuantityInStock = quantityofproduct,
				Category = (CategoryEnum)CategoryForm.SelectedValue// ????? ????? ??? CategoryEnum
																  
			};
			await productManager.AddProductAsync(productDto);
			MessageBox.Show("Product added successfully.");
			var products = await _productManager.GetAllAsync();
			LoadProducts(products);
			textBox9.Clear();



			ClearTextBoxes();
		}


		private async void button3_Click(object sender, EventArgs e)
		{
			if (long.TryParse(textBox9.Text, out long productId))
			{

				var isDeleted = await _productManager.DeleteProductAsync(productId);

				if (isDeleted)
				{
					MessageBox.Show("sucess");

					var products = await _productManager.GetAllAsync();
					LoadProducts(products);
					textBox9.Clear();
				}
				else
				{
					MessageBox.Show("error");
				}
			}
			else
			{
				MessageBox.Show("select item");
			}
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			var dbContext = new AppDbContext();
			var productRepository = new ProductRepository(dbContext);
			var productManager = new ProductManager(productRepository);
			string productName = (string)textBox5.Text.Trim();
			string productprice = textBox6.Text.Trim(); string quantity = textBox7.Text.Trim();
			string productId = (string)textBox8.Text.Trim();
			//string supId = textBox8.Text.Trim();
			//validate input
			if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(productprice))
			{
				MessageBox.Show("This Fields Is Required");
				return;
			}
			//convert price text to long
			if (!decimal.TryParse(productprice, out decimal price))
			{
				MessageBox.Show("Plese Enter a Valid number for Price"); return;
			} //convert quantity text to long
			if (!int.TryParse(quantity, out int quantityofproduct))
			{
				MessageBox.Show("Plese Enter a Valid number for Quantity"); return;
			}
			//make sure user choose category
			if (CategoryForm2.SelectedIndex == -1)
			{
				MessageBox.Show("choose one category");
				return;
			}
			if (!int.TryParse(productId, out int productId2))
			{
				MessageBox.Show("Plese Enter a Valid number for supID");
				return;
			}
			var productDto = new UpdateProductDto()
			{
				ProductName = productName,
				ProductId = productId2,
				UnitPrice = price,
				QuantityInStock = quantityofproduct,
				Category = (CategoryEnum)CategoryForm2.SelectedValue
				//SupName = supId
			};
			// await productManager.UpdateProductAsync(productDto);
			var isupdate = await productManager.UpdateProductAsync(productDto);
			if (isupdate)
			{
				MessageBox.Show("Product added successfully.");
				var products = await _productManager.GetAllAsync();
				LoadProducts(products);
				textBox5.Clear();
				textBox6.Clear();
				textBox7.Clear();
				textBox8.Clear();
				textBox9.Clear();
				CategoryForm2.SelectedIndex = -1;
				//textBox8.Clear();

			}
			else
			{
				MessageBox.Show("error");

			}
		}
		private void ClearTextBoxes()
		{
			Name_of_Product.Clear();
			Price_0f_Produt.Clear();
			Quantity_in_Stock.Clear();
			CategoryForm.SelectedIndex = -1;
			//supIdForm.Clear();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}
	}

}
