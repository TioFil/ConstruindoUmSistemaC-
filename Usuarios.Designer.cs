
namespace CrudCSharp
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtGridUsuarios = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exlcuirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarPdfDeUmUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarPdfDeUsuáriosViaSetorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirPermissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissoesDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridUsuarios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 67);
            this.panel1.TabIndex = 0;
            // 
            // DtGridUsuarios
            // 
            this.DtGridUsuarios.BackgroundColor = System.Drawing.Color.Lavender;
            this.DtGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridUsuarios.GridColor = System.Drawing.Color.Purple;
            this.DtGridUsuarios.Location = new System.Drawing.Point(0, 154);
            this.DtGridUsuarios.MaximumSize = new System.Drawing.Size(1320, 700);
            this.DtGridUsuarios.Name = "DtGridUsuarios";
            this.DtGridUsuarios.Size = new System.Drawing.Size(1305, 700);
            this.DtGridUsuarios.TabIndex = 1;
            this.DtGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridUsuarios_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcoesToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.definirPermissõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1320, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcoesToolStripMenuItem
            // 
            this.opcoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.exlcuirToolStripMenuItem,
            this.selecionarToolStripMenuItem});
            this.opcoesToolStripMenuItem.Name = "opcoesToolStripMenuItem";
            this.opcoesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opcoesToolStripMenuItem.Text = "Opcoes";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo ";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click_1);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // exlcuirToolStripMenuItem
            // 
            this.exlcuirToolStripMenuItem.Name = "exlcuirToolStripMenuItem";
            this.exlcuirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exlcuirToolStripMenuItem.Text = "Exlcuir";
            // 
            // selecionarToolStripMenuItem
            // 
            this.selecionarToolStripMenuItem.Name = "selecionarToolStripMenuItem";
            this.selecionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selecionarToolStripMenuItem.Text = "Selecionar";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarPdfDeUmUsuárioToolStripMenuItem,
            this.gerarPdfDeUsuáriosViaSetorToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // gerarPdfDeUmUsuárioToolStripMenuItem
            // 
            this.gerarPdfDeUmUsuárioToolStripMenuItem.Name = "gerarPdfDeUmUsuárioToolStripMenuItem";
            this.gerarPdfDeUmUsuárioToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerarPdfDeUmUsuárioToolStripMenuItem.Text = "Gerar Pdf De Um usuário";
            this.gerarPdfDeUmUsuárioToolStripMenuItem.Click += new System.EventHandler(this.gerarPdfDeUmUsuárioToolStripMenuItem_Click);
            // 
            // gerarPdfDeUsuáriosViaSetorToolStripMenuItem
            // 
            this.gerarPdfDeUsuáriosViaSetorToolStripMenuItem.Name = "gerarPdfDeUsuáriosViaSetorToolStripMenuItem";
            this.gerarPdfDeUsuáriosViaSetorToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.gerarPdfDeUsuáriosViaSetorToolStripMenuItem.Text = "Gerar pdf de Usuários via Setor";
            // 
            // definirPermissõesToolStripMenuItem
            // 
            this.definirPermissõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permissoesDeUsuáriosToolStripMenuItem});
            this.definirPermissõesToolStripMenuItem.Name = "definirPermissõesToolStripMenuItem";
            this.definirPermissõesToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.definirPermissõesToolStripMenuItem.Text = "Definir Permissões";
            // 
            // permissoesDeUsuáriosToolStripMenuItem
            // 
            this.permissoesDeUsuáriosToolStripMenuItem.Name = "permissoesDeUsuáriosToolStripMenuItem";
            this.permissoesDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.permissoesDeUsuáriosToolStripMenuItem.Text = "Permissoes De Usuários";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1304, 661);
            this.Controls.Add(this.DtGridUsuarios);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1320, 700);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridUsuarios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DtGridUsuarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exlcuirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarPdfDeUmUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarPdfDeUsuáriosViaSetorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirPermissõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissoesDeUsuáriosToolStripMenuItem;
    }
}