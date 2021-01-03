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
                dtgvData.DataSource = _db.products;
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(cbbOrder.SelectedIndex > -1)
            {
                if(cbbOrder.Text.Equals("DESC"))
                {
                    using (BikeStoresDataContext _db = new BikeStoresDataContext())
                    {
                        var res = from p in _db.products
                                  orderby p.product_name descending
                                  select p;
                        dtgvData.DataSource = res;
                    }
                }
                if(cbbOrder.Text.Equals("ASC"))
                {
                    using (BikeStoresDataContext _db = new BikeStoresDataContext())
                    {
                        var res = from p in _db.products
                                  orderby p.product_name ascending
                                  select p;
                        dtgvData.DataSource = res;
                    }
                }
            }
            if(cbbCategories.SelectedIndex > -1)
            {
                string CategoryName = cbbCategories.Text;
                using (BikeStoresDataContext _db = new BikeStoresDataContext())
                {
                    var res = from p in _db.products
                              join ca in _db.categories on p.category_id equals ca.category_id
                              where ca.category_name.Equals(CategoryName)
                              select p;
                    dtgvData.DataSource = res;
                }
            }
            if(cbbOrders.SelectedIndex > -1)
            {
                if (cbbOrders.Text.Equals("Best seller"))
                {
                    using (BikeStoresDataContext _db = new BikeStoresDataContext())
                    {
                        //var productRes = _db.order_items
                        //.GroupBy(p => p.product_id)
                        //.Select(g => new
                        //{
                        //    Id = g.Key,
                        //    TotalQuantity = g.Sum(pv => pv.quantity),
                        //})
                        //.OrderByDescending(x => x.TotalQuantity).FirstOrDefault();

                        //dtgvData.DataSource = _db.products.Where(p => p.product_id == productRes.Id);

                        var productRes = _db.order_items
                        .GroupBy(p => p.product_id)
                        .Select(g => g)
                        .OrderByDescending(x => x.Count()).FirstOrDefault();
                    }
                }
                if(cbbOrders.Text.Equals("Hot sell"))
                {
                    using (BikeStoresDataContext _db = new BikeStoresDataContext())
                    {   
                        var res = 
                        (from p in _db.products
                         orderby p.list_price ascending
                         select p).Take(1);
                        dtgvData.DataSource = res;
                    }
                }
            }
        }
    }
}
