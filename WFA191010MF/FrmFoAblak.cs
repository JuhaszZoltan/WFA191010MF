using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191010MF
{
    public partial class FrmFoAblak : Form
    {
        public FrmFoAblak()
        {
            InitializeComponent();
        }

        private void btnUjAblak_Click(object sender, EventArgs e)
        {
            FrmMasikAblak ujAblak;

            if(tbData.Text != "")
            {
                ujAblak = new FrmMasikAblak(this, tbData.Text, btnUjAblak.Text);
            }
            else
            {
                ujAblak = new FrmMasikAblak(this);
            }

            ujAblak.ShowDialog();
        }
    }
}
