namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    partial class Form2
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
            lblcadastradosadm = new Label();
            txtnomeFuncionario = new TextBox();
            btncadastrarfuncionarios = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblnome = new Label();
            txttelcdfuncionario = new TextBox();
            txtsenhacdfuncionario = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblcadastradosadm
            // 
            lblcadastradosadm.AutoSize = true;
            lblcadastradosadm.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblcadastradosadm.Location = new Point(193, 9);
            lblcadastradosadm.Name = "lblcadastradosadm";
            lblcadastradosadm.Size = new Size(397, 50);
            lblcadastradosadm.TabIndex = 2;
            lblcadastradosadm.Text = "Cadastrar Funcionários";
            // 
            // txtnomeFuncionario
            // 
            txtnomeFuncionario.Location = new Point(69, 46);
            txtnomeFuncionario.Name = "txtnomeFuncionario";
            txtnomeFuncionario.Size = new Size(201, 23);
            txtnomeFuncionario.TabIndex = 0;
            // 
            // btncadastrarfuncionarios
            // 
            btncadastrarfuncionarios.Location = new Point(136, 198);
            btncadastrarfuncionarios.Name = "btncadastrarfuncionarios";
            btncadastrarfuncionarios.Size = new Size(75, 23);
            btncadastrarfuncionarios.TabIndex = 1;
            btncadastrarfuncionarios.Text = "Cadastrar";
            btncadastrarfuncionarios.UseVisualStyleBackColor = true;
            btncadastrarfuncionarios.Click += btncadastrarfuncionarios_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblnome);
            panel1.Controls.Add(txttelcdfuncionario);
            panel1.Controls.Add(txtsenhacdfuncionario);
            panel1.Controls.Add(btncadastrarfuncionarios);
            panel1.Controls.Add(txtnomeFuncionario);
            panel1.Location = new Point(25, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 331);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(33, 166);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "tel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(24, 105);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Senha";
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.ForeColor = SystemColors.ControlLightLight;
            lblnome.Location = new Point(23, 49);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 4;
            lblnome.Text = "Nome";
            // 
            // txttelcdfuncionario
            // 
            txttelcdfuncionario.Location = new Point(69, 158);
            txttelcdfuncionario.Name = "txttelcdfuncionario";
            txttelcdfuncionario.Size = new Size(201, 23);
            txttelcdfuncionario.TabIndex = 3;
            // 
            // txtsenhacdfuncionario
            // 
            txtsenhacdfuncionario.Location = new Point(69, 97);
            txtsenhacdfuncionario.Name = "txtsenhacdfuncionario";
            txtsenhacdfuncionario.Size = new Size(201, 23);
            txtsenhacdfuncionario.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(412, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(328, 331);
            dataGridView1.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(lblcadastradosadm);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblcadastradosadm;
        private Button btncadastrarfuncionarios;
        private TextBox txtnomeFuncionario;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label lblnome;
        private TextBox txttelcdfuncionario;
        private TextBox txtsenhacdfuncionario;
        private DataGridView dataGridView1;
    }
}