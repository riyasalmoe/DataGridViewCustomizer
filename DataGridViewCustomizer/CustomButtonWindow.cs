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
    public partial class CustomButtonWindow : Form
    {
        readonly Random rnd = new Random();
        readonly List<Product> products = new List<Product>();

        public CustomButtonWindow()
        {
            InitializeComponent();
            InitData();
            InitProducts();

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

        }
    }
}
