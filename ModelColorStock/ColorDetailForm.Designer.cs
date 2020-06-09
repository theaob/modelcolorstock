namespace ModelColorStock
{
    partial class ColorDetailForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorCodeHexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revellColorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamiyaColorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humbrolColorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherColorCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsData = new ModelColorStock.ColorsData();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colorIDDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.colorCodeHexDataGridViewTextBoxColumn,
            this.revellColorCodeDataGridViewTextBoxColumn,
            this.tamiyaColorCodeDataGridViewTextBoxColumn,
            this.humbrolColorCodeDataGridViewTextBoxColumn,
            this.otherColorCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.colorDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colorIDDataGridViewTextBoxColumn
            // 
            this.colorIDDataGridViewTextBoxColumn.DataPropertyName = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.HeaderText = "ColorID";
            this.colorIDDataGridViewTextBoxColumn.Name = "colorIDDataGridViewTextBoxColumn";
            this.colorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            // 
            // colorCodeHexDataGridViewTextBoxColumn
            // 
            this.colorCodeHexDataGridViewTextBoxColumn.DataPropertyName = "ColorCodeHex";
            this.colorCodeHexDataGridViewTextBoxColumn.HeaderText = "ColorCodeHex";
            this.colorCodeHexDataGridViewTextBoxColumn.Name = "colorCodeHexDataGridViewTextBoxColumn";
            // 
            // revellColorCodeDataGridViewTextBoxColumn
            // 
            this.revellColorCodeDataGridViewTextBoxColumn.DataPropertyName = "RevellColorCode";
            this.revellColorCodeDataGridViewTextBoxColumn.HeaderText = "RevellColorCode";
            this.revellColorCodeDataGridViewTextBoxColumn.Name = "revellColorCodeDataGridViewTextBoxColumn";
            // 
            // tamiyaColorCodeDataGridViewTextBoxColumn
            // 
            this.tamiyaColorCodeDataGridViewTextBoxColumn.DataPropertyName = "TamiyaColorCode";
            this.tamiyaColorCodeDataGridViewTextBoxColumn.HeaderText = "TamiyaColorCode";
            this.tamiyaColorCodeDataGridViewTextBoxColumn.Name = "tamiyaColorCodeDataGridViewTextBoxColumn";
            // 
            // humbrolColorCodeDataGridViewTextBoxColumn
            // 
            this.humbrolColorCodeDataGridViewTextBoxColumn.DataPropertyName = "HumbrolColorCode";
            this.humbrolColorCodeDataGridViewTextBoxColumn.HeaderText = "HumbrolColorCode";
            this.humbrolColorCodeDataGridViewTextBoxColumn.Name = "humbrolColorCodeDataGridViewTextBoxColumn";
            // 
            // otherColorCodeDataGridViewTextBoxColumn
            // 
            this.otherColorCodeDataGridViewTextBoxColumn.DataPropertyName = "OtherColorCode";
            this.otherColorCodeDataGridViewTextBoxColumn.HeaderText = "OtherColorCode";
            this.otherColorCodeDataGridViewTextBoxColumn.Name = "otherColorCodeDataGridViewTextBoxColumn";
            // 
            // colorDetailBindingSource
            // 
            this.colorDetailBindingSource.DataMember = "ColorDetail";
            this.colorDetailBindingSource.DataSource = this.colorsData;
            // 
            // colorsData
            // 
            this.colorsData.DataSetName = "ColorsData";
            this.colorsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ColorDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ColorDetailForm";
            this.Text = "ColorDetailForm";
            this.Load += new System.EventHandler(this.ColorDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorCodeHexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revellColorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamiyaColorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humbrolColorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherColorCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource colorDetailBindingSource;
        private ColorsData colorsData;
    }
}