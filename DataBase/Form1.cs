using DataBase.Forms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shoesBtn_Click(object sender, EventArgs e)
        {
            CatalogueF catalogue = new CatalogueF();
            catalogue.ShowDialog();
        }

        private void brandBtn_Click(object sender, EventArgs e)
        {
            BrandF brand = new BrandF();
            brand.ShowDialog();
        }

        private void countryBtn_Click(object sender, EventArgs e)
        {
            CountryF country = new CountryF();
            country.ShowDialog();
        }

        private void liningBtn_Click(object sender, EventArgs e)
        {
            LiningF lining = new LiningF();
            lining.ShowDialog();
        }

        private void soleBtn_Click(object sender, EventArgs e)
        {
            SoleF sole = new SoleF();
            sole.ShowDialog();
        }

        private void upperBtn_Click(object sender, EventArgs e)
        {
            UpperF upper = new UpperF();
            upper.ShowDialog();
        }

        private void seasonBtn_Click(object sender, EventArgs e)
        {
            SeasonF season = new SeasonF();
            season.ShowDialog();
        }

        private void styleBtn_Click(object sender, EventArgs e)
        {
            StyleF style = new StyleF();
            style.ShowDialog();
        }

        private void typeBtn_Click(object sender, EventArgs e)
        {
            TypeF type = new TypeF();
            type.ShowDialog();
        }

        private void audienceBtn_Click(object sender, EventArgs e)
        {
            AudienceF audience = new AudienceF();
            audience.ShowDialog();
        }

        private void brandFKBtn_Click(object sender, EventArgs e)
        {
            BrandFK brandFK = new BrandFK();
            brandFK.ShowDialog();
        }

        private void brandFK1Btn_Click(object sender, EventArgs e)
        {
            BrandFK1 brandFK1 = new BrandFK1();
            brandFK1.ShowDialog();
        }

        private void shoesFKBtn_Click(object sender, EventArgs e)
        {
            CatalogueFK catalogueFK = new CatalogueFK();
            catalogueFK.ShowDialog();
        }

        private void shoesFK1Btn_Click(object sender, EventArgs e)
        {
            CatalogueFK1 catalogueFK1 = new CatalogueFK1();
            catalogueFK1.ShowDialog();
        }   
    }
}
