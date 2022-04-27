using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewCustomizer
{
    public partial class CustomButtonWindow : Form
    {
        readonly Random rnd = new Random();
        readonly List<Product> products = new List<Product>();

        public CustomButtonWindow()
        {
            InitializeComponent();
            InitData();
            //InitProducts();

        }

        public void InitProducts()
        {
            var p = new Point();
            p.Y = 0;
            p.X = 0;

            int i = 1;
            int j = 1;
            foreach (var item in products)
            {
                var button = new AroniumButton.ProductButton(item.ProductName, item.ProductPrice)
                {
                    Top = p.Y,
                    Left = p.X
                };
                button.Margin = new Padding(3);
                ProductsPanel.Controls.Add(button);

                p.X = i * button.Width;

                if (p.X >= ProductsPanel.Width)
                {
                    i = 0;
                    p.X = 0;
                    p.Y = j * button.Height;
                    i += 1;
                    j += 1;
                }
                else
                {
                    i += 1;
                }
            }
        }

        public void InitData()
        {
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
            products.Add(new Product(rnd));
        }

        private void CustomButtonWindow_Load(object sender, EventArgs e)
        {
            //FlowLayoutPanel flp = new FlowLayoutPanel();
            //List<Button> btn = new List<Button>();
            int i = 0;
            foreach (var item in products)
            {
                //AroniumButton.ProductButton btn = new AroniumButton.ProductButton(item.ProductName, item.ProductPrice);
                Button btn = new Button();                            

                btn.Name = $"{button1.Name}{i}";
                btn.FlatAppearance.BorderColor = button1.FlatAppearance.BorderColor;
                btn.FlatAppearance.MouseOverBackColor = button1.FlatAppearance.MouseOverBackColor;
                btn.FlatAppearance.BorderColor = button1.FlatAppearance.BorderColor;
                btn.FlatAppearance.BorderSize = button1.FlatAppearance.BorderSize;
                btn.BackColor = button1.BackColor;
                btn.ForeColor = button1.ForeColor;
                btn.Image = button1.Image;
                btn.ImageAlign = button1.ImageAlign;
                btn.Size = button1.Size;
                btn.Text = $"{item.ProductName}\n{item.ProductPrice:N2}";
                btn.Font = button1.Font;
                btn.TextAlign = button1.TextAlign;
                btn.Click += Btn_Click;
                btn.Tag = item;
                flowLayoutPanel1.Controls.Add(btn);
                

                i += 1;
            }
            //foreach (var button in btn)
            //{
            //}
            this.Controls.Add(flowLayoutPanel1);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var a = (Button)sender;
            var b = (Product)a.Tag;
            MessageBox.Show($"Button {b.ProductName} / {b.ProductPrice:N2} clicked!");
        }
    }
}
