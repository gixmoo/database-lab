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
    public partial class CatalogueF : Form
    {
        public CatalogueF()
        {
            InitializeComponent();
        }

        private void shoes_catalogueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shoes_catalogueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoesDataSet);

        }

        private void CatalogueF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.shoesDataSet.Type);
            // TODO: This line of code loads data into the 'shoesDataSet.Target_audience' table. You can move, or remove it, as needed.
            this.target_audienceTableAdapter.Fill(this.shoesDataSet.Target_audience);
            // TODO: This line of code loads data into the 'shoesDataSet.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.shoesDataSet.Brand);
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
            // TODO: This line of code loads data into the 'shoesDataSet.Shoes_catalogue' table. You can move, or remove it, as needed.
            this.shoes_catalogueTableAdapter.Fill(this.shoesDataSet.Shoes_catalogue);

            DataRow dr = shoesDataSet.Shoes_catalogue.Rows[0];
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
                ShoesDataSet.Shoes_catalogueRow dr = shoesDataSet.Shoes_catalogue.NewShoes_catalogueRow();
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
                DataRow dr = shoesDataSet.Shoes_catalogue.Rows[shoes_catalogueBindingSource.Position];
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
                DataRow dr = shoesDataSet.Shoes_catalogue.Rows[shoes_catalogueBindingSource.Position];
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

        private void shoes_catalogueBindingSource_PositionChanged(object sender, EventArgs e)
        {

            if (shoes_catalogueBindingSource.Position < shoesDataSet.Shoes_catalogue.Rows.Count && shoes_catalogueBindingSource.Position >= 0)
            {
                DataRow dr = shoesDataSet.Shoes_catalogue.Rows[shoes_catalogueBindingSource.Position];
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

        private void btnIDFind_Click(object sender, EventArgs e)
        {
            DataRow dr = this.shoesDataSet.Shoes_catalogue.FindByCode(byte.Parse(tbIDFind.Text));
            if (dr != null)
            {
                lblFoundName.Text = "Name = " + dr[1].ToString();
                lblFoundStyle.Text = "Style = " + dr[2].ToString();
                lblFoundLining.Text = "Lining material = " + dr[3].ToString();
                lblFoundUpper.Text = "Upper material = " + dr[4].ToString();
                lblFoundSole.Text = "Sole material = " + dr[5].ToString();
                lblFoundColor.Text = "Color = " + dr[6].ToString();
                lblFoundSize.Text = "Size = " + dr[7].ToString();
                lblFoundSeason.Text = "Season = " + dr[8].ToString();
                lblFoundCountry.Text = "Country = " + dr[9].ToString();
                lblFoundBrand.Text = "Brand = " + dr[10].ToString();
                lblFoundAudience.Text = "Target audience = " + dr[11].ToString();
                lblFoundPrize.Text = "Prize = " + dr[12].ToString();
                lblFoundType.Text = "Type = " + dr[13].ToString();
                lblFoundAudience.Text = "Additional = " + dr[14].ToString();
                shoes_catalogueBindingSource.Position = this.shoesDataSet.Shoes_catalogue.Rows.IndexOf(dr);

            }
            else
            {
                MessageBox.Show("code is not found", "search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNameFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Name] like '" + tbNameFind.Text + "*'");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnStyleFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Style] = " + tbStyleFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }


        private void btnLiningFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Lining material] = " + tbLiningFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnUpperFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Upper material] = " + tbUpperFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnSoleFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Sole material] = " + tbSoleFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnColorFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Color] like '" + tbColorFind.Text + "*'");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnSizeFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Size] = " + tbSizeFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnSeasonFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Season] = " + tbSeasonFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnCountryFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Country] = " + tbCountryFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnBrandFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Brand] = " + tbBrandFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnAudienceFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Target audience] = " + tbAudienceFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnPrizeFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Prize] = " + tbPrizeFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnTypeFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Type] = " + tbTypeFind.Text + "");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }

        private void btnAddFind_Click(object sender, EventArgs e)
        {
            DataRow[] foundrows = this.shoesDataSet.Shoes_catalogue.Select("[Additional] like '" + tbAddFind.Text + "*'");
            dgwFound.Rows.Clear();
            foreach (DataRow fr in foundrows)
            {
                dgwFound.Rows.Add(fr.ItemArray);
            }
        }


        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            shoes_catalogueBindingSource.Filter = "";
            if (cbFilter.Checked)
            {
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    if (i == 0)
                    {
                        shoes_catalogueBindingSource.Filter = "[Name] like '*" + tbFilterName.Text + "*'";
                    }
                    if (i == 1)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Style] = " + tbFilterStyle.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Style] = " + tbFilterStyle.Text;
                    }
                    if (i == 2)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Lining material] = " + tbFilterLining.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Lining] = " + tbFilterLining.Text;
                    }
                    if (i == 3)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Upper material] = " + tbFilterUpper.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Upper material] = " + tbFilterUpper.Text;
                    }
                    if (i == 4)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Sole material] = " + tbFilterSole.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Sole material] = " + tbFilterSole.Text;
                    }
                    if (i == 5)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Color] like '*" + tbFilterColor.Text + "*'";
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Color] like '*" + tbFilterColor.Text + "*'";
                    }
                    if (i == 6)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Size] = " + tbFilterSize.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Size] = " + tbFilterSize.Text;
                    }
                    if (i == 7)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Season] = " + tbFilterSeason.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Season] = " + tbFilterSeason.Text;
                    }
                    if (i == 8)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Country] = " + tbFilterCountry.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Country] = " + tbFilterCountry.Text;
                    }
                    if (i == 9)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Brand] = " + tbFilterBrand.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Brand] = " + tbFilterBrand.Text;
                    }
                    if (i == 10)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Target audience] = " + tbFilterAudience.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Target audience] = " + tbFilterAudience.Text;
                    }
                    if (i == 11)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Prize] = " + tbFilterPrize.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Prize] = " + tbFilterPrize.Text;
                    }
                    if (i == 12)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Type] = " + tbFilterType.Text;
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Type] = " + tbFilterType.Text;
                    }
                    if (i == 13)
                    {
                        if (shoes_catalogueBindingSource.Filter == "")
                            shoes_catalogueBindingSource.Filter = "[Additional] like '*" + tbFilterAdd.Text + "*'";
                        else
                            shoes_catalogueBindingSource.Filter = shoes_catalogueBindingSource.Filter + " and [Additional] like '*" + tbFilterAdd.Text + "*'";
                    }
                }
                cbFilter.Text = "Filter on";
            }
            else
            {
                cbFilter.Text = "Filter off";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFilter_CheckedChanged(cbFilter, e);

        }

        private void tbFilterName_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterStyle_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterLining_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterUpper_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterSole_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterColor_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterSize_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterSeason_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterCountry_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterBrand_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterAudience_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterPrize_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterType_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }

        private void tbFilterAdd_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                cbFilter_CheckedChanged(cbFilter, e);
            }
        }
    }
}
