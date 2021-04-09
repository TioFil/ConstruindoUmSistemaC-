
namespace CrudCSharp
{
    partial class CadastroUsuarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Setor = new System.Windows.Forms.TextBox();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.txt_Email_interno = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo do Setor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Pessoal Interno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo Ocupacional";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.MaximumSize = new System.Drawing.Size(237, 27);
            this.label5.MinimumSize = new System.Drawing.Size(237, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha ";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_User.Location = new System.Drawing.Point(272, 45);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(229, 27);
            this.txt_User.TabIndex = 5;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(126, 100);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(300, 20);
            this.txt_Senha.TabIndex = 6;
            // 
            // txt_Codigo_Setor
            // 
            this.txt_Codigo_Setor.Location = new System.Drawing.Point(126, 154);
            this.txt_Codigo_Setor.Name = "txt_Codigo_Setor";
            this.txt_Codigo_Setor.Size = new System.Drawing.Size(103, 20);
            this.txt_Codigo_Setor.TabIndex = 7;
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Location = new System.Drawing.Point(140, 299);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(223, 20);
            this.txt_Cargo.TabIndex = 8;
            // 
            // txt_Email_interno
            // 
            this.txt_Email_interno.Location = new System.Drawing.Point(150, 221);
            this.txt_Email_interno.Name = "txt_Email_interno";
            this.txt_Email_interno.Size = new System.Drawing.Size(236, 20);
            this.txt_Email_interno.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(326, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(219, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome De Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 42);
            this.panel1.TabIndex = 11;
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(641, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txt_Email_interno);
            this.Controls.Add(this.txt_Cargo);
            this.Controls.Add(this.txt_Codigo_Setor);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CadastroUsuarios";
            this.Text = "CadastroUsuarios";
            this.Load += new System.EventHandler(this.CadastroUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Codigo_Setor;
        private System.Windows.Forms.TextBox txt_Cargo;
        private System.Windows.Forms.TextBox txt_Email_interno;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}