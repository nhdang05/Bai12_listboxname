using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai12_listboxname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            private void btnEdit_Click(object sender, EventArgs e)
            {
                if (lstNames.SelectedIndex < 0)
                {
                    MessageBox.Show("Hãy chọn tên trong danh sách", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lstNames.Items[lstNames.SelectedIndex] = txtName.Text;
                }

            }

            private void Form1_Load(object sender, EventArgs e)
            {
                lstNames.Items.Add("1");
                lstNames.Items.Add("2");
                lstNames.Items.Add("3");
                lstNames.Items.Add("4");
                lstNames.Items.Add("5");
                lstNames.Items.Add("6");
                lstNames.Items.Add("7");
                lstNames.Items.Add("8");
                lstNames.Items.Add("9");
                lstNames.Items.Add("10");
            }
            private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lstNames.SelectedIndex < 0)
                {
                    return;
                }
                txtName.Text = lstNames.Items[lstNames.SelectedIndex].ToString();

            }

            private void btnRemove_Click(object sender, EventArgs e)
            {
                if (lstNames.SelectedIndex >= 0)
                {
                    lstNames.Items.RemoveAt(lstNames.SelectedIndex);
                }
            }
            private void btnInsert_Click(object sender, EventArgs e)
            {
                if (lstNames.SelectedIndex >= 0)
                {
                    lstNames.Items.Insert(Convert.ToInt32(txtindex.Text), txtName.Text);
                }


            }
            private void txtindex_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
}
    