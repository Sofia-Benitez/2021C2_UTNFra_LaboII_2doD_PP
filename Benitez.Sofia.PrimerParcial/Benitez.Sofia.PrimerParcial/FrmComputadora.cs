using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiberCafe;

namespace Benitez.Sofia.PrimerParcial
{
    public partial class FrmComputadora : Form
    {
        public FrmComputadora(Computadora c1, Computadora c2, Computadora c3, Computadora c4)
        {
            InitializeComponent();

            rbtnC1.Text = c1.ToString();
            rbtnC2.Text = c2.ToString();
            rbtnC3.Text = c3.ToString();
            rbtnC4.Text = c4.ToString();
        }

    }
}
