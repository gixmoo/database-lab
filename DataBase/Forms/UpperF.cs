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
    public partial class UpperF : Form
    {
        public UpperF()
        {
            InitializeComponent();
        }

        private void upper_materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.upper_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void UpperF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Upper_material' table. You can move, or remove it, as needed.
            this.upper_materialTableAdapter.Fill(this.shoesDataSet.Upper_material);
            DataRow dr = shoesDataSet.Upper_material.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr["Name"].ToString();
            dataDescTb.Text = dr["Description"].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.Upper_materialRow dr = shoesDataSet.Upper_material.NewUpper_materialRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            dr.Description = dataDescTb.Text;
            shoesDataSet.Upper_material.AddUpper_materialRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Upper_material.Rows[upper_materialBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Upper_material.Rows[upper_materialBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr["Name"] = dataNameTb.Text;
            dr["Description"] = dataDescTb.Text;
        }


        private void upper_materialBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (upper_materialBindingSource.Position < shoesDataSet.Upper_material.Rows.Count && upper_materialBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Upper_material.Rows[upper_materialBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr["Name"].ToString();
                dataDescTb.Text = dr["Description"].ToString();
            }
        }
    }
}
