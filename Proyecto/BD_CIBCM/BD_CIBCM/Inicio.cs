using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_CIBCM
{
    public partial class Inicio : UserControl
    {
        TabControl tabs;

        public Inicio(TabControl t)
        {
            InitializeComponent();
            this.tabs = t;
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            this.tabs.SelectedIndex = 1;
            this.Hide();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            this.tabs.SelectedIndex = 0;
            this.Hide();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            this.tabs.SelectedIndex = 2;
            this.Hide();
        }
    }
}
