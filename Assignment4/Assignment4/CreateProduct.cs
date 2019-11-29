using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class frmCreateProduct : Form
    {
        public EventHandler<ProductEventArgs> AddProduct;
        public frmCreateProduct()
        {
            InitializeComponent();
        }

        protected virtual void OnAddProduct()
        {
            Product product = new Product()
            {
                Department = (EDepartment)Enum.Parse(typeof(EDepartment), cbxCategory.SelectedItem.ToString()),
                Name = txtName.Text,
                Price = nudPrice.Value
            };
            ProductEventArgs e = new ProductEventArgs(product);
            AddProduct(this, e);
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                OnAddProduct();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Input all the values");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
