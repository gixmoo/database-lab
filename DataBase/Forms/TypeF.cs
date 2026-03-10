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
    public partial class TypeF : Form
    {
        public TypeF()
        {
            InitializeComponent();
        }

        private void typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void TypeF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.shoesDataSet.Type);
            DataRow dr = shoesDataSet.Type.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr["Name"].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.TypeRow dr = shoesDataSet.Type.NewTypeRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            shoesDataSet.Type.AddTypeRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Type.Rows[typeBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Type.Rows[typeBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr["Name"] = dataNameTb.Text;
        }


        private void typeBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (typeBindingSource.Position < shoesDataSet.Type.Rows.Count && typeBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Type.Rows[typeBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr["Name"].ToString();
            }
        }
    }
}
