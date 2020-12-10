namespace databasee
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.ToodeTxt = new System.Windows.Forms.TextBox();
			this.KogusTxt = new System.Windows.Forms.TextBox();
			this.HindTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toodedBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productsDataSet = new databasee.ProductsDataSet();
			this.toodedTableAdapter = new databasee.ProductsDataSetTableAdapters.ToodedTableAdapter();
			this.btn_lisa = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ToodeTxt
			// 
			this.ToodeTxt.Location = new System.Drawing.Point(124, 30);
			this.ToodeTxt.Name = "ToodeTxt";
			this.ToodeTxt.Size = new System.Drawing.Size(138, 20);
			this.ToodeTxt.TabIndex = 0;
			// 
			// KogusTxt
			// 
			this.KogusTxt.Location = new System.Drawing.Point(124, 61);
			this.KogusTxt.Name = "KogusTxt";
			this.KogusTxt.Size = new System.Drawing.Size(138, 20);
			this.KogusTxt.TabIndex = 1;
			// 
			// HindTxt
			// 
			this.HindTxt.Location = new System.Drawing.Point(124, 101);
			this.HindTxt.Name = "HindTxt";
			this.HindTxt.Size = new System.Drawing.Size(138, 20);
			this.HindTxt.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label1.Location = new System.Drawing.Point(42, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Toode";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label2.Location = new System.Drawing.Point(42, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kogus";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label3.Location = new System.Drawing.Point(42, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Hind";
			// 
			// btn_insert
			// 
			this.btn_insert.Location = new System.Drawing.Point(12, 200);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(124, 78);
			this.btn_insert.TabIndex = 6;
			this.btn_insert.Text = "Lisa uus";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(12, 309);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(121, 78);
			this.btn_update.TabIndex = 7;
			this.btn_update.Text = "Uuenda";
			this.btn_update.UseVisualStyleBackColor = true;
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(156, 200);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(124, 78);
			this.btn_delete.TabIndex = 8;
			this.btn_delete.Text = "Kustuta";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(268, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(520, 150);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowHeaderMouseClick);
			// 
			// toodedBindingSource
			// 
			this.toodedBindingSource.DataMember = "Tooded";
			this.toodedBindingSource.DataSource = this.productsDataSet;
			// 
			// productsDataSet
			// 
			this.productsDataSet.DataSetName = "ProductsDataSet";
			this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// toodedTableAdapter
			// 
			this.toodedTableAdapter.ClearBeforeFill = true;
			// 
			// btn_lisa
			// 
			this.btn_lisa.Location = new System.Drawing.Point(156, 309);
			this.btn_lisa.Name = "btn_lisa";
			this.btn_lisa.Size = new System.Drawing.Size(124, 78);
			this.btn_lisa.TabIndex = 10;
			this.btn_lisa.Text = "Lisa pilt";
			this.btn_lisa.UseVisualStyleBackColor = true;
			this.btn_lisa.Click += new System.EventHandler(this.btn_lisa_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(305, 200);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(229, 187);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(124, 157);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(138, 21);
			this.comboBox1.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label4.Location = new System.Drawing.Point(25, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Kategooria";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_lisa);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.HindTxt);
			this.Controls.Add(this.KogusTxt);
			this.Controls.Add(this.ToodeTxt);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ToodeTxt;
		private System.Windows.Forms.TextBox KogusTxt;
		private System.Windows.Forms.TextBox HindTxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ProductsDataSet productsDataSet;
		private System.Windows.Forms.BindingSource toodedBindingSource;
		private ProductsDataSetTableAdapters.ToodedTableAdapter toodedTableAdapter;
		private System.Windows.Forms.Button btn_lisa;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
	}
}

