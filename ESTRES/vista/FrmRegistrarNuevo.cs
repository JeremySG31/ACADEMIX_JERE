using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academix.vista
{
    public partial class FrmRegistrarNuevo : Form
    {
        public FrmRegistrarNuevo()
        {
            InitializeComponent();

            UcNuevoVinculo ucNuevoVinculo = new UcNuevoVinculo();
            ucNuevoVinculo.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucNuevoVinculo);
        }
    }
}
