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
    public partial class FormEditarAnuncio : Form
    {
        private int iCodigo = -1;

        public FormEditarAnuncio(int _iCodigo)
        {
            InitializeComponent();

            iCodigo = _iCodigo;

            apresentaDados(_iCodigo);
        }

        private async void apresentaDados(int _iCodigo)
        {
            try
            {
                Models.tbAnuncios _anuncio = await Models.tbAnuncios.getAnuncioCodigo(_iCodigo);

                textBoxID.Text = _anuncio.idAnuncio.ToString();
                textBoxTitulo.Text = _anuncio.titulo;
                richTextBox1.Text = _anuncio.descricao;
            }

            catch
            {
                MessageBox.Show("Não foi possível apresentar dados!");
            }
        }

        private void FormEditarAnuncio_Load(object sender, EventArgs e)
        {

        }

        private async void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text))
                {
                    if (!string.IsNullOrEmpty(richTextBox1.Text))
                    {
                        Models.tbAnuncios _anuncioAux = await Models.tbAnuncios.getAnuncioCodigo(iCodigo);

                        Models.tbAnuncios _anuncio = new Models.tbAnuncios
                        {
                            idAnuncio = iCodigo,
                            titulo = textBoxTitulo.Text,
                            descricao = richTextBox1.Text,

                            //Conteudo facultativo mas que é necessário para envio para a API:
                            idUtilizador = _anuncioAux.idUtilizador,
                            dataCriado = _anuncioAux.dataCriado,
                            publicado = _anuncioAux.publicado
                        };

                        if (await Models.tbAnuncios.editar(_anuncio))
                        {
                            MessageBox.Show("Anúncio editado com sucesso!");
                        }

                        else
                            MessageBox.Show("Não foi possível editar o anúncio!");
                    }

                    else
                        Utils.apresentaMensagemTextoNulo("Descrição");
                }

                else
                    Utils.apresentaMensagemTextoNulo("Título");
            }

            catch
            {
                MessageBox.Show("Não foi possível editar o anúncio!");
            }
        }
    }
}
