﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCozinha.Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            Classes.Usuario.login = usuario.VerificaAcesso(tx_email.Text, tx_senha.Text);
            if (Classes.Usuario.login)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
        }

        private void btn_esqueciSenha_Click(object sender, EventArgs e)
        {
            Telas.Usuarios usuarios = new Telas.Usuarios();
            usuarios.Show();
        }
    }
}
