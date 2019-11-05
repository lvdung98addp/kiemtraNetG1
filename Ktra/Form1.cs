using Ktra.model;
using Ktra.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ktra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var nhom = nhomService.Getnhom(Utils.nhomPathFile);
            if (nhom == null)
            {
                throw new Exception("Lỗi rồi.");
            }
            else
            {
                //nhom.getlist =
                //    //HistoryLearningService.GetListHistoryLearning(idStudent);
                //    lienlacService.GetListlienlac(Utils.lienlacPathFile,id);
                dataGridView1.AutoGenerateColumns = false;
                bindingSourcenhom.DataSource = nhom;
                dataGridView1.DataSource = bindingSourcenhom;
                // start 
                List<lienlac> listlienlac = new List<lienlac>();
                //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value
                var temp = Convert.ToString(dataGridView1.Rows[0].Cells[0].Value);
                listlienlac = lienlacService.GetListlienlac(Utils.lienlacPathFile, temp);
                dataGridView2.AutoGenerateColumns = false;
                bindingSourcelienlac.DataSource = listlienlac;
                dataGridView2.DataSource = bindingSourcelienlac;
                //start
                var temp1 = dataGridView2.Rows[0];
                labeltengoi.Text = Convert.ToString(temp1.Cells[1].Value);
                tbEmail.Text = Convert.ToString(temp1.Cells[2].Value);
                tbDiaChi.Text= Convert.ToString(temp1.Cells[4].Value);
                tbSoDienThoai.Text = Convert.ToString(temp1.Cells[3].Value);
                //dataGridView2.AutoGenerateColumns = false;
                //bindingSourcelienlac.DataSource = nhom.getlist;
                //dataGridView2.DataSource = bindingSourcelienlac;
                //txtMaSinhVien.Text = student.ID;
                //txtHoTen.Text = student.FullName;
                //dtpNgaySinh.Value = student.DateOfBirth;
                //txtNoiSinh.Text = student.PlaceOfBirth;
                //chkGioiTinh.Checked = student.Gender == Model.GENDER.Male;

                //dtgQuaTrinhHocTap.AutoGenerateColumns = false;
                //bdsQuaTrinhHocTap.DataSource = student.ListHistoryLearning;
                //dtgQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;

                //lblTongSoMuc.Text = string.Format("{0} mục",
                //    student.ListHistoryLearning.Count());
            }

        }
        
        private void Button1_Click(object sender, EventArgs e)
        {

        }
        
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
            var f = new addnhom(this);
            f.ShowDialog();
        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            List<lienlac> listlienlac = new List<lienlac>();
            //dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value
            var temp = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            listlienlac = lienlacService.GetListlienlac(Utils.lienlacPathFile, temp);
            dataGridView2.AutoGenerateColumns = false;
            bindingSourcelienlac.DataSource = listlienlac;
            dataGridView2.DataSource = bindingSourcelienlac;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var temp = dataGridView2.Rows[dataGridView2.CurrentRow.Index];
            labeltengoi.Text = Convert.ToString(temp.Cells[1].Value);
            tbEmail.Text = Convert.ToString(temp.Cells[2].Value);
            tbDiaChi.Text = Convert.ToString(temp.Cells[4].Value);
            tbSoDienThoai.Text = Convert.ToString(temp.Cells[3].Value);
        }

        private void xoaNhom_Click(object sender, EventArgs e)
        {
            var nhom = bindingSourcenhom.Current as nhom;
            if (nhom != null)
            {
                var resultDialog = MessageBox.Show(
                    "Bạn có thực sự muốn xóa?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (resultDialog == DialogResult.OK)
                {
                    //Viết code xóa dữ liệu ở đây --> Bài tập về nhà ngày 12/10/2019
                    nhomService.Remove(Utils.nhomPathFile,nhom);
                    bindingSourcenhom.RemoveCurrent();
                }
            }
        }

        private void xoaLienLac_Click(object sender, EventArgs e)
        {
            var lienlac = bindingSourcelienlac.Current as lienlac;
            if (lienlac != null)
            {
                var resultDialog = MessageBox.Show(
                    "Bạn có thực sự muốn xóa?",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (resultDialog == DialogResult.OK)
                {
                    //Viết code xóa dữ liệu ở đây --> Bài tập về nhà ngày 12/10/2019
                    lienlacService.Remove(Utils.lienlacPathFile, lienlac);
                    bindingSourcelienlac.RemoveCurrent();
                }
            }
        }

        private void themLienLac_Click(object sender, EventArgs e)
        {
            var nhom = bindingSourcenhom.Current as nhom;
            var addlienlac = new addlienlac(nhom.id,this);
            addlienlac.ShowDialog();
        }
    }
}
