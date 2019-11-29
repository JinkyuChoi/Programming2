using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class frmPeople : Form
    {
        private People _people = new People();
        public frmPeople()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxFName.Text = null;
            tbxLName.Text = null;
            nudAge.Value = 0;
            rbtnAndroid.Checked = false;
            rbtnApple.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EMobileType mobileType;
            if (rbtnAndroid.Checked == true)
            {
                mobileType = EMobileType.Android;
            }
            else if (rbtnApple.Checked == true)
            {
                mobileType = EMobileType.Apple;
            }
            else
            {
                mobileType = EMobileType.none;
            }

            Person newPerson = new Person()
            {
                FirstName = tbxFName.Text,
                LastName = tbxLName.Text,
                Age = Convert.ToInt32(nudAge.Value),
                MobileType = mobileType
            };

            if (newPerson.FirstName == string.Empty || newPerson.LastName == string.Empty || newPerson.Age == 0)
            {
                MessageBox.Show("You must input Name and Age");
            }
            else
            {
                _people.Add(newPerson);

                dgvPeople.DataSource = null;
                dgvPeople.DataSource = _people.GetAllPeople();

                lblTotalPeople.Text = $"Total People : {_people.Count}";
                lblVisiblePeople.Text = $"Visible People : {dgvPeople.RowCount}";

                tbxFName.Text = null;
                tbxLName.Text = null;
                nudAge.Value = 0;
                rbtnAndroid.Checked = false;
                rbtnApple.Checked = false;
            }
        }

        private void rbtnShowAll_CheckedChanged(object sender, EventArgs e)
        {
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = _people.GetAllPeople();

            lblTotalPeople.Text = $"Total People : {_people.Count}";
            lblVisiblePeople.Text = $"Visible People : {dgvPeople.RowCount}";
        }

        private void rbtnShowApple_CheckedChanged(object sender, EventArgs e)
        {
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = _people.GetApplePeople();

            lblTotalPeople.Text = $"Total People : {_people.Count}";
            lblVisiblePeople.Text = $"Visible People : {dgvPeople.RowCount}";
        }

        private void rbtnShowAndroid_CheckedChanged(object sender, EventArgs e)
        {
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = _people.GetAndroidPeople();

            lblTotalPeople.Text = $"Total People : {_people.Count}";
            lblVisiblePeople.Text = $"Visible People : {dgvPeople.RowCount}";
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            _people.Clear();
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = _people.GetAndroidPeople();

            lblTotalPeople.Text = $"Total People : {_people.Count}";
            lblVisiblePeople.Text = $"Visible People : {dgvPeople.RowCount}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
