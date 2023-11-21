using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp.Cls_Uteis;

namespace WindowsFormsApp
{
    public partial class Frm_ValidaSenha : Form
    {
        bool verSenhaTxt = false;
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Btm_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = "";
            Lbl_Resultado.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();
            if(Lbl_Resultado.Text == "Inaceitavel" | Lbl_Resultado.Text == "Fraca")
                Lbl_Resultado.ForeColor = Color.Red;
            if (Lbl_Resultado.Text == "Aceitavel")
                Lbl_Resultado.ForeColor = Color.Blue;
            if (Lbl_Resultado.Text == "Forte" | Lbl_Resultado.Text == "Segura")
                Lbl_Resultado.ForeColor = Color.Green;

        }

        private void Btm_VerSenha_Click(object sender, EventArgs e)
        {
            if (verSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                verSenhaTxt = true;
                Btm_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                verSenhaTxt = false;
                Btm_VerSenha.Text = "Ver Senha";
            }
        }
    }
}
