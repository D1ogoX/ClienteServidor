
namespace Desktop
{
    partial class FormEditarAnuncio
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
            this.toolStripButtonGuardar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGuardar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(441, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonGuardar
            // 
            this.toolStripButtonGuardar.Image = global::Desktop.Properties.Resources.save;
            this.toolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuardar.Name = "toolStripButtonGuardar";
            this.toolStripButtonGuardar.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonGuardar.Text = "Guardar";
            this.toolStripButtonGuardar.Click += new System.EventHandler(this.toolStripButtonGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxID.Location = new System.Drawing.Point(12, 48);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(179, 26);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(12, 122);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(417, 26);
            this.textBoxTitulo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(417, 127);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // FormEditarAnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormEditarAnuncio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar anúncio";
            this.Load += new System.EventHandler(this.FormEditarAnuncio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}