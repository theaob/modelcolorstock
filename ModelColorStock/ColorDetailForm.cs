using System;
using System.Windows.Forms;
using static ModelColorStock.DataGridViewColoredColumn;

namespace ModelColorStock
{
    public partial class ColorDetailForm : Form
    {
        BindingSource sourceSet;

        public ColorDetailForm(ColorsData data)
        {
            InitializeComponent();
            
            sourceSet = new BindingSource(data, "ColorDetail");
            dataGridView1.DataSource = sourceSet;

            dataGridView1.Columns[2].CellTemplate = new DataGridViewColoredCell();
        }

        private void ColorDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
