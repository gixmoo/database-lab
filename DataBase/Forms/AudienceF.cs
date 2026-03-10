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
    public partial class AudienceF : Form
    {
        public AudienceF()
        {
            InitializeComponent();
        }

        private void target_audienceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.target_audienceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void AudienceF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Target_audience' table. You can move, or remove it, as needed.
            this.target_audienceTableAdapter.Fill(this.shoesDataSet.Target_audience);
            DataRow dr = shoesDataSet.Target_audience.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr["Name"].ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ShoesDataSet.Target_audienceRow dr = shoesDataSet.Target_audience.NewTarget_audienceRow();
            dr.Code = byte.Parse(dataCodeTb.Text);
            dr.Name = dataNameTb.Text;
            shoesDataSet.Target_audience.AddTarget_audienceRow(dr);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Target_audience.Rows[target_audienceBindingSource.Position];
            dr.Delete();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            DataRow dr = shoesDataSet.Target_audience.Rows[target_audienceBindingSource.Position];
            dr[0] = byte.Parse(dataCodeTb.Text);
            dr["Name"] = dataNameTb.Text;
        }


        private void target_audienceBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (target_audienceBindingSource.Position < shoesDataSet.Target_audience.Rows.Count && target_audienceBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Target_audience.Rows[target_audienceBindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr["Name"].ToString();
            }
        }
    }
}
