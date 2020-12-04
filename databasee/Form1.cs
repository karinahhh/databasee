using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databasee
{
	public partial class Form1 : Form
	{
		SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\karinahhh\databasee\databasee\AppData\Products.mdf;Integrated Security=True");
		SqlCommand command;
		SqlDataAdapter adapter;
		int Id = 0;
		public Form1()
		{
			InitializeComponent();
			
		}
		private void DisplayData()
		{
			connect.Open();
			DataTable table = new DataTable();
			adapter = new SqlDataAdapter("SELECT * FROM Tooded", connect);
			adapter.Fill(table);
			dataGridView1.DataSource = table;
			connect.Close();

		}

		private void ClearData()
		{
			Id = 0;
			ToodeTxt.Text = "";
			KogusTxt.Text = "";
			HindTxt.Text = "";
		}

		/*private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'productsDataSet.Tooded' table. You can move, or remove it, as needed.
			this.toodedTableAdapter.Fill(this.productsDataSet.Tooded);

		}
		*/
		private void btn_insert_Click(object sender, EventArgs e)
		{
			if (ToodeTxt.Text!="" && KogusTxt.Text!="" &&HindTxt.Text!="")
			{
				command = new SqlCommand("insert into Tooded(Toodenimetus,Kogus,Hind) values (@toode,@kogus,@hind,@pilt)", connect);
				connect.Open();
				command.Parameters.AddWithValue("@toode", ToodeTxt.Text);
				command.Parameters.AddWithValue("@kogus", KogusTxt.Text);
				command.Parameters.AddWithValue("@hind", HindTxt.Text);
				command.Parameters.AddWithValue("@pilt", save.FileName+save.Filter);
				command.ExecuteNonQuery();
				connect.Close();
				DisplayData();
				ClearData();
				MessageBox.Show("Andmes on lisatud");
			}
			else
			{
				MessageBox.Show("viga");
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if (Id!=0)
			{
				command = new SqlCommand("DELETE Tooded WHERE Id=@id", connect);
				connect.Open();
				command.Parameters.AddWithValue("@id", Id);
				command.ExecuteNonQuery();
				connect.Close();
				DisplayData();
				ClearData();
				MessageBox.Show("Andmed on kustutatud");
			}
			else
			{
				MessageBox.Show("viga");
			}
		}
		SaveFileDialog save;

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (ToodeTxt.Text != "" && KogusTxt.Text != "" && HindTxt.Text != "")
			{
				command = new SqlCommand("UPDATE Tooded SET Toodenimetus= @toode,Kogus=@kogus,Hind=@hind, Pilt=@pilt WHERE Id=@id", connect);
				connect.Open();
				command.Parameters.AddWithValue("@id", Id);
				command.Parameters.AddWithValue("@toode", ToodeTxt.Text);
				command.Parameters.AddWithValue("@kogus", KogusTxt.Text);
				command.Parameters.AddWithValue("@hind", HindTxt.Text);
				command.Parameters.AddWithValue("@pilt", save.FileName + save.Filter);
				command.ExecuteNonQuery();
				connect.Close();
				DisplayData();
				ClearData();
				MessageBox.Show("Uuendatud");
			}
			else
			{
				MessageBox.Show("viga");
			}
		}
		
		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
		{
			Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			ToodeTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			KogusTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			HindTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			pictureBox1.Image = Image.FromFile(@"C:\Users\opilane\source\repos\karinahhh\databasee\databasee\images" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
			
		}

		private void btn_lisa_Click(object sender, EventArgs e)
		{
			if (Id != 0)
			{
				OpenFileDialog open = new OpenFileDialog();
				open.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
				if (open.ShowDialog() == DialogResult.OK)
				{
					SaveFileDialog save = new SaveFileDialog();
					save.FileName = ToodeTxt.Text +"_"+ Id;
					save.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
					save.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\source\repos\karinahhh\databasee\databasee\images\");
					save.ShowDialog();
				}
			}
			else
			{
				MessageBox.Show("Viga");
			}
		}
	}
}
