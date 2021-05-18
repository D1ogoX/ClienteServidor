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
    public partial class FormAdicionarAnuncio : Form
    {
        public FormAdicionarAnuncio()
        {
            InitializeComponent();
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (!string.IsNullOrEmpty(richTextBox1.Text))
                    {
                        Models.tbAnuncios _anuncio = new Models.tbAnuncios
                        {
                            titulo = textBox1.Text,
                            descricao = richTextBox1.Text,
                            dataCriado = DateTime.Now,
                            idAnuncio = 0,
                            idUtilizador = 0,
                            publicado = false
                        };

                        if (await Models.tbAnuncios.adiciona(_anuncio))
                        {
                            MessageBox.Show("Anúncio adicionado com sucesso!");

                            Close();
                        }

                        else
                            MessageBox.Show("Não foi possível adicionar anúncio!");
                    }

                    else
                        Utils.apresentaMensagemTextoNulo("Descrição");
                }

                else
                    Utils.apresentaMensagemTextoNulo("Título");
            }

            catch
            {
                MessageBox.Show("Não foi possível adicionar anúncio!");
            }
        }

        private void FormAdicionarAnuncio_Load(object sender, EventArgs e)
        {

        }
    }
}
