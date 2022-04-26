using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AroniumButton
{
    public partial class ProductButton : UserControl
    {

        public string ProductDescription { get; }
        public decimal ProductPrice { get; }

        public ProductButton()
        {
            InitializeComponent();
        }

        public ProductButton(string productDescription, decimal productPrice)
        {
            InitializeComponent();
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductLabel.Text = productDescription;
            PriceLabel.Text = productPrice.ToString("N2");
        }

    }
}

