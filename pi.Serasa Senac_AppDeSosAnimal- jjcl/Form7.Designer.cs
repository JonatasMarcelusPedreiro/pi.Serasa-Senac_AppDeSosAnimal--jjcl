namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    partial class Form7
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
            button1 = new Button();
            lblsenhaadm = new Label();
            lblnomeadm = new Label();
            txtsenhaadm = new TextBox();
            txtnomeadm = new TextBox();
            btnadmentrar = new Button();
            lbllistacadastrados = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblsenhaadm);
            panel1.Controls.Add(lblnomeadm);
            panel1.Controls.Add(txtsenhaadm);
            panel1.Controls.Add(txtnomeadm);
            panel1.Controls.Add(btnadmentrar);
            panel1.Controls.Add(lbllistacadastrados);
            panel1.Location = new Point(-9, -24);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 471);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(372, 317);
            button1.Name = "button1";
            button1.Size = new Size(106, 49);
            button1.TabIndex = 7;
            button1.Text = "Login funcionário";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblsenhaadm
            // 
            lblsenhaadm.AutoSize = true;
            lblsenhaadm.ForeColor = SystemColors.ControlLightLight;
            lblsenhaadm.Location = new Point(226, 232);
            lblsenhaadm.Name = "lblsenhaadm";
            lblsenhaadm.Size = new Size(39, 15);
            lblsenhaadm.TabIndex = 6;
            lblsenhaadm.Text = "Senha";
            // 
            // lblnomeadm
            // 
            lblnomeadm.AutoSize = true;
            lblnomeadm.ForeColor = SystemColors.ControlLightLight;
            lblnomeadm.Location = new Point(226, 173);
            lblnomeadm.Name = "lblnomeadm";
            lblnomeadm.Size = new Size(40, 15);
            lblnomeadm.TabIndex = 5;
            lblnomeadm.Text = "Nome";
            // 
            // txtsenhaadm
            // 
            txtsenhaadm.Location = new Point(272, 224);
            txtsenhaadm.Name = "txtsenhaadm";
            txtsenhaadm.Size = new Size(295, 23);
            txtsenhaadm.TabIndex = 4;
            // 
            // txtnomeadm
            // 
            txtnomeadm.Location = new Point(272, 165);
            txtnomeadm.Name = "txtnomeadm";
            txtnomeadm.Size = new Size(295, 23);
            txtnomeadm.TabIndex = 3;
            // 
            // btnadmentrar
            // 
            btnadmentrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnadmentrar.Location = new Point(372, 262);
            btnadmentrar.Name = "btnadmentrar";
            btnadmentrar.Size = new Size(106, 49);
            btnadmentrar.TabIndex = 2;
            btnadmentrar.Text = "Login ADM";
            btnadmentrar.UseVisualStyleBackColor = true;
            btnadmentrar.Click += btnadmentrar_Click;
            // 
            // lbllistacadastrados
            // 
            lbllistacadastrados.AutoSize = true;
            lbllistacadastrados.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbllistacadastrados.ForeColor = SystemColors.ControlLightLight;
            lbllistacadastrados.Location = new Point(348, 56);
            lbllistacadastrados.Name = "lbllistacadastrados";
            lbllistacadastrados.Size = new Size(130, 47);
            lbllistacadastrados.TabIndex = 1;
            lbllistacadastrados.Text = "LOGIN ";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form7";
            Text = "Form7";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbllistacadastrados;
        private TextBox txtsenhaadm;
        private TextBox txtnomeadm;
        private Button btnadmentrar;
        private Label lblnomeadm;
        private Label lblsenhaadm;
        private Button button1;
    }
}