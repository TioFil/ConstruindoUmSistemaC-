
namespace CrudCSharp
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "LogoutUser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_LogoutUser_Click);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(237, 178);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(205, 20);
            this.txt_User.TabIndex = 1;
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(237, 242);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(205, 20);
            this.txt_Senha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Text = "HelloWord/Ink";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

