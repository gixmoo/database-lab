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
    public partial class SeasonF : Form
    {
        public SeasonF()
        {
            InitializeComponent();
        }

        private void seasonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seasonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void SeasonF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Season' table. You can move, or remove it, as needed.
            this.seasonTableAdapter.Fill(this.shoesDataSet.Season);
            DataRow dr = shoesDataSet.Season.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr["Name"].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.SeasonRow dr = shoesDataSet.Season.NewSeasonRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            shoesDataSet.Season.AddSeasonRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Season.Rows[seasonBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Season.Rows[seasonBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr["Name"] = dataNameTb.Text;
        }


        private void seasonBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (seasonBindingSource.Position < shoesDataSet.Season.Rows.Count && seasonBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Season.Rows[seasonBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr["Name"].ToString();
            }
        }
    }
}
