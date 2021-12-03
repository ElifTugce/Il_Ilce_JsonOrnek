using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il_Ilce_JsonOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ıLSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //açık form varsa kapat
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }
            FormILSorgulama formILSorgulama = new FormILSorgulama();
            formILSorgulama.MdiParent = this;
            formILSorgulama.Show();
            //form içinde form boyutlarında göstermesi için ayarlama yap.
            this.LayoutMdi(MdiLayout.TileVertical);

        }
    }
}
