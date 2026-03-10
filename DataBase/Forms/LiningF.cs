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
    public partial class LiningF : Form
    {
        public LiningF()
        {
            InitializeComponent();
        }

        private void lining_materialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lining_materialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void LiningF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Lining_material' table. You can move, or remove it, as needed.
            this.lining_materialTableAdapter.Fill(this.shoesDataSet.Lining_material);
            DataRow dr = shoesDataSet.Lining_material.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr["Name"].ToString();
            dataDescTb.Text = dr["Description"].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.Lining_materialRow dr = shoesDataSet.Lining_material.NewLining_materialRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            dr.Description = dataDescTb.Text;
            shoesDataSet.Lining_material.AddLining_materialRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Lining_material.Rows[lining_materialBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Lining_material.Rows[lining_materialBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr["Name"] = dataNameTb.Text;
            dr["Description"] = dataDescTb.Text;
        }


        private void lining_materialBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (lining_materialBindingSource.Position < shoesDataSet.Lining_material.Rows.Count && lining_materialBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Lining_material.Rows[lining_materialBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr["Name"].ToString();
                dataDescTb.Text = dr["Description"].ToString();
            }
        }
    }
}
