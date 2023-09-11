namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    partial class Form5
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblnome = new Label();
            txtsexoanimal = new TextBox();
            txtSITUACAO = new TextBox();
            btncadastrarfuncionarios = new Button();
            txtAnimal = new TextBox();
            lblcadastroanimais = new Label();
            btnImagem = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(btnImagem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblnome);
            panel1.Controls.Add(txtsexoanimal);
            panel1.Controls.Add(txtSITUACAO);
            panel1.Controls.Add(btncadastrarfuncionarios);
            panel1.Controls.Add(txtAnimal);
            panel1.Location = new Point(240, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 331);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(31, 153);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "Sexo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(16, 105);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 5;
            label1.Text = "Situação";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.ForeColor = SystemColors.ControlLightLight;
            lblnome.Location = new Point(23, 49);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(45, 15);
            lblnome.TabIndex = 4;
            lblnome.Text = "Animal";
            // 
            // txtsexoanimal
            // 
            txtsexoanimal.Location = new Point(69, 150);
            txtsexoanimal.Name = "txtsexoanimal";
            txtsexoanimal.Size = new Size(201, 23);
            txtsexoanimal.TabIndex = 3;
            // 
            // txtSITUACAO
            // 
            txtSITUACAO.Location = new Point(69, 97);
            txtSITUACAO.Name = "txtSITUACAO";
            txtSITUACAO.Size = new Size(201, 23);
            txtSITUACAO.TabIndex = 2;
            // 
            // btncadastrarfuncionarios
            // 
            btncadastrarfuncionarios.Location = new Point(181, 190);
            btncadastrarfuncionarios.Name = "btncadastrarfuncionarios";
            btncadastrarfuncionarios.Size = new Size(75, 23);
            btncadastrarfuncionarios.TabIndex = 1;
            btncadastrarfuncionarios.Text = "Cadastrar";
            btncadastrarfuncionarios.UseVisualStyleBackColor = true;
            btncadastrarfuncionarios.Click += btncadastrarfuncionarios_Click;
            // 
            // txtAnimal
            // 
            txtAnimal.Location = new Point(69, 46);
            txtAnimal.Name = "txtAnimal";
            txtAnimal.Size = new Size(201, 23);
            txtAnimal.TabIndex = 0;
            // 
            // lblcadastroanimais
            // 
            lblcadastroanimais.AutoSize = true;
            lblcadastroanimais.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblcadastroanimais.ForeColor = SystemColors.ControlLightLight;
            lblcadastroanimais.Location = new Point(243, 9);
            lblcadastroanimais.Name = "lblcadastroanimais";
            lblcadastroanimais.Size = new Size(319, 50);
            lblcadastroanimais.TabIndex = 7;
            lblcadastroanimais.Text = "Cadastrar Animais";
            // 
            // btnImagem
            // 
            btnImagem.Location = new Point(54, 190);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(75, 23);
            btnImagem.TabIndex = 7;
            btnImagem.Text = "Imagem";
            btnImagem.UseVisualStyleBackColor = true;
            btnImagem.Click += btnImagem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(lblcadastroanimais);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label lblnome;
        private TextBox txtsexoanimal;
        private TextBox txtSITUACAO;
        private Button btncadastrarfuncionarios;
        private TextBox txtAnimal;
        private Label lblcadastroanimais;
        private Button btnImagem;
        private OpenFileDialog openFileDialog1;
    }
}