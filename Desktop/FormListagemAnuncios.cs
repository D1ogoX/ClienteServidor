using Newtonsoft.Json;
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
    public partial class FormListagemAnuncios : Form
    {
        private int iCodigo = -1;

        public FormListagemAnuncios()
        {
            InitializeComponent();

            apresentaDados();
        }

        private void FormListagemAnuncios_Load(object sender, EventArgs e)
        {

        }

        private async void apresentaDados(string _sPesquisa = "")
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                    dataGridView1.Rows.Clear();

                List<Models.tbAnuncios> listaAnuncios = new List<Models.tbAnuncios>(await Models.tbAnuncios.getTodosAnuncios());

                if (!string.IsNullOrEmpty(_sPesquisa))
                {
                    _sPesquisa = _sPesquisa.ToUpper();

                    listaAnuncios = new List<Models.tbAnuncios>(listaAnuncios.Where(x => x.idAnuncio.ToString().Contains(_sPesquisa) || x.titulo.ToUpper().Contains(_sPesquisa)
                    || x.descricao.ToUpper().Contains(_sPesquisa)));
                }

                foreach (Models.tbAnuncios _anuncio in listaAnuncios)
                {
                    dataGridView1.Rows.Add(_anuncio.idAnuncio, _anuncio.titulo, _anuncio.descricao, _anuncio.dataCriado);
                }
            }

            catch
            {
                MessageBox.Show("Não foi possível apresentar dados!");
            }
        }

        private void toolStripButtonAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionarAnuncio _form = new FormAdicionarAnuncio();
            _form.ShowDialog();
        }

        private void toolStripButtonAtualizar_Click(object sender, EventArgs e)
        {
            apresentaDados();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    FormEditarAnuncio _form = new FormEditarAnuncio(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    _form.Show();
                }
            }

            catch
            { }
        }

        private void toolStripButtonPesquisar_Click(object sender, EventArgs e)
        {
            apresentaDados(toolStripTextBoxPesquisar.Text);
        }

        private void toolStripButtonLimparPesquisa_Click(object sender, EventArgs e)
        {
            toolStripTextBoxPesquisar.Text = string.Empty;

            apresentaDados();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    iCodigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                else
                    iCodigo = -1;
            }

            catch
            {
                iCodigo = -1;
            }
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            if (iCodigo != -1)
            {
                FormEditarAnuncio _form = new FormEditarAnuncio(iCodigo);
                _form.Show();
            }

            else
                MessageBox.Show("Nenhum registo selecionado!");
        }

        private async void toolStripButtonApagar_Click(object sender, EventArgs e)
        {
            if (iCodigo != -1)
            {
                if (MessageBox.Show("Tem a certeza que pretende apagar este registo?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (await Models.tbAnuncios.apagar(iCodigo))
                    {
                        MessageBox.Show("Apagado com sucesso!");
                    }

                    else
                        MessageBox.Show("Não foi possível apagar o registo!");
                }
            }

            else
                MessageBox.Show("Nenhum registo selecionado!");

            apresentaDados(toolStripTextBoxPesquisar.Text);
        }
    }
}
