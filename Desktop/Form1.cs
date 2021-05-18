using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Verificar o login
        /// 
        /// Métodos que façam conexão com o servidor têm que ser asincronos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        /// <summary>
        /// Método para efetuar o login no servidor
        /// </summary>
        private async void login()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxUsername.Text))
                {
                    if (!string.IsNullOrEmpty(textBoxPassword.Text))
                    {
                        if (await Models.tbUtilizador.verificaLogin(textBoxUsername.Text, textBoxPassword.Text))
                        {
                            FormListagemAnuncios _form = new FormListagemAnuncios();
                            _form.ShowDialog();
                        }

                        else
                            MessageBox.Show("Nenhum utilizador encontrado!");
                    }

                    else
                        Utils.apresentaMensagemTextoNulo("Password");
                }

                else
                    Utils.apresentaMensagemTextoNulo("Username");
            }

            catch
            {
                MessageBox.Show("Não foi possível efetuar o login!");
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:

                    login();

                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Utils.client = new System.Net.Http.HttpClient();
        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            FormRegistar _form = new FormRegistar();
            _form.ShowDialog();
        }
    }
}
