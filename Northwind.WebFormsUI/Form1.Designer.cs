
namespace Northwind.WebFormsUI
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.grbBox1 = new System.Windows.Forms.GroupBox();
            this.grbBox2 = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbProductInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.grbBox1.SuspendLayout();
            this.grbBox2.SuspendLayout();
            this.grbProductInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(776, 280);
            this.dgwProducts.TabIndex = 0;
            // 
            // grbBox1
            // 
            this.grbBox1.Controls.Add(this.btnClearFilters);
            this.grbBox1.Controls.Add(this.cbxCategory);
            this.grbBox1.Controls.Add(this.lblCategory);
            this.grbBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBox1.Location = new System.Drawing.Point(13, 299);
            this.grbBox1.Name = "grbBox1";
            this.grbBox1.Size = new System.Drawing.Size(368, 100);
            this.grbBox1.TabIndex = 1;
            this.grbBox1.TabStop = false;
            this.grbBox1.Text = "Search By Categories";
            // 
            // grbBox2
            // 
            this.grbBox2.Controls.Add(this.txtProductName);
            this.grbBox2.Controls.Add(this.lblProductName);
            this.grbBox2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold);
            this.grbBox2.Location = new System.Drawing.Point(13, 405);
            this.grbBox2.Name = "grbBox2";
            this.grbBox2.Size = new System.Drawing.Size(368, 100);
            this.grbBox2.TabIndex = 2;
            this.grbBox2.TabStop = false;
            this.grbBox2.Text = "Search By Product Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(27, 47);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categories :";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(119, 43);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(201, 23);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(7, 41);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 15);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name :";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(119, 37);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(201, 22);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(395, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 52);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD\r\nProduct";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(532, 453);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 52);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE\r\nProduct";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(669, 452);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 52);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE\r\nProduct";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // grbProductInfo
            // 
            this.grbProductInfo.Controls.Add(this.txtCatName);
            this.grbProductInfo.Controls.Add(this.txtStock);
            this.grbProductInfo.Controls.Add(this.txtQuantity);
            this.grbProductInfo.Controls.Add(this.txtPrice);
            this.grbProductInfo.Controls.Add(this.txtPName);
            this.grbProductInfo.Controls.Add(this.label5);
            this.grbProductInfo.Controls.Add(this.label4);
            this.grbProductInfo.Controls.Add(this.label3);
            this.grbProductInfo.Controls.Add(this.label2);
            this.grbProductInfo.Controls.Add(this.label1);
            this.grbProductInfo.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbProductInfo.Location = new System.Drawing.Point(395, 299);
            this.grbProductInfo.Name = "grbProductInfo";
            this.grbProductInfo.Size = new System.Drawing.Size(393, 148);
            this.grbProductInfo.TabIndex = 6;
            this.grbProductInfo.TabStop = false;
            this.grbProductInfo.Text = "Product Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Box Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock Amount :";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(59, 25);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(128, 24);
            this.txtPName.TabIndex = 5;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(259, 25);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(128, 24);
            this.txtCatName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(16, 112);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(83, 24);
            this.txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(155, 112);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(83, 24);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(294, 112);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(83, 24);
            this.txtStock.TabIndex = 5;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.ForeColor = System.Drawing.Color.Red;
            this.btnClearFilters.Location = new System.Drawing.Point(119, 71);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(201, 23);
            this.btnClearFilters.TabIndex = 2;
            this.btnClearFilters.Text = "Clear Filter List All";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 540);
            this.Controls.Add(this.grbProductInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbBox2);
            this.Controls.Add(this.grbBox1);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.grbBox1.ResumeLayout(false);
            this.grbBox1.PerformLayout();
            this.grbBox2.ResumeLayout(false);
            this.grbBox2.PerformLayout();
            this.grbProductInfo.ResumeLayout(false);
            this.grbProductInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox grbBox1;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox grbBox2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbProductInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Button btnClearFilters;
    }
}

