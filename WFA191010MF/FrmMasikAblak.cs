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
    public partial class FrmMasikAblak : Form
    {
        FrmFoAblak refFoablak;
        public FrmMasikAblak(FrmFoAblak fm)
        {
            InitializeComponent();
            this.refFoablak = fm;
            MessageBox.Show("nem jön string");

            rbK.CheckedChanged += RB_CheckedChanged;
            rbP.CheckedChanged += RB_CheckedChanged;

        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbP.Checked) refFoablak.btnUjAblak.BackColor = Color.Red;
            else if (rbK.Checked) refFoablak.btnUjAblak.BackColor = Color.Blue;
        }

        public FrmMasikAblak(FrmFoAblak fm, string szoveg, string gombFeirat)
        {
            InitializeComponent();
            this.refFoablak = fm;
            MessageBox.Show("a gombra az volt írva, hogy " + gombFeirat);
            lblSzoveg.Text = szoveg;
        }
    }
}
