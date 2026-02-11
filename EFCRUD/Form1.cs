using EFCRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetEmployee()
        {
            NorthwindEntities dc = new NorthwindEntities();
            dgvEmployee.DataSource = dc.Employees.ToArray();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployee();
            NorthwindEntities dc = new NorthwindEntities();
            string[] Titles = dc.Employees.Select(emp => emp.Title).Distinct().ToArray();
            cbInsertTitle.DataSource = Titles;
            cbUpdateTitle.DataSource = Titles.Clone();
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUpdateFirstName.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[2].Value);
            txtUpdateLastName.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[1].Value);
            cbUpdateTitle.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[3].Value);
            textDeleteEmployeeID.Text = txtUpdateEmployeeID.Text = Convert.ToString(dgvEmployee.Rows[e.RowIndex].Cells[0].Value);

        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees
            {
                FirstName = txtInsertFirstName.Text,
                LastName = txtInsertLastName.Text,
                Title = cbInsertTitle.Text,
            };
            NorthwindEntities dc = new NorthwindEntities();
            dc.Employees.Add(emp);
            await dc.SaveChangesAsync();
            GetEmployee();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            Employees Emp = await dc.Employees.FindAsync(Convert.ToInt32(txtUpdateEmployeeID.Text));
            Emp.FirstName = txtUpdateFirstName.Text;
            Emp.LastName = txtUpdateLastName.Text;
            Emp.Title = cbUpdateTitle.Text;
            dc.Employees.AddOrUpdate(Emp);
            await dc.SaveChangesAsync();
            GetEmployee();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            NorthwindEntities dc = new NorthwindEntities();
            Employees emp = await dc.Employees.FindAsync(Convert.ToInt32(textDeleteEmployeeID.Text));
            dc.Employees.Remove(emp);
            try
            {
                await dc.SaveChangesAsync();
                GetEmployee();
            }
            catch(DbUpdateException ex)
            {
                MessageBox.Show("刪除員工資料失敗");
            }
        }
    }
}
