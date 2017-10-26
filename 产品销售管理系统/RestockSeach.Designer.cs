namespace 产品销售管理系统
{
    partial class RestockSeach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockInforBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restockDataSet = new 产品销售管理系统.restockDataSet();
            this.restockInforTableAdapter = new 产品销售管理系统.restockDataSetTableAdapters.RestockInforTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockInforBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIdDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.purchaseNumberDataGridViewTextBoxColumn,
            this.writeNameDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.restockInforBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(573, 156);
            this.dataGridView1.TabIndex = 0;
            // 
            // goodsIdDataGridViewTextBoxColumn
            // 
            this.goodsIdDataGridViewTextBoxColumn.DataPropertyName = "GoodsId";
            this.goodsIdDataGridViewTextBoxColumn.HeaderText = "商品编号";
            this.goodsIdDataGridViewTextBoxColumn.Name = "goodsIdDataGridViewTextBoxColumn";
            this.goodsIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseNumberDataGridViewTextBoxColumn
            // 
            this.purchaseNumberDataGridViewTextBoxColumn.DataPropertyName = "PurchaseNumber";
            this.purchaseNumberDataGridViewTextBoxColumn.HeaderText = "进货数量";
            this.purchaseNumberDataGridViewTextBoxColumn.Name = "purchaseNumberDataGridViewTextBoxColumn";
            this.purchaseNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // writeNameDataGridViewTextBoxColumn
            // 
            this.writeNameDataGridViewTextBoxColumn.DataPropertyName = "WriteName";
            this.writeNameDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.writeNameDataGridViewTextBoxColumn.Name = "writeNameDataGridViewTextBoxColumn";
            this.writeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "录入日期";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restockInforBindingSource
            // 
            this.restockInforBindingSource.DataMember = "RestockInfor";
            this.restockInforBindingSource.DataSource = this.restockDataSet;
            // 
            // restockDataSet
            // 
            this.restockDataSet.DataSetName = "RestockDataSet";
            this.restockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restockInforTableAdapter
            // 
            this.restockInforTableAdapter.ClearBeforeFill = true;
            // 
            // RestockSeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 225);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RestockSeach";
            this.Text = "进货查询";
            this.Load += new System.EventHandler(this.RestockSeach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockInforBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private restockDataSet restockDataSet;
        private System.Windows.Forms.BindingSource restockInforBindingSource;
        private restockDataSetTableAdapters.RestockInforTableAdapter restockInforTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
    }
}