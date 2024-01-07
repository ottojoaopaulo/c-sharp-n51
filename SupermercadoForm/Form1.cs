namespace SupermercadoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxOperacao.SelectedItem = "Somar";
        }

        private void buttonConcatenar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ola mundo");
            string nome = textBoxNome.Text;

            if (nome.Length > 15)
            {
                MessageBox.Show("O nome nao deve ter mais de 15 caracteres");
                return;
            }

            if (nome.Length < 2)
            {
                MessageBox.Show("O nome deve conter no minimo 2 caracteres");
                return;
            }
            string sobrenome = textBoxSobrenome.Text;

            if (sobrenome.Length > 150)
            {
                MessageBox.Show("O sobrenome nao deve ter mais de 150 caracteres");
                return;
            }

            if (sobrenome.Length < 2)
            {
                MessageBox.Show("O sobrenome deve conter no minimo 2 caracteres");
                return;
            }

            string nomeCompleto = nome + " " + sobrenome;
            MessageBox.Show(nomeCompleto);

        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            string operacaoEscolhida = comboBoxOperacao.SelectedItem.ToString();
            int numero1 = 0;
            try
            {
                numero1 = Convert.ToInt32(textBoxNumero1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Numero 1 deve ser um numero inteiro");
                textBoxNumero1.Focus();
                return;
            }

            int numero2 = 0;
            try
            {
                numero2 = Convert.ToInt32(textBoxNumero2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Numero 2 deve ser um numero inteiro");
                textBoxNumero1.Focus();
                return;
            }

            int resultado = 0;
            char operacaoSimbolo = ' ';
            if (operacaoEscolhida == "Somar")
            {
                resultado = numero1 + numero2;
                operacaoSimbolo = '+';
            }
            else if (operacaoEscolhida == "Subtrair")
            {
                resultado = numero2 - numero1;
                operacaoSimbolo = '-';
            }
            else if (operacaoEscolhida == "Multiplicar")
            {
                resultado = numero2 * numero1;
                operacaoSimbolo = '*';
            }
            else if (operacaoEscolhida == "Dividir")
            {
                resultado = numero2 / numero1;
                operacaoSimbolo = '/';

                if (numero2 == 0)
                {
                    MessageBox.Show("Numero 2 nao pode ser 0");
                    textBoxNumero2.Focus();
                    return;
                }
            }


            DateTime dataHoraAtual = DateTime.Now;
            string dataHoraFormatada = dataHoraAtual.ToShortDateString() + " " +
                dataHoraAtual.ToLongTimeString();

            string texto = dataHoraFormatada + " " + numero1 + " " + operacaoSimbolo + " " + numero2 + " = " + resultado + "\n";
            richTextBoxHistorico.Text += texto;

            LimparCampos();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {


            richTextBoxHistorico.Clear();
        }

        private void LimparCampos()
        {
            textBoxNumero1.Clear();
            textBoxNumero2.Clear();
            richTextBoxHistorico.Clear();
            comboBoxOperacao.SelectedItem = "Somar";
            textBoxNumero1.Focus();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
