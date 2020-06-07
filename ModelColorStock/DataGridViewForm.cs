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
    public partial class DataGridViewForm : Form
    {
        BindingSource sourceSet;

        public DataGridViewForm(String title, BindingSource sourceSet)
        {
            InitializeComponent();
            this.sourceSet = sourceSet;
            this.Text = title;
        }

        private void DataGridViewForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = sourceSet;
        }
    }
}
