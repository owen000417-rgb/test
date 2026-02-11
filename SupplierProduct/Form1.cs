using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplierProduct
{
    public partial class cbSuppliers : Form
    {
        public cbSuppliers()
        {
            InitializeComponent();
        }

        private void cbSuppliers_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            comboBox1.DataSource = dc.Suppliers.Select(s => s.CompanyName).OrderBy(cn => cn).ToArray();

            var query = dc.Products.Select(p => p.UnitPrice);
            decimal? max = query.Max();
            decimal? min = query.Min();
            decimal? avg = query.Average();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            Suppliers sup = dc.Suppliers.Where(n => n.CompanyName == comboBox1.Text).Single();
            productsBindingSource.DataSource = sup.Products.ToArray();

            int ColumnCount = productsDataGridView.ColumnCount;
            productsDataGridView.Columns[ColumnCount - 1].Visible = false;
        }
    }
}
