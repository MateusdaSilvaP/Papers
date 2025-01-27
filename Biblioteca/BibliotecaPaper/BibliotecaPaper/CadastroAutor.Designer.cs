namespace BibliotecaPaper
{
    partial class CadastrarAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAutor));
            label1 = new Label();
            textBox1 = new TextBox();
            btnFechar = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 68);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Autor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.Location = new Point(263, 290);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(90, 70);
            btnFechar.TabIndex = 20;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(179, 290);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 70);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(91, 290);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 70);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.Location = new Point(10, 290);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 70);
            btnNovo.TabIndex = 17;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 

            // CadastrarAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 361);

            Controls.Add(btnFechar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CadastrarAutor";
            Text = "Cadastro Autor";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnFechar;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnNovo;

    }
}