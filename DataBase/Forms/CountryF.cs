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
    public partial class CountryF : Form
    {
        public CountryF()
        {
            InitializeComponent();
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void CountryF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.shoesDataSet.Country);
            DataRow dr = shoesDataSet.Country.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr["Name"].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.CountryRow dr = shoesDataSet.Country.NewCountryRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            shoesDataSet.Country.AddCountryRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Country.Rows[countryBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Country.Rows[countryBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr["Name"] = dataNameTb.Text;
        }


        private void countryBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (countryBindingSource.Position < shoesDataSet.Country.Rows.Count && countryBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Country.Rows[countryBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr["Name"].ToString();
            }
        }
    }
}
