using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3 };
            listBox1.DataSource = arr.Select(x => x * x).ToArray();

            int Evencount = arr.Count(x => x % 2 == 0);
            MessageBox.Show(Evencount.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = { "Hello", "Test", "Studnt", "Saturday" };
            listBox1.DataSource = arr.Where(s => s.EndsWith("t")).OrderBy(s => s.Length).ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Click += (d_sender, d_e) =>
            {

            };
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            string Url = "https://media.4-paws.org/9/c/9/7/9c97c38666efa11b79d94619cc1db56e8c43d430/Molly_006-2829x1886-2726x1886-1920x1328.jpg";
            string Filename = "Cat.jpg";
            WebClient Client = new WebClient();
            Client.DownloadFileCompleted += (d_sender, d_e) =>
            {
                pictureBox1.ImageLocation = Filename;
                Process.Start(Application.StartupPath);
                MessageBox.Show($"{Filename} download success !");

            };
            Client.DownloadFileAsync(new Uri(Url), Filename);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(() => ReturnOdd(), () => ReturnEven());
            listBox1.DataSource = bc.ToArray();
        }
        BlockingCollection<string> bc = new BlockingCollection<string>();

        private void ReturnEven()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    bc.Add($"{i} 是偶數");
                }
            }
        }

        private void ReturnOdd()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 1 == 0)
                {
                    bc.Add($"{i} 是奇數");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_pfor_Click(object sender, EventArgs e)
        {
            Parallel.For(1, 8001, n =>
            {
                bc.Add($"{n} 的平方 = {n * n}");

            });
            listBox1.DataSource = bc.ToArray();
        }
    }
}
