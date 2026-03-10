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
    public partial class CatalogueFK1 : Form
    {
        public CatalogueFK1()
        {
            InitializeComponent();
        }

        private void shoes_catalogue1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shoes_catalogue1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void CatalogueFK1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.shoesDataSet.Type);
            // TODO: This line of code loads data into the 'shoesDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.shoesDataSet.Brand);
            // TODO: This line of code loads data into the 'shoesDataSet.Target_audience' table. You can move, or remove it, as needed.
            this.target_audienceTableAdapter.Fill(this.shoesDataSet.Target_audience);
            // TODO: This line of code loads data into the 'shoesDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.shoesDataSet.Country);
            // TODO: This line of code loads data into the 'shoesDataSet.Season' table. You can move, or remove it, as needed.
            this.seasonTableAdapter.Fill(this.shoesDataSet.Season);
            // TODO: This line of code loads data into the 'shoesDataSet.Sole_material' table. You can move, or remove it, as needed.
            this.sole_materialTableAdapter.Fill(this.shoesDataSet.Sole_material);
            // TODO: This line of code loads data into the 'shoesDataSet.Upper_material' table. You can move, or remove it, as needed.
            this.upper_materialTableAdapter.Fill(this.shoesDataSet.Upper_material);
            // TODO: This line of code loads data into the 'shoesDataSet.Lining_material' table. You can move, or remove it, as needed.
            this.lining_materialTableAdapter.Fill(this.shoesDataSet.Lining_material);
            // TODO: This line of code loads data into the 'shoesDataSet.Style' table. You can move, or remove it, as needed.
            this.styleTableAdapter.Fill(this.shoesDataSet.Style);
            // TODO: This line of code loads data into the 'shoesDataSet.Shoes_catalogue1' table. You can move, or remove it, as needed.
            this.shoes_catalogue1TableAdapter.Fill(this.shoesDataSet.Shoes_catalogue1);
            DataRow dr = shoesDataSet.Shoes_catalogue1.Rows[0];
            dataCodeTb.Text = dr[0].ToString();
            dataNameTb.Text = dr[1].ToString();
            dataStyleTb.Text = dr[2].ToString();
            dataLiningTb.Text = dr[3].ToString();
            dataUpperTb.Text = dr[4].ToString();
            dataSoleTb.Text = dr[5].ToString();
            dataColorTb.Text = dr[6].ToString();
            dataSizeTb.Text = dr[7].ToString();
            dataSeasonTb.Text = dr[8].ToString();
            dataCountryTb.Text = dr[9].ToString();
            dataBrandTb.Text = dr[10].ToString();
            dataAudienceTb.Text = dr[11].ToString();
            dataPrizeTb.Text = dr[12].ToString();
            dataTypeTb.Text = dr[13].ToString();
            dataAddTb.Text = dr[14].ToString();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ShoesDataSet.Shoes_catalogue1Row dr = shoesDataSet.Shoes_catalogue1.NewShoes_catalogue1Row();
                dr.Code = byte.Parse(dataCodeTb.Text);
                dr.Name = dataNameTb.Text;
                dr.Style = byte.Parse(dataStyleTb.Text);
                dr.Lining_material = byte.Parse(dataLiningTb.Text);
                dr.Upper_material = byte.Parse(dataUpperTb.Text);
                dr.Sole_material = byte.Parse(dataSoleTb.Text);
                dr.Color = dataColorTb.Text;
                dr.Size = double.Parse(dataSizeTb.Text);
                dr.Season = byte.Parse(dataSeasonTb.Text);
                dr.Country = byte.Parse(dataCountryTb.Text);
                dr.Brand = byte.Parse(dataBrandTb.Text);
                dr.Target_audience = byte.Parse(dataAudienceTb.Text);
                dr.Prize = float.Parse(dataPrizeTb.Text);
                dr.Type = byte.Parse(dataTypeTb.Text);
                dr.Additional = dataAddTb.Text;
                shoesDataSet.Shoes_catalogue.Rows.Add(dr);
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данную запись, так как она используется в других таблицах базы данных.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = shoesDataSet.Shoes_catalogue1.Rows[shoes_catalogue1BindingSource.Position];
                dr.Delete();
            }
            catch
            {
                MessageBox.Show("Невозможно удалить данную запись, так как она используется в других таблицах базы данных.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = shoesDataSet.Shoes_catalogue1.Rows[shoes_catalogue1BindingSource.Position];
                dr[0] = byte.Parse(dataCodeTb.Text);
                dr[1] = dataNameTb.Text;
                dr[2] = byte.Parse(dataStyleTb.Text);
                dr[3] = byte.Parse(dataLiningTb.Text);
                dr[4] = byte.Parse(dataUpperTb.Text);
                dr[5] = byte.Parse(dataSoleTb.Text);
                dr[6] = dataColorTb.Text;
                dr[7] = double.Parse(dataSizeTb.Text);
                dr[8] = byte.Parse(dataSeasonTb.Text);
                dr[9] = byte.Parse(dataCountryTb.Text);
                dr[10] = byte.Parse(dataBrandTb.Text);
                dr[11] = byte.Parse(dataAudienceTb.Text);
                dr[12] = float.Parse(dataPrizeTb.Text);
                dr[13] = byte.Parse(dataTypeTb.Text);
                dr[14] = dataAddTb.Text;
            }
            catch
            {
                MessageBox.Show("Невозможно отредактировать данную запись, так как она используется в других таблицах базы данных.", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void shoes_catalogue1BindingSource_PositionChanged(object sender, EventArgs e)
        {

            if (shoes_catalogue1BindingSource.Position < shoesDataSet.Shoes_catalogue1.Rows.Count && shoes_catalogue1BindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Shoes_catalogue1.Rows[shoes_catalogue1BindingSource.Position];
                dataCodeTb.Text = dr[0].ToString();
                dataNameTb.Text = dr[1].ToString();
                dataStyleTb.Text = dr[2].ToString();
                dataLiningTb.Text = dr[3].ToString();
                dataUpperTb.Text = dr[4].ToString();
                dataSoleTb.Text = dr[5].ToString();
                dataColorTb.Text = dr[6].ToString();
                dataSizeTb.Text = dr[7].ToString();
                dataSeasonTb.Text = dr[8].ToString();
                dataCountryTb.Text = dr[9].ToString();
                dataBrandTb.Text = dr[10].ToString();
                dataAudienceTb.Text = dr[11].ToString();
                dataPrizeTb.Text = dr[12].ToString();
                dataTypeTb.Text = dr[13].ToString();
                dataAddTb.Text = dr[14].ToString();
            }
        }

    }
}
