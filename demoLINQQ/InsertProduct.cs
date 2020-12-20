using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoLINQQ
{
    public partial class InsertProduct : Form
    {
        public InsertProduct()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (BikeStoresDataContext _db = new BikeStoresDataContext())
            {
                string productName = txbProductName.Text;
                int brandId = int.Parse(txbBrandId.Text);
                int categoryId = int.Parse(TxbCategoryId.Text);
                short modelYear = short.Parse(txbModelYear.Text);
                decimal listPrice = decimal.Parse(txbModelPrice.Text);

                product insert = new product();
                insert.product_name = productName;
                insert.brand_id = brandId;
                insert.category_id = categoryId;
                insert.model_year = modelYear;
                insert.list_price = listPrice;

                _db.products.InsertOnSubmit(insert);
                _db.SubmitChanges();
            }
            this.Close();
        }
    }
}
