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
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toodenimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toodedBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productsDataSet = new databasee.ProductsDataSet();
			this.toodedTableAdapter = new databasee.ProductsDataSetTableAdapters.ToodedTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// ToodeTxt
			// 
			this.ToodeTxt.Location = new System.Drawing.Point(124, 59);
			this.ToodeTxt.Name = "ToodeTxt";
			this.ToodeTxt.Size = new System.Drawing.Size(138, 20);
			this.ToodeTxt.TabIndex = 0;
			// 
			// KogusTxt
			// 
			this.KogusTxt.Location = new System.Drawing.Point(124, 99);
			this.KogusTxt.Name = "KogusTxt";
			this.KogusTxt.Size = new System.Drawing.Size(138, 20);
			this.KogusTxt.TabIndex = 1;
			// 
			// HindTxt
			// 
			this.HindTxt.Location = new System.Drawing.Point(124, 145);
			this.HindTxt.Name = "HindTxt";
			this.HindTxt.Size = new System.Drawing.Size(138, 20);
			this.HindTxt.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label1.Location = new System.Drawing.Point(42, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Toode";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label2.Location = new System.Drawing.Point(42, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kogus";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label3.Location = new System.Drawing.Point(42, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Hind";
			// 
			// btn_insert
			// 
			this.btn_insert.Location = new System.Drawing.Point(12, 273);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(124, 78);
			this.btn_insert.TabIndex = 6;
			this.btn_insert.Text = "Lisa uus";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(166, 273);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(121, 78);
			this.btn_update.TabIndex = 7;
			this.btn_update.Text = "Uuenda";
			this.btn_update.UseVisualStyleBackColor = true;
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(327, 273);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(124, 78);
			this.btn_delete.TabIndex = 8;
			this.btn_delete.Text = "Kustuta";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.toodenimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.toodedBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(313, 38);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(444, 213);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowHeaderMousetClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// toodenimetusDataGridViewTextBoxColumn
			// 
			this.toodenimetusDataGridViewTextBoxColumn.DataPropertyName = "Toodenimetus";
			this.toodenimetusDataGridViewTextBoxColumn.HeaderText = "Toodenimetus";
			this.toodenimetusDataGridViewTextBoxColumn.Name = "toodenimetusDataGridViewTextBoxColumn";
			// 
			// kogusDataGridViewTextBoxColumn
			// 
			this.kogusDataGridViewTextBoxColumn.DataPropertyName = "Kogus";
			this.kogusDataGridViewTextBoxColumn.HeaderText = "Kogus";
			this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
			// 
			// hindDataGridViewTextBoxColumn
			// 
			this.hindDataGridViewTextBoxColumn.DataPropertyName = "Hind";
			this.hindDataGridViewTextBoxColumn.HeaderText = "Hind";
			this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn toodenimetusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
	}
}

