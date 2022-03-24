using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewCustomizer
{
    public partial class GridViewCustomizerForm : Form
    {
        int columnIndex = -1;
        DataGridViewCellStyle cs = new DataGridViewCellStyle();

        readonly Random rnd = new Random();
        readonly List<SampleModel> samples = new List<SampleModel>();
        public GridViewCustomizerForm()
        {
            InitializeComponent();
            InitGrid();
            InitGeneralProp();
            InitColumnsCombo();
        }

        private void InitGrid()
        {
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));
            samples.Add(new SampleModel(rnd));

            dataGridView.DataSource = samples;
        }

        private void InitGeneralProp()
        {
            GeneralProperties.SelectedObject = dataGridView;
            ColumnHeaderProperties.SelectedObject = dataGridView.DefaultCellStyle;
            RowTemplateDefaultCellStyleProperties.SelectedObject = dataGridView.RowTemplate.DefaultCellStyle;
            RowHeaderProperties.SelectedObject = dataGridView.RowsDefaultCellStyle;

        }

        private void InitColumnsCombo()
        {
            foreach (var item in dataGridView.Columns)
            {
                comboBox1.Items.Add(item);
            }
            comboBox1.DisplayMember = "Name";
        }

        private void PropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this does not work!!
            //for current cell
            SingleColumnHeadersCellStyleProperties.SelectedObject = dataGridView.Columns[comboBox1.SelectedIndex].HeaderCell.Style;
        }

        private void ColumnPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ColumnStyleProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //if (e.ChangedItem.Label == "Alignment")
            //{
            //    dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].HeaderCell.Style.Alignment = (DataGridViewContentAlignment)e.ChangedItem.Value;
            //    //dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //}
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0)
            {
                return;
            }

            columnIndex = e.ColumnIndex;

            ColumnProperties.SelectedObject = dataGridView.Columns[e.ColumnIndex];
            ColumnStyleProperties.SelectedObject = dataGridView.Columns[e.ColumnIndex].DefaultCellStyle;

            //for all header cells
            ColumnHeadersCellStyleProperties.SelectedObject = dataGridView.Columns[e.ColumnIndex].HeaderCell.Style;
                       
        }

        private void HeaderCellStyleProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
           

            switch (e.ChangedItem.Label)
            {
                case nameof(cs.Alignment):
                    cs.Alignment = (DataGridViewContentAlignment)e.ChangedItem.Value;
                    break;
                case nameof(cs.BackColor):
                    cs.BackColor = (Color)e.ChangedItem.Value;
                    break;
                case nameof(cs.ForeColor):
                    cs.ForeColor = (Color)e.ChangedItem.Value;
                    break;
                case nameof(cs.WrapMode):
                    cs.WrapMode = (DataGridViewTriState)e.ChangedItem.Value;
                    break;
                case nameof(cs.Font):
                    cs.Font = (Font)e.ChangedItem.Value;
                    break;
                case nameof(cs.Format):
                    cs.Format = (string)e.ChangedItem.Value;
                    break;
                case nameof(cs.SelectionBackColor):
                    cs.SelectionForeColor = (Color)e.ChangedItem.Value;
                    break;
                case nameof(cs.SelectionForeColor):
                    cs.SelectionForeColor = (Color)e.ChangedItem.Value;
                    break;
                case nameof(cs.Padding):
                    cs.Padding = (Padding)e.ChangedItem.Value;
                    break;
                default:
                    break;

            }

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (i == columnIndex)
                {
                    continue;
                }

                dataGridView.Columns[i].HeaderCell.Style = cs;
            }

        }
    }
}
