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
    public partial class BrandFK1 : Form
    {
        public BrandFK1()
        {
            InitializeComponent();
        }

        private void brand1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brand1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void BrandFK1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.shoesDataSet.Country);
            // TODO: This line of code loads data into the 'shoesDataSet.Brand1' table. You can move, or remove it, as needed.
            this.brand1TableAdapter.Fill(this.shoesDataSet.Brand1);
            
            DataRow dr = shoesDataSet.Brand1.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr[1].ToString();
            dataBrandCTb.Text = dr[2].ToString();
            dataDescTb.Text = dr[3].ToString();
            
            

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.Brand1Row dr = shoesDataSet.Brand1.NewBrand1Row();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            dr.Brand_country = byte.Parse(dataBrandCTb.Text);
            dr.Description = dataDescTb.Text;
            
            
            shoesDataSet.Brand1.AddBrand1Row(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Brand1.Rows[brand1BindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Brand1.Rows[brand1BindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr[1] = dataNameTb.Text; 
            dr[2] = byte.Parse(dataBrandCTb.Text);
            dr[3] = dataDescTb.Text;
            
           
        }

        private void brand1BindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (brand1BindingSource.Position < shoesDataSet.Brand1.Rows.Count && brand1BindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Brand1.Rows[brand1BindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr[1].ToString();
                dataBrandCTb.Text = dr[2].ToString();
                dataDescTb.Text = dr[3].ToString();
                
               
            }
        }
    }
}
