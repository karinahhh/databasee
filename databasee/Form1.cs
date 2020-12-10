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
		SqlDataAdapter adapter, adapter2;
		int Id = 0;
		SaveFileDialog save;
		public Form1()
		{
			InitializeComponent();
			
		}
		private void DisplayData()
		{
			connect.Open();
			DataTable tabel = new DataTable();
			adapter = new SqlDataAdapter("SELECT * FROM Tooded", connect);
			adapter.Fill(tabel);
			dataGridView1.DataSource = tabel;
			pictureBox1.Image = Image.FromFile("../../Images/list.png");

			adapter2 = new SqlDataAdapter("SELECT Kategooria_Nimetus FROM Kategooria", connect);
			DataTable kat_table = new DataTable();
			adapter2.Fill(kat_table);
			foreach (DataRow row in kat_table.Rows)
			{
				comboBox1.Items.Add(row["Kategooria_Nimetus"]);
			}


			connect.Close();

		}

		private void ClearData()
		{
			Id = 0;
			ToodeTxt.Text = "";
			KogusTxt.Text = "";
			HindTxt.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'productsDataSet.Tooded' table. You can move, or remove it, as needed.
			this.toodedTableAdapter.Fill(this.productsDataSet.Tooded);

		}
		
		private void btn_insert_Click(object sender, EventArgs e)
		{
			if (ToodeTxt.Text!="" && KogusTxt.Text!="" &&HindTxt.Text!="" && comboBox1.SelectedItem != null)
			{
				command = new SqlCommand("INSERT into Tooded(Toodenimetus,Kogus,Hind, Pilt, Kategooria_Id) values (@toode,@kogus,@hind,@pilt,@kat)", connect);
				connect.Open();
				command.Parameters.AddWithValue("@toode", ToodeTxt.Text);
				command.Parameters.AddWithValue("@kogus", KogusTxt.Text);
				command.Parameters.AddWithValue("@hind", HindTxt.Text);
				string file_pilt = ToodeTxt.Text + ".jpg";
				command.Parameters.AddWithValue("@pilt", file_pilt);
				command.Parameters.AddWithValue("@kat", (comboBox1.SelectedIndex + 1));
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
			string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			comboBox1.SelectedIndex = Int32.Parse(v);
		}

		private void btn_lisa_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
			open.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\source\repos\karinahhh\databasee\databasee\images\");

			if (open.ShowDialog() == DialogResult.OK)
			{
				save = new SaveFileDialog();
				save.FileName = ToodeTxt.Text +"_"+ Id;
				save.Filter = "Image Files (*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
				save.InitialDirectory = Path.GetFullPath(@"C:\Users\opilane\source\repos\karinahhh\databasee\databasee\images\");

				if (save.ShowDialog()==DialogResult.OK)
				{
					File.Copy(open.FileName, save.FileName);
					save.RestoreDirectory = true;
					pictureBox1.Image = Image.FromFile(save.FileName);
				}
				save.ShowDialog();
			}
		}
	}
}
