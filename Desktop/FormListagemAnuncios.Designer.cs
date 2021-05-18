
namespace Desktop
{
    partial class FormListagemAnuncios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButtonAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonApagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAtualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLimparPesquisa = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdicionar,
            this.toolStripButtonEditar,
            this.toolStripButtonApagar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBoxPesquisar,
            this.toolStripButtonPesquisar,
            this.toolStripSeparator2,
            this.toolStripButtonAtualizar,
            this.toolStripButtonLimparPesquisa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "Pesquisar:";
            // 
            // toolStripTextBoxPesquisar
            // 
            this.toolStripTextBoxPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxPesquisar.Name = "toolStripTextBoxPesquisar";
            this.toolStripTextBoxPesquisar.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Titulo,
            this.Descricao,
            this.dataCriacao});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 667);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 51;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 72;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // dataCriacao
            // 
            this.dataCriacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataCriacao.HeaderText = "Data criação";
            this.dataCriacao.Name = "dataCriacao";
            this.dataCriacao.ReadOnly = true;
            this.dataCriacao.Width = 124;
            // 
            // toolStripButtonAdicionar
            // 
            this.toolStripButtonAdicionar.Image = global::Desktop.Properties.Resources.plus;
            this.toolStripButtonAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdicionar.Name = "toolStripButtonAdicionar";
            this.toolStripButtonAdicionar.Size = new System.Drawing.Size(78, 22);
            this.toolStripButtonAdicionar.Text = "Adicionar";
            this.toolStripButtonAdicionar.Click += new System.EventHandler(this.toolStripButtonAdicionar_Click);
            // 
            // toolStripButtonEditar
            // 
            this.toolStripButtonEditar.Image = global::Desktop.Properties.Resources.pencil;
            this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditar.Name = "toolStripButtonEditar";
            this.toolStripButtonEditar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonEditar.Text = "Editar";
            this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
            // 
            // toolStripButtonApagar
            // 
            this.toolStripButtonApagar.Image = global::Desktop.Properties.Resources.trash;
            this.toolStripButtonApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonApagar.Name = "toolStripButtonApagar";
            this.toolStripButtonApagar.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonApagar.Text = "Apagar";
            this.toolStripButtonApagar.Click += new System.EventHandler(this.toolStripButtonApagar_Click);
            // 
            // toolStripButtonPesquisar
            // 
            this.toolStripButtonPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPesquisar.Image = global::Desktop.Properties.Resources.search;
            this.toolStripButtonPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPesquisar.Name = "toolStripButtonPesquisar";
            this.toolStripButtonPesquisar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPesquisar.Text = "toolStripButton2";
            this.toolStripButtonPesquisar.Click += new System.EventHandler(this.toolStripButtonPesquisar_Click);
            // 
            // toolStripButtonAtualizar
            // 
            this.toolStripButtonAtualizar.Image = global::Desktop.Properties.Resources.refresh;
            this.toolStripButtonAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAtualizar.Name = "toolStripButtonAtualizar";
            this.toolStripButtonAtualizar.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonAtualizar.Text = "Atualizar";
            this.toolStripButtonAtualizar.Click += new System.EventHandler(this.toolStripButtonAtualizar_Click);
            // 
            // toolStripButtonLimparPesquisa
            // 
            this.toolStripButtonLimparPesquisa.Image = global::Desktop.Properties.Resources.eraser;
            this.toolStripButtonLimparPesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLimparPesquisa.Name = "toolStripButtonLimparPesquisa";
            this.toolStripButtonLimparPesquisa.Size = new System.Drawing.Size(113, 22);
            this.toolStripButtonLimparPesquisa.Text = "Limpar pesquisa";
            this.toolStripButtonLimparPesquisa.Click += new System.EventHandler(this.toolStripButtonLimparPesquisa_Click);
            // 
            // FormListagemAnuncios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormListagemAnuncios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listagem anúncios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListagemAnuncios_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacao;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPesquisar;
        private System.Windows.Forms.ToolStripButton toolStripButtonPesquisar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAtualizar;
        private System.Windows.Forms.ToolStripButton toolStripButtonLimparPesquisa;
        private System.Windows.Forms.ToolStripButton toolStripButtonApagar;
    }
}