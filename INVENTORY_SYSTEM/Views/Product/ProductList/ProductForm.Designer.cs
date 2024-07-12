namespace INVENTORY_SYSTEM.Views.Product.ProductList
{
    partial class ProductForm
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRefrigirated = new System.Windows.Forms.CheckBox();
            this.txtPackedDepth = new System.Windows.Forms.TextBox();
            this.txtPackedWidth = new System.Windows.Forms.TextBox();
            this.txtPackedWeight = new System.Windows.Forms.TextBox();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.txtProductDec = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 211);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1583, 457);
            this.dgvProducts.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbRefrigirated);
            this.groupBox1.Controls.Add(this.txtPackedDepth);
            this.groupBox1.Controls.Add(this.txtPackedWidth);
            this.groupBox1.Controls.Add(this.txtPackedWeight);
            this.groupBox1.Controls.Add(this.txtProductCategory);
            this.groupBox1.Controls.Add(this.txtProductDec);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Packed Depth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Packed Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Packed Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bar Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Code";
            // 
            // cbRefrigirated
            // 
            this.cbRefrigirated.AutoSize = true;
            this.cbRefrigirated.Location = new System.Drawing.Point(861, 35);
            this.cbRefrigirated.Name = "cbRefrigirated";
            this.cbRefrigirated.Size = new System.Drawing.Size(104, 20);
            this.cbRefrigirated.TabIndex = 9;
            this.cbRefrigirated.Text = "Refrigerated";
            this.cbRefrigirated.UseVisualStyleBackColor = true;
            // 
            // txtPackedDepth
            // 
            this.txtPackedDepth.Location = new System.Drawing.Point(634, 116);
            this.txtPackedDepth.Name = "txtPackedDepth";
            this.txtPackedDepth.Size = new System.Drawing.Size(191, 22);
            this.txtPackedDepth.TabIndex = 8;
            // 
            // txtPackedWidth
            // 
            this.txtPackedWidth.Location = new System.Drawing.Point(634, 88);
            this.txtPackedWidth.Name = "txtPackedWidth";
            this.txtPackedWidth.Size = new System.Drawing.Size(191, 22);
            this.txtPackedWidth.TabIndex = 7;
            // 
            // txtPackedWeight
            // 
            this.txtPackedWeight.Location = new System.Drawing.Point(634, 60);
            this.txtPackedWeight.Name = "txtPackedWeight";
            this.txtPackedWeight.Size = new System.Drawing.Size(191, 22);
            this.txtPackedWeight.TabIndex = 6;
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Location = new System.Drawing.Point(136, 116);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(234, 22);
            this.txtProductCategory.TabIndex = 4;
            // 
            // txtProductDec
            // 
            this.txtProductDec.Location = new System.Drawing.Point(136, 88);
            this.txtProductDec.Name = "txtProductDec";
            this.txtProductDec.Size = new System.Drawing.Size(234, 22);
            this.txtProductDec.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(136, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(234, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(502, 32);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(323, 22);
            this.txtBarcode.TabIndex = 5;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(136, 32);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(184, 22);
            this.txtProductCode.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuUpdate,
            this.menuSave,
            this.menuCancel,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1607, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(55, 24);
            this.menuAdd.Text = "ADD";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(77, 24);
            this.menuUpdate.Text = "UPDATE";
            this.menuUpdate.Click += new System.EventHandler(this.menuUpdate_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(57, 24);
            this.menuSave.Text = "SAVE";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuCancel
            // 
            this.menuCancel.Name = "menuCancel";
            this.menuCancel.Size = new System.Drawing.Size(77, 24);
            this.menuCancel.Text = "CANCEL";
            this.menuCancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(52, 24);
            this.menuExit.Text = "EXIT";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.CheckBox cbRefrigirated;
        private System.Windows.Forms.TextBox txtPackedWidth;
        private System.Windows.Forms.TextBox txtPackedWeight;
        private System.Windows.Forms.TextBox txtProductCategory;
        private System.Windows.Forms.TextBox txtProductDec;
        private System.Windows.Forms.TextBox txtPackedDepth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuCancel;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
    }
}