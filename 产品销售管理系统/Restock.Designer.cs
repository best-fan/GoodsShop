namespace 产品销售管理系统
{
    partial class Restock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNametet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GoodsNamCbo = new System.Windows.Forms.ComboBox();
            this.GoodsNumtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddNumbtxt = new System.Windows.Forms.TextBox();
            this.AddNumLable = new System.Windows.Forms.Label();
            this.AddButt = new System.Windows.Forms.Button();
            this.GoodsPlace = new System.Windows.Forms.TextBox();
            this.GoodsType = new System.Windows.Forms.TextBox();
            this.PurchaseDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BuyPrice = new System.Windows.Forms.TextBox();
            this.GoodsId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsInforBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restockDataSet = new 产品销售管理系统.restockDataSet();
            this.goodsInforTableAdapter = new 产品销售管理系统.restockDataSetTableAdapters.GoodsInforTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsInforBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNametet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.GoodsNamCbo);
            this.groupBox1.Controls.Add(this.GoodsNumtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddNumbtxt);
            this.groupBox1.Controls.Add(this.AddNumLable);
            this.groupBox1.Controls.Add(this.AddButt);
            this.groupBox1.Controls.Add(this.GoodsPlace);
            this.groupBox1.Controls.Add(this.GoodsType);
            this.groupBox1.Controls.Add(this.PurchaseDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BuyPrice);
            this.groupBox1.Controls.Add(this.GoodsId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(42, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 343);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单商品录入";
            // 
            // AddNametet
            // 
            this.AddNametet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNametet.BackColor = System.Drawing.SystemColors.Info;
            this.AddNametet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNametet.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.AddNametet.Location = new System.Drawing.Point(87, 198);
            this.AddNametet.Name = "AddNametet";
            this.AddNametet.Size = new System.Drawing.Size(127, 30);
            this.AddNametet.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "操 作 员：";
            // 
            // GoodsNamCbo
            // 
            this.GoodsNamCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoodsNamCbo.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoodsNamCbo.FormattingEnabled = true;
            this.GoodsNamCbo.Location = new System.Drawing.Point(353, 41);
            this.GoodsNamCbo.Name = "GoodsNamCbo";
            this.GoodsNamCbo.Size = new System.Drawing.Size(121, 27);
            this.GoodsNamCbo.TabIndex = 60;
            this.GoodsNamCbo.SelectionChangeCommitted += new System.EventHandler(this.GoodsNamCbo_SelectionChangeCommitted);
            // 
            // GoodsNumtxt
            // 
            this.GoodsNumtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoodsNumtxt.BackColor = System.Drawing.SystemColors.Info;
            this.GoodsNumtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoodsNumtxt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.GoodsNumtxt.Location = new System.Drawing.Point(353, 138);
            this.GoodsNumtxt.Name = "GoodsNumtxt";
            this.GoodsNumtxt.ReadOnly = true;
            this.GoodsNumtxt.Size = new System.Drawing.Size(121, 30);
            this.GoodsNumtxt.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(271, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "库存量：";
            // 
            // AddNumbtxt
            // 
            this.AddNumbtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNumbtxt.BackColor = System.Drawing.SystemColors.Info;
            this.AddNumbtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNumbtxt.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.AddNumbtxt.Location = new System.Drawing.Point(353, 191);
            this.AddNumbtxt.MaxLength = 3;
            this.AddNumbtxt.Name = "AddNumbtxt";
            this.AddNumbtxt.Size = new System.Drawing.Size(121, 30);
            this.AddNumbtxt.TabIndex = 57;
            this.AddNumbtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddNumbtxt_KeyPress);
            // 
            // AddNumLable
            // 
            this.AddNumLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNumLable.AutoSize = true;
            this.AddNumLable.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold);
            this.AddNumLable.Location = new System.Drawing.Point(254, 196);
            this.AddNumLable.Name = "AddNumLable";
            this.AddNumLable.Size = new System.Drawing.Size(93, 18);
            this.AddNumLable.TabIndex = 56;
            this.AddNumLable.Text = "添加数量：";
            // 
            // AddButt
            // 
            this.AddButt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButt.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddButt.Location = new System.Drawing.Point(318, 250);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(156, 46);
            this.AddButt.TabIndex = 53;
            this.AddButt.Text = "添加";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // GoodsPlace
            // 
            this.GoodsPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoodsPlace.BackColor = System.Drawing.SystemColors.Info;
            this.GoodsPlace.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.GoodsPlace.Location = new System.Drawing.Point(353, 82);
            this.GoodsPlace.Name = "GoodsPlace";
            this.GoodsPlace.ReadOnly = true;
            this.GoodsPlace.Size = new System.Drawing.Size(121, 30);
            this.GoodsPlace.TabIndex = 52;
            // 
            // GoodsType
            // 
            this.GoodsType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoodsType.BackColor = System.Drawing.SystemColors.Info;
            this.GoodsType.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.GoodsType.Location = new System.Drawing.Point(87, 81);
            this.GoodsType.Name = "GoodsType";
            this.GoodsType.ReadOnly = true;
            this.GoodsType.Size = new System.Drawing.Size(127, 30);
            this.GoodsType.TabIndex = 51;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.AcceptsReturn = true;
            this.PurchaseDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PurchaseDate.BackColor = System.Drawing.SystemColors.Info;
            this.PurchaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchaseDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PurchaseDate.Location = new System.Drawing.Point(87, 250);
            this.PurchaseDate.Multiline = true;
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Size = new System.Drawing.Size(127, 28);
            this.PurchaseDate.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 49;
            this.label8.Text = "录入日期:";
            // 
            // BuyPrice
            // 
            this.BuyPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuyPrice.BackColor = System.Drawing.SystemColors.Info;
            this.BuyPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuyPrice.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BuyPrice.Location = new System.Drawing.Point(87, 138);
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.ReadOnly = true;
            this.BuyPrice.Size = new System.Drawing.Size(127, 30);
            this.BuyPrice.TabIndex = 48;
            // 
            // GoodsId
            // 
            this.GoodsId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoodsId.BackColor = System.Drawing.SystemColors.Info;
            this.GoodsId.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.GoodsId.Location = new System.Drawing.Point(87, 35);
            this.GoodsId.Name = "GoodsId";
            this.GoodsId.ReadOnly = true;
            this.GoodsId.Size = new System.Drawing.Size(127, 30);
            this.GoodsId.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(271, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "货源地：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "进价￥：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "商品类型：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(254, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "商品名称：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("方正兰亭超细黑简体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "商品编号：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(563, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(42, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 223);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "多商品录入";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(10, 45);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(554, 149);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GoodsId";
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GoodsName";
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BuyPrice";
            this.Column3.HeaderText = "进价";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GoodsNumber";
            this.Column4.HeaderText = "库存量";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AddNumber";
            this.Column5.HeaderText = "添加数量";
            this.Column5.MaxInputLength = 4;
            this.Column5.Name = "Column5";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(654, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "批量添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(654, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Restock";
            this.Text = "进货录入";
            this.Load += new System.EventHandler(this.Restock1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsInforBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restockDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AddNametet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox GoodsNamCbo;
        private System.Windows.Forms.TextBox GoodsNumtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddNumbtxt;
        private System.Windows.Forms.Label AddNumLable;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.TextBox GoodsPlace;
        private System.Windows.Forms.TextBox GoodsType;
        private System.Windows.Forms.TextBox PurchaseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BuyPrice;
        private System.Windows.Forms.TextBox GoodsId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private restockDataSet restockDataSet;
        private System.Windows.Forms.BindingSource goodsInforBindingSource;
        private restockDataSetTableAdapters.GoodsInforTableAdapter goodsInforTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}