
namespace demoLINQQ
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
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbbOrder = new System.Windows.Forms.ComboBox();
            this.cbbCategories = new System.Windows.Forms.ComboBox();
            this.cbbOrders = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(32, 30);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 62;
            this.dtgvData.RowTemplate.Height = 28;
            this.dtgvData.Size = new System.Drawing.Size(833, 451);
            this.dtgvData.TabIndex = 0;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(896, 30);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(96, 50);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Load data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(896, 93);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 50);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(896, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(896, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbFind
            // 
            this.txbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFind.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbFind.Location = new System.Drawing.Point(32, 511);
            this.txbFind.Name = "txbFind";
            this.txbFind.Size = new System.Drawing.Size(255, 26);
            this.txbFind.TabIndex = 2;
            this.txbFind.Text = "Enter key ...";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(309, 505);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(93, 47);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbbOrder
            // 
            this.cbbOrder.FormattingEnabled = true;
            this.cbbOrder.Items.AddRange(new object[] {
            "DESC",
            "ASC"});
            this.cbbOrder.Location = new System.Drawing.Point(428, 505);
            this.cbbOrder.Name = "cbbOrder";
            this.cbbOrder.Size = new System.Drawing.Size(121, 28);
            this.cbbOrder.TabIndex = 3;
            this.cbbOrder.Text = "Order by";
            // 
            // cbbCategories
            // 
            this.cbbCategories.FormattingEnabled = true;
            this.cbbCategories.Items.AddRange(new object[] {
            "Category 1",
            "Category 2"});
            this.cbbCategories.Location = new System.Drawing.Point(585, 505);
            this.cbbCategories.Name = "cbbCategories";
            this.cbbCategories.Size = new System.Drawing.Size(121, 28);
            this.cbbCategories.TabIndex = 3;
            this.cbbCategories.Text = "Categories";
            // 
            // cbbOrders
            // 
            this.cbbOrders.FormattingEnabled = true;
            this.cbbOrders.Items.AddRange(new object[] {
            "Best seller",
            "Hot sell"});
            this.cbbOrders.Location = new System.Drawing.Point(744, 505);
            this.cbbOrders.Name = "cbbOrders";
            this.cbbOrders.Size = new System.Drawing.Size(121, 28);
            this.cbbOrders.TabIndex = 3;
            this.cbbOrders.Text = "Hot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 564);
            this.Controls.Add(this.cbbOrders);
            this.Controls.Add(this.cbbCategories);
            this.Controls.Add(this.cbbOrder);
            this.Controls.Add(this.txbFind);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dtgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbbOrder;
        private System.Windows.Forms.ComboBox cbbCategories;
        private System.Windows.Forms.ComboBox cbbOrders;
    }
}

