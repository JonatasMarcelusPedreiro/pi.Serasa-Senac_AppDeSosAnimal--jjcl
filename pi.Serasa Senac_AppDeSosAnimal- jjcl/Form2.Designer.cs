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
            this.lblcadastradosadm.AutoSize = true;
            this.lblcadastradosadm.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcadastradosadm.Location = new System.Drawing.Point(193, 9);
            this.lblcadastradosadm.Name = "lblcadastradosadm";
            this.lblcadastradosadm.Size = new System.Drawing.Size(397, 50);
            this.lblcadastradosadm.TabIndex = 2;
            this.lblcadastradosadm.Text = "Cadastrar Funcionários";
            // 
            // txtnomeFuncionario
            // 
            this.txtnomeFuncionario.Location = new System.Drawing.Point(69, 46);
            this.txtnomeFuncionario.Name = "txtnomeFuncionario";
            this.txtnomeFuncionario.Size = new System.Drawing.Size(201, 23);
            this.txtnomeFuncionario.TabIndex = 0;
            // 
            // btncadastrarfuncionarios
            // 
            this.btncadastrarfuncionarios.Location = new System.Drawing.Point(136, 198);
            this.btncadastrarfuncionarios.Name = "btncadastrarfuncionarios";
            this.btncadastrarfuncionarios.Size = new System.Drawing.Size(75, 23);
            this.btncadastrarfuncionarios.TabIndex = 1;
            this.btncadastrarfuncionarios.Text = "Cadastrar";
            this.btncadastrarfuncionarios.UseVisualStyleBackColor = true;
            this.btncadastrarfuncionarios.Click += new System.EventHandler(this.btncadastrarfuncionarios_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.txttelcdfuncionario);
            this.panel1.Controls.Add(this.txtsenhacdfuncionario);
            this.panel1.Controls.Add(this.btncadastrarfuncionarios);
            this.panel1.Controls.Add(this.txtnomeFuncionario);
            this.panel1.Location = new System.Drawing.Point(25, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 331);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "tel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Senha";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnome.Location = new System.Drawing.Point(23, 49);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(40, 15);
            this.lblnome.TabIndex = 4;
            this.lblnome.Text = "Nome";
            // 
            // txttelcdfuncionario
            // 
            this.txttelcdfuncionario.Location = new System.Drawing.Point(69, 158);
            this.txttelcdfuncionario.Name = "txttelcdfuncionario";
            this.txttelcdfuncionario.Size = new System.Drawing.Size(201, 23);
            this.txttelcdfuncionario.TabIndex = 3;
            // 
            // txtsenhacdfuncionario
            // 
            this.txtsenhacdfuncionario.Location = new System.Drawing.Point(69, 97);
            this.txtsenhacdfuncionario.Name = "txtsenhacdfuncionario";
            this.txtsenhacdfuncionario.Size = new System.Drawing.Size(201, 23);
            this.txtsenhacdfuncionario.TabIndex = 2;
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