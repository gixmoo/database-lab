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
    public partial class BrandF : Form
    {
        public BrandF()
        {
            InitializeComponent();
        }

        private void brandBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void BrandF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.shoesDataSet.Country);
            // TODO: This line of code loads data into the 'shoesDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.shoesDataSet.Brand);

            DataRow dr = shoesDataSet.Brand.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr[1].ToString();
            dataBrandCTb.Text = dr[2].ToString();
            dataDescTb.Text = dr[3].ToString();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.BrandRow dr = shoesDataSet.Brand.NewBrandRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            dr.Brand_country = byte.Parse(dataBrandCTb.Text);
            dr.Description = dataDescTb.Text;
            shoesDataSet.Brand.AddBrandRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Brand.Rows[brandBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Brand.Rows[brandBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr[1] = dataNameTb.Text;
            dr[2] = byte.Parse(dataBrandCTb.Text);
            dr[3] = dataDescTb.Text;
        }

        private void brandBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (brandBindingSource.Position < shoesDataSet.Brand.Rows.Count && brandBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Brand.Rows[brandBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr[1].ToString();
                dataBrandCTb.Text = dr[2].ToString();
                dataDescTb.Text = dr[3].ToString();
            }
        }
    }
}
