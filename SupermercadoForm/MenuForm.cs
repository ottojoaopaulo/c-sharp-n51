using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermercadoForm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            //instancia um objeto do form de estante
            categoriaForm form = new categoriaForm();
            //tornar um form visivel
            form.ShowDialog();
        }

        private void buttonEstantes_Click(object sender, EventArgs e)
        {
            //instancia um objeto do form de estante
            EstanteForm form = new EstanteForm();
            //tornar um form visivel
            form.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
