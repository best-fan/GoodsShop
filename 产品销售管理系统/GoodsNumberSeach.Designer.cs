namespace 产品销售管理系统
{
    partial class GoodsNumberSeach
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
            this.goodsTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsInforBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restockDataSet = new 产品销售管理系统.restockDataSet();
            this.goodsInforTableAdapter = new 产品销售管理系统.restockDataSetTableAdapters.GoodsInforTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsInforBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIdDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsTypeDataGridViewTextBoxColumn,
            this.goodsPlaceDataGridViewTextBoxColumn,
            this.selingPriceDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn,
            this.goodsNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsInforBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(744, 233);
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
            // goodsTypeDataGridViewTextBoxColumn
            // 
            this.goodsTypeDataGridViewTextBoxColumn.DataPropertyName = "GoodsType";
            this.goodsTypeDataGridViewTextBoxColumn.HeaderText = "商品类型";
            this.goodsTypeDataGridViewTextBoxColumn.Name = "goodsTypeDataGridViewTextBoxColumn";
            this.goodsTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsPlaceDataGridViewTextBoxColumn
            // 
            this.goodsPlaceDataGridViewTextBoxColumn.DataPropertyName = "GoodsPlace";
            this.goodsPlaceDataGridViewTextBoxColumn.HeaderText = "商品来源";
            this.goodsPlaceDataGridViewTextBoxColumn.Name = "goodsPlaceDataGridViewTextBoxColumn";
            this.goodsPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selingPriceDataGridViewTextBoxColumn
            // 
            this.selingPriceDataGridViewTextBoxColumn.DataPropertyName = "SelingPrice";
            this.selingPriceDataGridViewTextBoxColumn.HeaderText = "售价";
            this.selingPriceDataGridViewTextBoxColumn.Name = "selingPriceDataGridViewTextBoxColumn";
            this.selingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "备注";
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            this.otherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsNumberDataGridViewTextBoxColumn
            // 
            this.goodsNumberDataGridViewTextBoxColumn.DataPropertyName = "GoodsNumber";
            this.goodsNumberDataGridViewTextBoxColumn.HeaderText = "库存量";
            this.goodsNumberDataGridViewTextBoxColumn.Name = "goodsNumberDataGridViewTextBoxColumn";
            this.goodsNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // goodsInforBindingSource
            // 
            this.goodsInforBindingSource.DataMember = "GoodsInfor";
            this.goodsInforBindingSource.DataSource = this.restockDataSet;
            // 
            // restockDataSet
            // 
            this.restockDataSet.DataSetName = "RestockDataSet";
            this.restockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsInforTableAdapter
            // 
            this.goodsInforTableAdapter.ClearBeforeFill = true;
            // 
            // GoodsNumberSeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 296);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GoodsNumberSeach";
            this.Text = "商品库存";
            this.Load += new System.EventHandler(this.GoodsNumberSeach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsInforBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private restockDataSet restockDataSet;
        private System.Windows.Forms.BindingSource goodsInforBindingSource;
        private restockDataSetTableAdapters.GoodsInforTableAdapter goodsInforTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNumberDataGridViewTextBoxColumn;
    }
}