using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGN_predits.Formularios.Stoc_k {
    public partial class Stock : Form {
        public Stock() {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e) {
            nuevoPorducto nuevoPorducto = new nuevoPorducto();
            nuevoPorducto.Show();
        }
    }
}
