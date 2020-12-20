
namespace demoLINQQ
{
    partial class InsertProduct
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
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.TxbCategoryId = new System.Windows.Forms.TextBox();
            this.txbBrandId = new System.Windows.Forms.TextBox();
            this.txbModelPrice = new System.Windows.Forms.TextBox();
            this.txbModelYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbProductName
            // 
            this.txbProductName.Location = new System.Drawing.Point(233, 62);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(216, 26);
            this.txbProductName.TabIndex = 0;
            // 
            // TxbCategoryId
            // 
            this.TxbCategoryId.Location = new System.Drawing.Point(233, 182);
            this.TxbCategoryId.Name = "TxbCategoryId";
            this.TxbCategoryId.Size = new System.Drawing.Size(216, 26);
            this.TxbCategoryId.TabIndex = 0;
            // 
            // txbBrandId
            // 
            this.txbBrandId.Location = new System.Drawing.Point(233, 122);
            this.txbBrandId.Name = "txbBrandId";
            this.txbBrandId.Size = new System.Drawing.Size(216, 26);
            this.txbBrandId.TabIndex = 0;
            // 
            // txbModelPrice
            // 
            this.txbModelPrice.Location = new System.Drawing.Point(233, 300);
            this.txbModelPrice.Name = "txbModelPrice";
            this.txbModelPrice.Size = new System.Drawing.Size(216, 26);
            this.txbModelPrice.TabIndex = 0;
            // 
            // txbModelYear
            // 
            this.txbModelYear.Location = new System.Drawing.Point(233, 244);
            this.txbModelYear.Name = "txbModelYear";
            this.txbModelYear.Size = new System.Drawing.Size(216, 26);
            this.txbModelYear.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Brand ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Model Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "List Price";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(233, 349);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(216, 40);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // InsertProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbModelYear);
            this.Controls.Add(this.txbModelPrice);
            this.Controls.Add(this.txbBrandId);
            this.Controls.Add(this.TxbCategoryId);
            this.Controls.Add(this.txbProductName);
            this.Name = "InsertProduct";
            this.Text = "InsertProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.TextBox TxbCategoryId;
        private System.Windows.Forms.TextBox txbBrandId;
        private System.Windows.Forms.TextBox txbModelPrice;
        private System.Windows.Forms.TextBox txbModelYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
    }
}