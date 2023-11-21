using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Frm_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string cpf = Msk_CPF.Text.Replace(".", "").Replace("-", "").Trim();

            if (string.IsNullOrEmpty(cpf))
            {
                MostrarMensagem("Você deve digitar um CPF", MessageBoxIcon.Error);
            }
            else if (cpf.Length != 11)
            {
                MostrarMensagem("CPF deve ter 11 dígitos", MessageBoxIcon.Error);
            }
            else
            {
                if (ConfirmarAcao("Você deseja realmente validar o CPF?"))
                {
                    bool cpfValido = Cls_Uteis.Valida(cpf);

                    MostrarMensagem(cpfValido ? "CPF Válido" : "CPF Inválido", cpfValido ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                }
            }
        }
        private void MostrarMensagem(string mensagem, MessageBoxIcon icon)
        {
            MessageBox.Show(mensagem, "Mensagem de Validação", MessageBoxButtons.OK, icon);
        }

        private bool ConfirmarAcao(string pergunta)
        {
            return MessageBox.Show(pergunta, "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

    }
}
