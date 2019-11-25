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
    public partial class addlienlac : Form
    {
        Form1 Form1;
        string  idnhom;
        public addlienlac(string id,Form1 form1)
        {
            InitializeComponent();
            idnhom = id;
            Form1 = form1;
        }

        private void addlienlac_Load(object sender, EventArgs e)
        {

        }

        private void luu_Click(object sender, EventArgs e)
        {
            lienlac addlienlac = new lienlac();
            addlienlac.id = Guid.NewGuid().ToString();
            addlienlac.idnhom =idnhom;
            addlienlac.name = tbten.Text;
            addlienlac.sdt = tbsdt.Text;
            addlienlac.emali = tbemail.Text;
            lienlacService.Add(Utils.lienlacPathFile, addlienlac);
            //add nhom to grid view

            //var listnhom = nhomService.Getnhom(Utils.nhomPathFile);
            // Form1 form1 = new Form1();
            //Form1.dataGridView1.AutoGenerateColumns = false;
            // form1.bindingSourcenhom.DataSource = listnhom;
            // form1.dataGridView1.DataSource = form1.bindingSourcenhom;
            this.Close();
            Form1 thu = new Form1();
            //thu.Refresh();
            //Form1.Invalidate();
            //Form1.Refresh();
            thu.Close();
            thu.Show();
        }

        private void tbten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
