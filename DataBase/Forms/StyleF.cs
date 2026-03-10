using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class StyleF : Form
    {
        public StyleF()
        {
            InitializeComponent();
        }

        private void styleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.styleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void StyleF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Style' table. You can move, or remove it, as needed.
            this.styleTableAdapter.Fill(this.shoesDataSet.Style);
            DataRow dr = shoesDataSet.Style.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr["Name"].ToString();
            dataDescTb.Text = dr["Description"].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.StyleRow dr = shoesDataSet.Style.NewStyleRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            dr.Description = dataDescTb.Text;
            shoesDataSet.Style.AddStyleRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Style.Rows[styleBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Style.Rows[styleBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr["Name"] = dataNameTb.Text;
            dr["Description"] = dataDescTb.Text;
        }


        private void styleBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (styleBindingSource.Position < shoesDataSet.Style.Rows.Count && styleBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Style.Rows[styleBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr["Name"].ToString();
                dataDescTb.Text = dr["Description"].ToString();
            }
        }
    }
}
