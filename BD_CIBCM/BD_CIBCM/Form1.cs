using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_CIBCM
{
    public partial class Form1 : Form
    {

        AccesoBaseDatos baseDatos;
        public Form1()
        {
            InitializeComponent();
            baseDatos = new AccesoBaseDatos();
        }
    }
}
