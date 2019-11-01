namespace ERP
{
    partial class frmCliente
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
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.tbpListar = new System.Windows.Forms.TabPage();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.dtgListarPessoas = new System.Windows.Forms.DataGridView();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbcCadastro.SuspendLayout();
            this.tbpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarPessoas)).BeginInit();
            this.tbpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCadastro
            // 
            this.tbcCadastro.Controls.Add(this.tbpListar);
            this.tbcCadastro.Controls.Add(this.tbpCadastro);
            this.tbcCadastro.Location = new System.Drawing.Point(23, 12);
            this.tbcCadastro.Name = "tbcCadastro";
            this.tbcCadastro.SelectedIndex = 0;
            this.tbcCadastro.Size = new System.Drawing.Size(792, 493);
            this.tbcCadastro.TabIndex = 1;
            // 
            // tbpListar
            // 
            this.tbpListar.Controls.Add(this.btnPesquisar);
            this.tbpListar.Controls.Add(this.txtPesquisar);
            this.tbpListar.Controls.Add(this.lblPesquisar);
            this.tbpListar.Controls.Add(this.dtgListarPessoas);
            this.tbpListar.Location = new System.Drawing.Point(4, 22);
            this.tbpListar.Name = "tbpListar";
            this.tbpListar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpListar.Size = new System.Drawing.Size(784, 467);
            this.tbpListar.TabIndex = 0;
            this.tbpListar.Text = "Lista de Clientes";
            this.tbpListar.UseVisualStyleBackColor = true;
            this.tbpListar.Click += new System.EventHandler(this.tbpListar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(585, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 28);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(71, 26);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(499, 20);
            this.txtPesquisar.TabIndex = 6;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(14, 29);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 5;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // dtgListarPessoas
            // 
            this.dtgListarPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListarPessoas.Location = new System.Drawing.Point(17, 65);
            this.dtgListarPessoas.Name = "dtgListarPessoas";
            this.dtgListarPessoas.Size = new System.Drawing.Size(683, 369);
            this.dtgListarPessoas.TabIndex = 4;
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.btnSalvar);
            this.tbpCadastro.Controls.Add(this.txtEmail);
            this.tbpCadastro.Controls.Add(this.mskCPF);
            this.tbpCadastro.Controls.Add(this.lblCPF);
            this.tbpCadastro.Controls.Add(this.mskTelefone);
            this.tbpCadastro.Controls.Add(this.lblEmail);
            this.tbpCadastro.Controls.Add(this.lblTelefone);
            this.tbpCadastro.Controls.Add(this.txtNome);
            this.tbpCadastro.Controls.Add(this.lblNome);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCadastro.Size = new System.Drawing.Size(784, 467);
            this.tbpCadastro.TabIndex = 1;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(396, 159);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(78, 59);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(229, 20);
            this.mskCPF.TabIndex = 19;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(22, 62);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 25;
            this.lblCPF.Text = "CPF";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(77, 85);
            this.mskTelefone.Mask = "(99)9999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(231, 20);
            this.mskTelefone.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(22, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(22, 88);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(35, 13);
            this.lblTelefone.TabIndex = 21;
            this.lblTelefone.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(394, 20);
            this.txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 519);
            this.Controls.Add(this.tbcCadastro);
            this.Name = "frmCliente";
            this.Text = "Pessoa";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tbcCadastro.ResumeLayout(false);
            this.tbpListar.ResumeLayout(false);
            this.tbpListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarPessoas)).EndInit();
            this.tbpCadastro.ResumeLayout(false);
            this.tbpCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastro;
        private System.Windows.Forms.TabPage tbpListar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dtgListarPessoas;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}

