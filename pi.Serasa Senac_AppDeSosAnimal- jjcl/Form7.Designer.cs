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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblsenhaadm = new System.Windows.Forms.Label();
            this.lblnomeadm = new System.Windows.Forms.Label();
            this.txtsenhaadm = new System.Windows.Forms.TextBox();
            this.txtnomeadm = new System.Windows.Forms.TextBox();
            this.btnadmentrar = new System.Windows.Forms.Button();
            this.lbllistacadastrados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblsenhaadm);
            this.panel1.Controls.Add(this.lblnomeadm);
            this.panel1.Controls.Add(this.txtsenhaadm);
            this.panel1.Controls.Add(this.txtnomeadm);
            this.panel1.Controls.Add(this.btnadmentrar);
            this.panel1.Controls.Add(this.lbllistacadastrados);
            this.panel1.Location = new System.Drawing.Point(-9, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 471);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Login funcionário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsenhaadm
            // 
            this.lblsenhaadm.AutoSize = true;
            this.lblsenhaadm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsenhaadm.Location = new System.Drawing.Point(226, 232);
            this.lblsenhaadm.Name = "lblsenhaadm";
            this.lblsenhaadm.Size = new System.Drawing.Size(39, 15);
            this.lblsenhaadm.TabIndex = 6;
            this.lblsenhaadm.Text = "Senha";
            // 
            // lblnomeadm
            // 
            this.lblnomeadm.AutoSize = true;
            this.lblnomeadm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnomeadm.Location = new System.Drawing.Point(226, 173);
            this.lblnomeadm.Name = "lblnomeadm";
            this.lblnomeadm.Size = new System.Drawing.Size(40, 15);
            this.lblnomeadm.TabIndex = 5;
            this.lblnomeadm.Text = "Nome";
            // 
            // txtsenhaadm
            // 
            this.txtsenhaadm.Location = new System.Drawing.Point(272, 224);
            this.txtsenhaadm.Name = "txtsenhaadm";
            this.txtsenhaadm.Size = new System.Drawing.Size(295, 23);
            this.txtsenhaadm.TabIndex = 4;
            // 
            // txtnomeadm
            // 
            this.txtnomeadm.Location = new System.Drawing.Point(272, 165);
            this.txtnomeadm.Name = "txtnomeadm";
            this.txtnomeadm.Size = new System.Drawing.Size(295, 23);
            this.txtnomeadm.TabIndex = 3;
            // 
            // btnadmentrar
            // 
            this.btnadmentrar.Location = new System.Drawing.Point(383, 276);
            this.btnadmentrar.Name = "btnadmentrar";
            this.btnadmentrar.Size = new System.Drawing.Size(75, 23);
            this.btnadmentrar.TabIndex = 2;
            this.btnadmentrar.Text = "Entrar";
            this.btnadmentrar.UseVisualStyleBackColor = true;
            this.btnadmentrar.Click += new System.EventHandler(this.btnadmentrar_Click);
            // 
            // lbllistacadastrados
            // 
            this.lbllistacadastrados.AutoSize = true;
            this.lbllistacadastrados.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllistacadastrados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbllistacadastrados.Location = new System.Drawing.Point(348, 56);
            this.lbllistacadastrados.Name = "lbllistacadastrados";
            this.lbllistacadastrados.Size = new System.Drawing.Size(130, 47);
            this.lbllistacadastrados.TabIndex = 1;
            this.lbllistacadastrados.Text = "LOGIN ";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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