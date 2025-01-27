namespace BibliotecaPaper
{
    partial class CadastroLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivro));
            textTitulo_livro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textEdicao_livro = new TextBox();
            label3 = new Label();
            textNome_autor = new TextBox();
            label4 = new Label();
            textData_publicacao = new TextBox();
            label5 = new Label();
            textISBN = new TextBox();
            label6 = new Label();
            textAssunto = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // textTitulo_livro
            // 
            textTitulo_livro.Location = new Point(12, 45);
            textTitulo_livro.Name = "textTitulo_livro";
            textTitulo_livro.Size = new Size(172, 23);
            textTitulo_livro.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Titulo livro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Edição";
            // 
            // textEdicao_livro
            // 
            textEdicao_livro.Location = new Point(12, 107);
            textEdicao_livro.Name = "textEdicao_livro";
            textEdicao_livro.Size = new Size(118, 23);
            textEdicao_livro.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 89);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 5;
            label3.Text = "Codigo Autor";
            // 
            // textNome_autor
            // 
            textNome_autor.Location = new Point(214, 107);
            textNome_autor.Name = "textNome_autor";
            textNome_autor.Size = new Size(78, 23);
            textNome_autor.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 7;
            label4.Text = "Data da Publicação";
            // 
            // textData_publicacao
            // 
            textData_publicacao.Location = new Point(12, 165);
            textData_publicacao.Name = "textData_publicacao";
            textData_publicacao.Size = new Size(100, 23);
            textData_publicacao.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 147);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "ISBN";
            // 
            // textISBN
            // 
            textISBN.Location = new Point(214, 165);
            textISBN.Name = "textISBN";
            textISBN.Size = new Size(174, 23);
            textISBN.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(214, 27);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 11;
            label6.Text = "Assunto";
            // 
            // textAssunto
            // 
            textAssunto.Location = new Point(214, 45);
            textAssunto.Name = "textAssunto";
            textAssunto.Size = new Size(174, 23);
            textAssunto.TabIndex = 10;
            // 
            // btnNovo
            // 
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.Location = new Point(45, 285);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 70);
            btnNovo.TabIndex = 13;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(126, 285);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 70);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(214, 285);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 70);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.Location = new Point(298, 285);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(90, 70);
            btnFechar.TabIndex = 16;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // CadastroLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 357);
            Controls.Add(btnFechar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(label6);
            Controls.Add(textAssunto);
            Controls.Add(label5);
            Controls.Add(textISBN);
            Controls.Add(label4);
            Controls.Add(textData_publicacao);
            Controls.Add(label3);
            Controls.Add(textNome_autor);
            Controls.Add(label2);
            Controls.Add(textEdicao_livro);
            Controls.Add(label1);
            Controls.Add(textTitulo_livro);
            DoubleBuffered = true;
            Name = "CadastroLivro";
            Text = "Cadastro de Livro";
            Load += CadastroLivro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTitulo_livro;
        private Label label1;
        private Label label2;
        private TextBox textEdicao_livro;
        private Label label3;
        private TextBox textNome_autor;
        private Label label4;
        private TextBox textData_publicacao;
        private Label label5;
        private TextBox textISBN;
        private Label label6;
        private TextBox textAssunto;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnFechar;
    }
}