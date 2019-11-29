using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9
{
    public partial class labFrm : Form
    {
        public labFrm()
        {
            InitializeComponent();
        }

        private void wordBtn_Click(object sender, EventArgs e)
        {
            string userYell = wordTextBox.Text;
            MessageBox.Show(userYell);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            decimal userAdd1 = addNumNud1.Value;
            decimal userAdd2 = addNumNud2.Value;
            decimal result = userAdd1 + userAdd2;
            addResultLbl.Text = $"{result}";
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            decimal userMul1 = mulNumNud1.Value;
            decimal userMul2 = mulNumNud2.Value;
            decimal result = userMul1 * userMul2;
            mulResultLbl.Text = $"{result}";
        }

        private void hideChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hideChkBox.Checked == true)
            {
                everythingBox.Hide();
            }
            else
            {
                everythingBox.Show();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
