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
    public partial class CatalogueFK : Form
    {
        public CatalogueFK()
        {
            InitializeComponent();
        }

        private void CatalogueFK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoesDataSet.ShoesFK' table. You can move, or remove it, as needed.
            this.shoesFKTableAdapter.Fill(this.shoesDataSet.ShoesFK);

        }
    }
}
