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
    public partial class ExercicioForm : Form
    {
        public ExercicioForm()
        {
            InitializeComponent();
        }

        private void textBoxNomeAluno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonClacularMedia_Click(object sender, EventArgs e)
            
        {
            string nome = textBoxNomeAluno.Text;
            string idade = numericUpDown1.Text;

            int Nota1 = 0;
            int Nota2 = 0;
            int Nota3 = 0;

            Nota1 = Convert.ToInt32(textBoxNota1.Text);
            Nota2 = Convert.ToInt32(textBoxNota2.Text);
            Nota3 = Convert.ToInt32(textBoxNota3.Text);

            int mediaAluno = (Nota1 + Nota2 + Nota3) / 3;

            MessageBox.Show("A media final do aluno:  " + nome + " com " + idade + " anos " + " é de: " + mediaAluno);
        }
    }
}
