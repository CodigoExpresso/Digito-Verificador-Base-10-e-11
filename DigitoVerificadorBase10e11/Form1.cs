using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolutionDigitoVerificadorBase10e11
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Valida Digitação somente de números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || //Letras
            char.IsSymbol(e.KeyChar) ||     //Símbolos
            char.IsWhiteSpace(e.KeyChar) || //Espaço
            char.IsPunctuation(e.KeyChar))  //Pontuação
            e.Handled = true;
        }

        /// <summary>
        /// Calcula o dígito verificador para BAse 10 e 11 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculaDigito_Click(object sender, EventArgs e)
        {
            Int32 valor = 0;
            
            // Converte o texto com string para inteiro
            try
            {
                valor = Convert.ToInt32(txtValor.Text);
            }
            catch
            {
                valor = 0;
            }

            // Verifica se o valor é maior que zero
            if (valor == 0)
            {
                MessageBox.Show("Valor não pode ser Zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtValor.Focus();
                return;
            }

            // Calcula dígito verificador Base 10 e 11 e formata a label com os resultados
            lbBase10.Text = string.Format("Dígito verificador base 10 : {0}-{1}", valor, DigitoVerificadorBase10e11.DigitoM10(valor));
            lbBase11.Text = string.Format("Dígito verificador base 11 : {0}-{1}", valor, DigitoVerificadorBase10e11.DigitoM11(valor));
        }
    }
}
