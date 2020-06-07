using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelColorStock
{
    public partial class Form1 : Form
    {
        DataGridViewForm brandForm;
        DataGridViewForm paintTypeForm;
        DataGridViewForm paintStockForm;

        BindingSource brandBindingSource;
        BindingSource paintTypeBindingSource;
        BindingSource paintStockBindingSource;

        public Form1()
        {
            InitializeComponent();

            brandBindingSource = new BindingSource(colorsData, "BrandTable");
            paintTypeBindingSource = new BindingSource(colorsData, "PaintType");
            paintStockBindingSource = new BindingSource(colorsData, "Stock");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                colorsData.ReadXml("colorData.xml");
            }
            catch(System.IO.FileNotFoundException ex)
            {
                colorsData.WriteXml("colorData.xml");
            }
            catch(System.Data.ConstraintException ex)
            {
                colorsData.WriteXml("colorData.xml");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            colorsData.WriteXml("colorData.xml");
        }

        private void newBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brandForm = new DataGridViewForm("Brands", brandBindingSource);
            brandForm.Visible = true;
        }

        private void newPaintTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paintTypeForm = new DataGridViewForm("Paint Types", paintTypeBindingSource);
            paintTypeForm.Visible = true;
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorsData.WriteXml("colorData.xml");
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paintStockForm = new DataGridViewForm("Stock", paintStockBindingSource);
            paintStockForm.Visible = true;
        }

        private void newColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDetailForm form = new ColorDetailForm();
            form.Visible = true;
        }
    }
}
