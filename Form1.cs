using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05.Models;

namespace Lab05
{
    public partial class Form1 : Form
    {
        List<OrderReport> orderReports;
        List<Order> orders;
        List<OrderReport> listReport;

        DatabaseContext dbContext;

        public Form1()
        {
            InitializeComponent();

            dbContext = new DatabaseContext();
        }

        private void rbtXemTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            dtpXemTheoNgay.Enabled = false;
            dtpXemTheoThang.Enabled = true;
            dtpTuNgay.Enabled = false;
            dtpDenNgay.Enabled = false;
        }

        private void rbtXemTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpXemTheoNgay.Enabled = true;
            dtpXemTheoThang.Enabled = false;
            dtpTuNgay.Enabled = false;
            dtpDenNgay.Enabled = false;
        }

        private void rbtXemTuNgay_CheckedChanged(object sender, EventArgs e)
        {
            dtpXemTheoNgay.Enabled = false;
            dtpXemTheoThang.Enabled = false;
            dtpTuNgay.Enabled = true;
            dtpDenNgay.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.rpvReport.RefreshReport();

            orders = dbContext.Orders.ToList();

            listReport = new List<OrderReport>();

            orderReports = AddToOrderReport(orders);

            textBox1.Text = orderReports.Count.ToString();
        }
        private void btnXuat_Click(object sender, EventArgs e)
        {
            //this.rpvReport.Clear();

            if (rbtXemTheoNgay.Checked == true)
            {
                List<OrderReport> list = new List<OrderReport>();

                list = orderReports.Where(rp => rp.DeliveryDate.Date == dtpXemTheoNgay.Value.Date).ToList();

                if (list.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlReport.Visible = false;
                }
                else
                {
                    pnlReport.Visible = true;

                    foreach (var item in list)
                    {
                        listReport.Add(item);
                    }
                }

                textBox1.Text = list.Count.ToString();
            }
            else if (rbtXemTheoThang.Checked == true)
            {
                List<OrderReport> list = new List<OrderReport>();

                list = orderReports.Where(rp => rp.DeliveryDate.Month == dtpXemTheoThang.Value.Month && rp.DeliveryDate.Year == dtpXemTheoThang.Value.Year).ToList();

                if (list.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlReport.Visible = false;
                }
                else
                {
                    pnlReport.Visible = true;

                    foreach (var item in list)
                    {
                        listReport.Add(item);
                    }
                }
            }
            else if (rbtXemTuNgay.Checked == true)
            {
                List<OrderReport> list = new List<OrderReport>();

                list = orderReports.Where(rp => rp.DeliveryDate.Date >= dtpTuNgay.Value.Date && rp.DeliveryDate.Date <= dtpDenNgay.Value.Date).ToList();
                
                if (list.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlReport.Visible = false;
                }
                else
                {
                    pnlReport.Visible = true;

                    foreach (var item in list)
                    {
                        listReport.Add(item);
                    }
                }
            }

            this.rpvReport.LocalReport.ReportPath = "./Report.rdlc";
            var reportDataSource = new ReportDataSource("DataSet", listReport);
            this.rpvReport.LocalReport.DataSources.Clear();
            this.rpvReport.LocalReport.DataSources.Add(reportDataSource);
            this.rpvReport.RefreshReport();
        }

        private List<OrderReport> AddToOrderReport(List<Order> orders)
        {
            List<OrderReport> orderReports = new List<OrderReport>();
            OrderReport orderReport;

            foreach (var item in orders)
            {
                orderReport = orderReports.FirstOrDefault(ord => ord.InvoiceNo == item.InvoiceNo);

                if (orderReport == null)
                {
                    orderReport = new OrderReport();

                    orderReport.DeliveryDate = item.Invoice.DeliveryDate;
                    orderReport.InvoiceNo = item.InvoiceNo;
                    orderReport.TotalPrice = (double)(item.Price * item.Quantity);

                    orderReports.Add(orderReport);
                }
                else
                {
                    orderReport.TotalPrice += (double)(item.Price * item.Quantity);
                }
            }

            return orderReports;
        }
    }
}
