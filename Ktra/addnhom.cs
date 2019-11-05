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
    public partial class addnhom : Form
    {
        Form1 Form1;
        public addnhom(Form1 form1)
        {

            InitializeComponent();
            this.Form1 = form1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            nhom addnhom = new nhom();
            addnhom.id = Guid.NewGuid().ToString();
            addnhom.tennhom = tbaddnamenhom.Text;
            nhomService.Add(Utils.nhomPathFile, addnhom);
            //add nhom to grid view

           var listnhom = nhomService.Getnhom(Utils.nhomPathFile);
            // Form1 form1 = new Form1();
            //Form1.dataGridView1.AutoGenerateColumns = false;
            // form1.bindingSourcenhom.DataSource = listnhom;
            // form1.dataGridView1.DataSource = form1.bindingSourcenhom;
            Form1.Invalidate();
            Form1.Refresh();
            this.Close();
        }
    }
}
