namespace Presantation
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

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

		private void button4_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{
				
				folderDialog.Description = "Select a folder to save files:";

				
				folderDialog.RootFolder = Environment.SpecialFolder.Desktop;

				
				if (folderDialog.ShowDialog() == DialogResult.OK)
				{
					
					string selectedPath = folderDialog.SelectedPath;

					
					MessageBox.Show("Selected Folder: " + selectedPath);
				}
			}
		}
	}
}
