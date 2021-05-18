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
    public partial class FormRegistar : Form
    {
        public FormRegistar()
        {
            InitializeComponent();
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxEmail.Text))
            {
                if (!string.IsNullOrEmpty(textBoxNome.Text))
                {
                    if (!string.IsNullOrEmpty(textBoxPassword.Text))
                    {
                        if (!string.IsNullOrEmpty(textBox1.Text))
                        {
                            if (textBoxPassword.Text == textBox1.Text)
                            {
                                Models.tbUtilizador _utilizador = new Models.tbUtilizador
                                {
                                    dataCriado = DateTime.Now,
                                    email = textBoxEmail.Text,
                                    nome = textBoxNome.Text,
                                    password = Utils.Encriptar(textBoxPassword.Text),
                                    idUtilizador = 0
                                };

                                if (await Models.tbUtilizador.adiciona(_utilizador))
                                {
                                    MessageBox.Show("Utilizador criado com sucesso!");

                                    Close();
                                }

                                else
                                    MessageBox.Show("Não foi possível criar o utilizador!");
                            }

                            else
                                MessageBox.Show("As passwords não coincidem!");
                        }

                        else
                            Utils.apresentaMensagemTextoNulo("Repetir password");
                    }

                    else
                        Utils.apresentaMensagemTextoNulo("Password");
                }

                else
                    Utils.apresentaMensagemTextoNulo("Nome");
            }

            else
                Utils.apresentaMensagemTextoNulo("Email");
        }
    }
}
