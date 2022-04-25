
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SingleColumnHeadersCellStyleProperties = new System.Windows.Forms.PropertyGrid();
            this.ColumnHeadersCellStyleProperties = new System.Windows.Forms.PropertyGrid();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ColumnStyleProperties = new System.Windows.Forms.PropertyGrid();
            this.ColumnProperties = new System.Windows.Forms.PropertyGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RowHeaderProperties = new System.Windows.Forms.PropertyGrid();
            this.ColumnHeaderProperties = new System.Windows.Forms.PropertyGrid();
            this.GeneralPropPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.headerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
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
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.SingleColumnHeadersCellStyleProperties);
            this.panel5.Controls.Add(this.ColumnHeadersCellStyleProperties);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(697, 409);
            this.panel5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(342, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selected Column Header Cell Style";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "All Column Header Cell Style";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingleColumnHeadersCellStyleProperties
            // 
            this.SingleColumnHeadersCellStyleProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleColumnHeadersCellStyleProperties.Location = new System.Drawing.Point(342, 37);
            this.SingleColumnHeadersCellStyleProperties.Name = "SingleColumnHeadersCellStyleProperties";
            this.SingleColumnHeadersCellStyleProperties.Size = new System.Drawing.Size(352, 372);
            this.SingleColumnHeadersCellStyleProperties.TabIndex = 2;
            // 
            // ColumnHeadersCellStyleProperties
            // 
            this.ColumnHeadersCellStyleProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnHeadersCellStyleProperties.Location = new System.Drawing.Point(0, 37);
            this.ColumnHeadersCellStyleProperties.Name = "ColumnHeadersCellStyleProperties";
            this.ColumnHeadersCellStyleProperties.Size = new System.Drawing.Size(344, 372);
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
            this.dataGridView.Size = new System.Drawing.Size(697, 267);
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
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.ColumnStyleProperties);
            this.panel4.Controls.Add(this.ColumnProperties);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(729, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 647);
            this.panel4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(6, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(477, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Column Style Properties";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(486, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Column Properties";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnStyleProperties
            // 
            this.ColumnStyleProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnStyleProperties.Location = new System.Drawing.Point(0, 353);
            this.ColumnStyleProperties.Name = "ColumnStyleProperties";
            this.ColumnStyleProperties.Size = new System.Drawing.Size(492, 294);
            this.ColumnStyleProperties.TabIndex = 2;
            this.ColumnStyleProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ColumnStyleProperties_PropertyValueChanged);
            // 
            // ColumnProperties
            // 
            this.ColumnProperties.Location = new System.Drawing.Point(0, 28);
            this.ColumnProperties.Name = "ColumnProperties";
            this.ColumnProperties.Size = new System.Drawing.Size(492, 297);
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
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.RowHeaderProperties);
            this.panel2.Controls.Add(this.ColumnHeaderProperties);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(352, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 673);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(3, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Row Header Properties";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "All Column Properties";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RowHeaderProperties
            // 
            this.RowHeaderProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RowHeaderProperties.Location = new System.Drawing.Point(0, 379);
            this.RowHeaderProperties.Name = "RowHeaderProperties";
            this.RowHeaderProperties.Size = new System.Drawing.Size(377, 294);
            this.RowHeaderProperties.TabIndex = 1;
            // 
            // ColumnHeaderProperties
            // 
            this.ColumnHeaderProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnHeaderProperties.Location = new System.Drawing.Point(0, 35);
            this.ColumnHeaderProperties.Name = "ColumnHeaderProperties";
            this.ColumnHeaderProperties.Size = new System.Drawing.Size(377, 316);
            this.ColumnHeaderProperties.TabIndex = 0;
            // 
            // GeneralPropPanel
            // 
            this.GeneralPropPanel.Controls.Add(this.label2);
            this.GeneralPropPanel.Controls.Add(this.label1);
            this.GeneralPropPanel.Controls.Add(this.RowTemplateDefaultCellStyleProperties);
            this.GeneralPropPanel.Controls.Add(this.GeneralProperties);
            this.GeneralPropPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GeneralPropPanel.Location = new System.Drawing.Point(0, 0);
            this.GeneralPropPanel.Name = "GeneralPropPanel";
            this.GeneralPropPanel.Size = new System.Drawing.Size(352, 673);
            this.GeneralPropPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(3, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Row Template Default Cell Style";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "General Properties";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RowTemplateDefaultCellStyleProperties
            // 
            this.RowTemplateDefaultCellStyleProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RowTemplateDefaultCellStyleProperties.Location = new System.Drawing.Point(0, 407);
            this.RowTemplateDefaultCellStyleProperties.Name = "RowTemplateDefaultCellStyleProperties";
            this.RowTemplateDefaultCellStyleProperties.Size = new System.Drawing.Size(352, 266);
            this.RowTemplateDefaultCellStyleProperties.TabIndex = 1;
            // 
            // GeneralProperties
            // 
            this.GeneralProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralProperties.Location = new System.Drawing.Point(4, 35);
            this.GeneralProperties.Name = "GeneralProperties";
            this.GeneralProperties.Size = new System.Drawing.Size(348, 338);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

