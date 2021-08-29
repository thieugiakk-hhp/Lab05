
namespace Lab05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTGGiaoHang = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpXemTheoThang = new System.Windows.Forms.DateTimePicker();
            this.dtpXemTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.rbtXemTuNgay = new System.Windows.Forms.RadioButton();
            this.rbtXemTheoThang = new System.Windows.Forms.RadioButton();
            this.rbtXemTheoNgay = new System.Windows.Forms.RadioButton();
            this.rpvReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTGGiaoHang);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.dtpXemTheoThang);
            this.groupBox1.Controls.Add(this.dtpXemTheoNgay);
            this.groupBox1.Controls.Add(this.rbtXemTuNgay);
            this.groupBox1.Controls.Add(this.rbtXemTheoThang);
            this.groupBox1.Controls.Add(this.rbtXemTheoNgay);
            this.groupBox1.Location = new System.Drawing.Point(130, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // lblTGGiaoHang
            // 
            this.lblTGGiaoHang.AutoSize = true;
            this.lblTGGiaoHang.Location = new System.Drawing.Point(7, 25);
            this.lblTGGiaoHang.Name = "lblTGGiaoHang";
            this.lblTGGiaoHang.Size = new System.Drawing.Size(101, 13);
            this.lblTGGiaoHang.TabIndex = 3;
            this.lblTGGiaoHang.Text = "Thời gian giao hàng";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(365, 91);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(14, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "~";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(435, 111);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 25);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất Report";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(385, 85);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(125, 20);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Enabled = false;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(235, 85);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(125, 20);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // dtpXemTheoThang
            // 
            this.dtpXemTheoThang.CustomFormat = "MM/yyyy";
            this.dtpXemTheoThang.Enabled = false;
            this.dtpXemTheoThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXemTheoThang.Location = new System.Drawing.Point(235, 55);
            this.dtpXemTheoThang.Name = "dtpXemTheoThang";
            this.dtpXemTheoThang.Size = new System.Drawing.Size(125, 20);
            this.dtpXemTheoThang.TabIndex = 1;
            // 
            // dtpXemTheoNgay
            // 
            this.dtpXemTheoNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpXemTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXemTheoNgay.Location = new System.Drawing.Point(235, 25);
            this.dtpXemTheoNgay.Name = "dtpXemTheoNgay";
            this.dtpXemTheoNgay.Size = new System.Drawing.Size(125, 20);
            this.dtpXemTheoNgay.TabIndex = 1;
            // 
            // rbtXemTuNgay
            // 
            this.rbtXemTuNgay.AutoSize = true;
            this.rbtXemTuNgay.Location = new System.Drawing.Point(125, 85);
            this.rbtXemTuNgay.Name = "rbtXemTuNgay";
            this.rbtXemTuNgay.Size = new System.Drawing.Size(90, 17);
            this.rbtXemTuNgay.TabIndex = 0;
            this.rbtXemTuNgay.Text = "Xem Từ Ngày";
            this.rbtXemTuNgay.UseVisualStyleBackColor = true;
            this.rbtXemTuNgay.CheckedChanged += new System.EventHandler(this.rbtXemTuNgay_CheckedChanged);
            // 
            // rbtXemTheoThang
            // 
            this.rbtXemTheoThang.AutoSize = true;
            this.rbtXemTheoThang.Location = new System.Drawing.Point(125, 55);
            this.rbtXemTheoThang.Name = "rbtXemTheoThang";
            this.rbtXemTheoThang.Size = new System.Drawing.Size(108, 17);
            this.rbtXemTheoThang.TabIndex = 0;
            this.rbtXemTheoThang.Text = "Xem Theo Tháng";
            this.rbtXemTheoThang.UseVisualStyleBackColor = true;
            this.rbtXemTheoThang.CheckedChanged += new System.EventHandler(this.rbtXemTheoThang_CheckedChanged);
            // 
            // rbtXemTheoNgay
            // 
            this.rbtXemTheoNgay.AutoSize = true;
            this.rbtXemTheoNgay.Checked = true;
            this.rbtXemTheoNgay.Location = new System.Drawing.Point(125, 25);
            this.rbtXemTheoNgay.Name = "rbtXemTheoNgay";
            this.rbtXemTheoNgay.Size = new System.Drawing.Size(102, 17);
            this.rbtXemTheoNgay.TabIndex = 0;
            this.rbtXemTheoNgay.TabStop = true;
            this.rbtXemTheoNgay.Text = "Xem Theo Ngày";
            this.rbtXemTheoNgay.UseVisualStyleBackColor = true;
            this.rbtXemTheoNgay.CheckedChanged += new System.EventHandler(this.rbtXemTheoNgay_CheckedChanged);
            // 
            // rpvReport
            // 
            this.rpvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvReport.Location = new System.Drawing.Point(0, 0);
            this.rpvReport.Name = "ReportViewer";
            this.rpvReport.ServerReport.BearerToken = null;
            this.rpvReport.Size = new System.Drawing.Size(760, 281);
            this.rpvReport.TabIndex = 0;
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.rpvReport);
            this.pnlReport.Location = new System.Drawing.Point(12, 168);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(760, 281);
            this.pnlReport.TabIndex = 2;
            this.pnlReport.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlReport);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtXemTheoThang;
        private System.Windows.Forms.RadioButton rbtXemTheoNgay;
        private System.Windows.Forms.Button btnXuat;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReport;
        private System.Windows.Forms.Panel pnlReport;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpXemTheoThang;
        private System.Windows.Forms.DateTimePicker dtpXemTheoNgay;
        private System.Windows.Forms.RadioButton rbtXemTuNgay;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblTGGiaoHang;
    }
}

