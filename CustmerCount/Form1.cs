using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustmerCount
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
            Mastermain.DataSource = dc.Customers.GroupBy(c => c.Country).Select(
                g => new
                {
                    國家 = g.Key,
                    人數 = g.Count()
                }).OrderByDescending(g => g.人數).ToArray();
            dgvTotalMaster.DataSource = dc.Order_Details.GroupBy(od => od.OrderID).ToArray().
                Select(g => new
                {
                    訂單編號 = g.Key,
                    訂單金額 = g.Sum( od => od.UnitPrice * od.Quantity * (decimal)(1 - od.Discount) )
                }).OrderByDescending(od => od.訂單金額).ToArray();
            dgvTotalMaster.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTotalMaster.Columns[1].DefaultCellStyle.Format = "C2";
        }

        private void Mastermain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(Mastermain.CurrentCell != null)
            {
             
                int RowIndex = Mastermain.CurrentCell.RowIndex;
                string Country = Convert.ToString(Mastermain.Rows[RowIndex].Cells[0].Value);
                NorthwindEntities dc = new NorthwindEntities();
                detail.DataSource = dc.Customers.Where(c => c.Country == Country).ToList();
            }
           
        }

        private void dgvTotalMaster_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTotalMaster.CurrentCell != null)
            {
                int RowIndex = dgvTotalMaster.CurrentCell.RowIndex;
                int OrderId = Convert.ToInt32(dgvTotalMaster.Rows[RowIndex].Cells[0].Value);
                NorthwindEntities dc = new NorthwindEntities();
                dgvTotalDetail.DataSource = dc.Order_Details.Where(od => od.OrderID == OrderId).Select(od => new
                {
                    訂單編號 = od.OrderID,
                    商品編號 = od.ProductID,
                    商品名稱 = od.Products.ProductName,
                    商品單價 = od.UnitPrice,
                    訂購數量 = od.Quantity,
                    優惠折扣 = od.Discount
                }).ToList();
            }
            
        }
    }

}
