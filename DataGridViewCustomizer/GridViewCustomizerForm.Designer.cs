
namespace DataGridViewCustomizer
{
    partial class GridViewCustomizerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridViewCustomizerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SingleColumnHeadersCellStyleProperties = new System.Windows.Forms.PropertyGrid();
            this.ColumnHeadersCellStyleProperties = new System.Windows.Forms.PropertyGrid();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ColumnStyleProperties = new System.Windows.Forms.PropertyGrid();
            this.ColumnProperties = new System.Windows.Forms.PropertyGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RowHeaderProperties = new System.Windows.Forms.PropertyGrid();
            this.ColumnHeaderProperties = new System.Windows.Forms.PropertyGrid();
            this.GeneralPropPanel = new System.Windows.Forms.Panel();
            this.RowTemplateDefaultCellStyleProperties = new System.Windows.Forms.PropertyGrid();
            this.GeneralProperties = new System.Windows.Forms.PropertyGrid();
            this.sampleModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GeneralPropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Black;
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(1924, 45);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "DataGridView Customizer";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 676);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SingleColumnHeadersCellStyleProperties);
            this.panel5.Controls.Add(this.ColumnHeadersCellStyleProperties);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 354);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(697, 322);
            this.panel5.TabIndex = 1;
            // 
            // SingleColumnHeadersCellStyleProperties
            // 
            this.SingleColumnHeadersCellStyleProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.SingleColumnHeadersCellStyleProperties.Location = new System.Drawing.Point(345, 0);
            this.SingleColumnHeadersCellStyleProperties.Name = "SingleColumnHeadersCellStyleProperties";
            this.SingleColumnHeadersCellStyleProperties.Size = new System.Drawing.Size(352, 322);
            this.SingleColumnHeadersCellStyleProperties.TabIndex = 2;
            // 
            // ColumnHeadersCellStyleProperties
            // 
            this.ColumnHeadersCellStyleProperties.Dock = System.Windows.Forms.DockStyle.Left;
            this.ColumnHeadersCellStyleProperties.Location = new System.Drawing.Point(0, 0);
            this.ColumnHeadersCellStyleProperties.Name = "ColumnHeadersCellStyleProperties";
            this.ColumnHeadersCellStyleProperties.Size = new System.Drawing.Size(344, 322);
            this.ColumnHeadersCellStyleProperties.TabIndex = 1;
            this.ColumnHeadersCellStyleProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.HeaderCellStyleProperties_PropertyValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(697, 354);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.GeneralPropPanel);
            this.MainPanel.Location = new System.Drawing.Point(703, 48);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1215, 673);
            this.MainPanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ColumnStyleProperties);
            this.panel4.Controls.Add(this.ColumnProperties);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(729, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 647);
            this.panel4.TabIndex = 3;
            // 
            // ColumnStyleProperties
            // 
            this.ColumnStyleProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnStyleProperties.Location = new System.Drawing.Point(0, 325);
            this.ColumnStyleProperties.Name = "ColumnStyleProperties";
            this.ColumnStyleProperties.Size = new System.Drawing.Size(486, 322);
            this.ColumnStyleProperties.TabIndex = 2;
            this.ColumnStyleProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ColumnStyleProperties_PropertyValueChanged);
            // 
            // ColumnProperties
            // 
            this.ColumnProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColumnProperties.Location = new System.Drawing.Point(0, 0);
            this.ColumnProperties.Name = "ColumnProperties";
            this.ColumnProperties.Size = new System.Drawing.Size(486, 325);
            this.ColumnProperties.TabIndex = 1;
            this.ColumnProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ColumnPropertyGrid_PropertyValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(729, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 26);
            this.panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(486, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.ComboBox1_SelectionChangeCommitted);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RowHeaderProperties);
            this.panel2.Controls.Add(this.ColumnHeaderProperties);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(352, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 673);
            this.panel2.TabIndex = 1;
            // 
            // RowHeaderProperties
            // 
            this.RowHeaderProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowHeaderProperties.Location = new System.Drawing.Point(0, 351);
            this.RowHeaderProperties.Name = "RowHeaderProperties";
            this.RowHeaderProperties.Size = new System.Drawing.Size(377, 322);
            this.RowHeaderProperties.TabIndex = 1;
            // 
            // ColumnHeaderProperties
            // 
            this.ColumnHeaderProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.ColumnHeaderProperties.Location = new System.Drawing.Point(0, 0);
            this.ColumnHeaderProperties.Name = "ColumnHeaderProperties";
            this.ColumnHeaderProperties.Size = new System.Drawing.Size(377, 351);
            this.ColumnHeaderProperties.TabIndex = 0;
            // 
            // GeneralPropPanel
            // 
            this.GeneralPropPanel.Controls.Add(this.RowTemplateDefaultCellStyleProperties);
            this.GeneralPropPanel.Controls.Add(this.GeneralProperties);
            this.GeneralPropPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GeneralPropPanel.Location = new System.Drawing.Point(0, 0);
            this.GeneralPropPanel.Name = "GeneralPropPanel";
            this.GeneralPropPanel.Size = new System.Drawing.Size(352, 673);
            this.GeneralPropPanel.TabIndex = 0;
            // 
            // RowTemplateDefaultCellStyleProperties
            // 
            this.RowTemplateDefaultCellStyleProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowTemplateDefaultCellStyleProperties.Location = new System.Drawing.Point(0, 351);
            this.RowTemplateDefaultCellStyleProperties.Name = "RowTemplateDefaultCellStyleProperties";
            this.RowTemplateDefaultCellStyleProperties.Size = new System.Drawing.Size(352, 322);
            this.RowTemplateDefaultCellStyleProperties.TabIndex = 1;
            // 
            // GeneralProperties
            // 
            this.GeneralProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.GeneralProperties.Location = new System.Drawing.Point(0, 0);
            this.GeneralProperties.Name = "GeneralProperties";
            this.GeneralProperties.Size = new System.Drawing.Size(352, 351);
            this.GeneralProperties.TabIndex = 0;
            this.GeneralProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid1_PropertyValueChanged);
            // 
            // sampleModelBindingSource
            // 
            this.sampleModelBindingSource.DataSource = typeof(DataGridViewCustomizer.SampleModel);
            // 
            // GridViewCustomizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1924, 721);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GridViewCustomizerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.GeneralPropPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel GeneralPropPanel;
        private System.Windows.Forms.PropertyGrid GeneralProperties;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PropertyGrid ColumnHeaderProperties;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PropertyGrid ColumnProperties;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PropertyGrid ColumnStyleProperties;
        private System.Windows.Forms.PropertyGrid RowHeaderProperties;
        private System.Windows.Forms.PropertyGrid RowTemplateDefaultCellStyleProperties;
        private System.Windows.Forms.BindingSource sampleModelBindingSource;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PropertyGrid SingleColumnHeadersCellStyleProperties;
        private System.Windows.Forms.PropertyGrid ColumnHeadersCellStyleProperties;
    }
}

