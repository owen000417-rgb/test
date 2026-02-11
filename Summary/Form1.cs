using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summary
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
            cbCustomer.DataSource = dc.Customers.Select(c => c.CompanyName).ToArray();
        }


        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            Customers c = dc.Customers.Where(cust => cust.CompanyName == cbCustomer.Text).Single();
            if(c.Orders.Count() > 0)
                cbOrders.DataSource = dc.Orders.Where(o => o.CustomerID == c.CustomerID ).Select(o => o.OrderID).
                    ToArray();
            else
            {
                MessageBox.Show("客戶尚未有訂購紀錄 ! ");
                cbOrders.DataSource = dgvOrderDetail.DataSource = null;
                lbtotal.Text = null;
            }
        }

        private async void cbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbOrders.Text))
            {
                NorthwindEntities dc = new NorthwindEntities();
                Orders o = await dc.Orders.FindAsync(Convert.ToInt32(cbOrders.Text));
                var query = o.Order_Details.ToArray().Select(od => new
                {
                    訂單編號 = od.OrderID,
                    商品編號 = od.ProductID,
                    商品單價 = od.UnitPrice,
                    購買數量 = od.Quantity,
                    優惠折扣 = od.Discount,
                    小計 = od.UnitPrice * od.Quantity * (decimal)(1 - od.Discount)
                });
                dgvOrderDetail.DataSource = query.ToArray();

                lbtotal.Text = $"總計 : {query.Sum(od => od.小計):C2}";
            }
        }
    }
}
