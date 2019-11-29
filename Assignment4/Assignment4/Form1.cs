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
    public partial class frmMain : Form
    {
        private Catalog _catalog;
        private string _filePath;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _filePath = txtFilePath.Text;
                _catalog = DataStore.Load(_filePath);
                dgvCatalog.DataSource = _catalog.GetAllProducts();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid Input");
                _filePath = null;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("File not found");
                _filePath = null;
            }
        }

        private void chkAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSave.Checked)
            {
                if (_filePath != null)
                {
                    tmrAutoSave.Start();
                }
                else
                {
                    MessageBox.Show("Must load file");
                    chkAutoSave.Checked = false;
                }
            }
            else
            {
                tmrAutoSave.Stop();
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            if (_filePath != null)
            {
                using (frmCreateProduct childForm = new frmCreateProduct())
                {
                    childForm.AddProduct += childForm_AddProduct;
                    childForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Must load file");
            }
        }

        private void childForm_AddProduct(object sender, ProductEventArgs e)
        {
            Product newProduct = new Product()
            {
                Department = e.NewProduct.Department,
                Name = e.NewProduct.Name,
                Price = e.NewProduct.Price
            };
            _catalog.Add(newProduct);

            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = _catalog.GetAllProducts();
        }

        private void tmrAutoSave_Tick(object sender, EventArgs e)
        {
            DataStore.Save(_catalog, _filePath);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCatalog.DataSource = null;
            dgvCatalog.DataSource = _catalog.GetProducts(txtFilter.Text);
        }
    }
}


