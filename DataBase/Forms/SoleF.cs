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
    public partial class SoleF : Form
    {
        public SoleF()
        {
            InitializeComponent();
        }

        private void sole_materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sole_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void SoleF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Sole_material' table. You can move, or remove it, as needed.
            this.sole_materialTableAdapter.Fill(this.shoesDataSet.Sole_material);
            DataRow dr = shoesDataSet.Sole_material.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr["Name"].ToString();
            dataDescTb.Text = dr["Description"].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.Sole_materialRow dr = shoesDataSet.Sole_material.NewSole_materialRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            dr.Description = dataDescTb.Text;
            shoesDataSet.Sole_material.AddSole_materialRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Sole_material.Rows[sole_materialBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Sole_material.Rows[sole_materialBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr["Name"] = dataNameTb.Text;
            dr["Description"] = dataDescTb.Text;
        }


        private void sole_materialBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (sole_materialBindingSource.Position < shoesDataSet.Sole_material.Rows.Count && sole_materialBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Sole_material.Rows[sole_materialBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr["Name"].ToString();
                dataDescTb.Text = dr["Description"].ToString();
            }
        }
    }
}
