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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (BikeStoresDataContext _db = new BikeStoresDataContext())
            {
                dtgvData.DataSource = _db.products.Select(p => p);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (BikeStoresDataContext _db = new BikeStoresDataContext())
            {
                var formInsert = new InsertProduct();
                formInsert.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (BikeStoresDataContext _db = new BikeStoresDataContext())
            {
                int id = int.Parse(dtgvData.SelectedCells[0].OwningRow.Cells["product_id"].Value.ToString());
                string productName = dtgvData.SelectedCells[0].OwningRow.Cells["product_name"].Value.ToString();
                int brandId = int.Parse(dtgvData.SelectedCells[0].OwningRow.Cells["brand_id"].Value.ToString());
                int categoryId = int.Parse(dtgvData.SelectedCells[0].OwningRow.Cells["category_id"].Value.ToString());
                short modelYear = short.Parse(dtgvData.SelectedCells[0].OwningRow.Cells["model_year"].Value.ToString());
                decimal listPrice = decimal.Parse(dtgvData.SelectedCells[0].OwningRow.Cells["list_price"].Value.ToString());

                product edit = _db.products.Where(p => p.product_id == id).SingleOrDefault();
                edit.product_id = id;
                edit.product_name = productName;
                edit.brand_id = brandId;
                edit.category_id = categoryId;
                edit.model_year = modelYear;
                edit.list_price = listPrice;
                _db.SubmitChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (BikeStoresDataContext _db = new BikeStoresDataContext())
            {
                int id = int.Parse(dtgvData.SelectedCells[0].OwningRow.Cells["product_id"].Value.ToString());
                product productToDelete = _db.products.Where(p => p.product_id == id).SingleOrDefault();
                _db.products.DeleteOnSubmit(productToDelete);
                _db.SubmitChanges();
            }
            btnLoadData_Click(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (BikeStoresDataContext _db = new BikeStoresDataContext())
            {
                dtgvData.DataSource = _db.products.Where(p => p.product_name.Contains(txbFind.Text));
            }
        }
    }
}
