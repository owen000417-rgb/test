using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            customersBindingSource.DataSource = dc.Customers.ToArray();

            string[] Countries = dc.Customers.Select(s => s.Country).Distinct().ToArray();
        }

        private void customersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Customers c = customersBindingSource.Current as Customers;
            ordersBindingSource.DataSource = c.Orders.ToArray();

            int ColumnCount = ordersDataGridView.ColumnCount;
            ordersDataGridView.Columns[ColumnCount - 1].Visible = false; 
        }
    }
}
