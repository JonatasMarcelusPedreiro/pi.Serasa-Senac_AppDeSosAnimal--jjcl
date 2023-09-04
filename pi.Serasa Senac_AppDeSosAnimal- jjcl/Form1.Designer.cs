namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Painel = new WiLBiT.WiLBiTGradientPanel();
            btnlogin = new WiLBiT.WiLBiTButton();
            btncadastrocompleto = new WiLBiT.WiLBiTButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtnome = new WiLBiT.WiLBiTTextBox();
            pictureBox1 = new PictureBox();
            cadastrorapido = new WiLBiT.WiLBiTButton();
            txtcpf = new WiLBiT.WiLBiTTextBox();
            txttelefone = new WiLBiT.WiLBiTTextBox();
            fontInstaller1 = new WiLBiT.FontInstaller(components);
            fontsInstaller1 = new WK.Libraries.FontsInstallerNS.FontsInstaller(components);
            fontInstaller2 = new WiLBiT.FontInstaller(components);
            Painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Painel
            // 
            Painel.BackColor = Color.FromArgb(87, 49, 130);
            Painel.BackColor2 = Color.FromArgb(113, 65, 135);
            Painel.BorderColor = Color.PaleVioletRed;
            Painel.BorderRadius = 6;
            Painel.BorderSize = 0;
            Painel.Controls.Add(btnlogin);
            Painel.Controls.Add(btncadastrocompleto);
            Painel.Controls.Add(label6);
            Painel.Controls.Add(label5);
            Painel.Controls.Add(label4);
            Painel.Controls.Add(label3);
            Painel.Controls.Add(label2);
            Painel.Controls.Add(label1);
            Painel.Controls.Add(txtnome);
            Painel.Controls.Add(pictureBox1);
            Painel.Controls.Add(cadastrorapido);
            Painel.Controls.Add(txtcpf);
            Painel.Controls.Add(txttelefone);
            Painel.ForeColor = Color.DarkOrchid;
            Painel.Location = new Point(-11, -36);
            Painel.Name = "Painel";
            Painel.RightToLeft = RightToLeft.No;
            Painel.Size = new Size(839, 524);
            Painel.TabIndex = 4;
            Painel.Paint += wilBitGradientPanel1_Paint;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Black;
            btnlogin.BorderColor = Color.Black;
            btnlogin.BorderRadius = 15;
            btnlogin.BorderSize = 0;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(486, 397);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(134, 22);
            btnlogin.TabIndex = 12;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btncadastrocompleto
            // 
            btncadastrocompleto.BackColor = Color.Black;
            btncadastrocompleto.BorderColor = Color.Black;
            btncadastrocompleto.BorderRadius = 20;
            btncadastrocompleto.BorderSize = 0;
            btncadastrocompleto.FlatAppearance.BorderSize = 0;
            btncadastrocompleto.FlatStyle = FlatStyle.Flat;
            btncadastrocompleto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btncadastrocompleto.ForeColor = Color.White;
            btncadastrocompleto.Location = new Point(196, 397);
            btncadastrocompleto.Name = "btncadastrocompleto";
            btncadastrocompleto.Size = new Size(144, 22);
            btncadastrocompleto.TabIndex = 11;
            btncadastrocompleto.Text = "CADASTRO COMPLETO";
            btncadastrocompleto.UseVisualStyleBackColor = false;
            btncadastrocompleto.Click += btncadastrocompleto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(229, 357);
            label6.Name = "label6";
            label6.Size = new Size(32, 16);
            label6.TabIndex = 10;
            label6.Text = "TEL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(227, 303);
            label5.Name = "label5";
            label5.Size = new Size(33, 16);
            label5.TabIndex = 9;
            label5.Text = "CPF";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(221, 248);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 8;
            label4.Text = "NOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(314, 86);
            label3.Name = "label3";
            label3.Size = new Size(183, 25);
            label3.TabIndex = 7;
            label3.Text = "ANIMAL RESCUE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(324, 63);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 6;
            label2.Text = "BEM VINDO A ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(335, 215);
            label1.Name = "label1";
            label1.Size = new Size(136, 16);
            label1.TabIndex = 5;
            label1.Text = "CADASTRO RÁPIDO";
            // 
            // txtnome
            // 
            txtnome.BackColor = SystemColors.InfoText;
            txtnome.BorderColor = Color.FromArgb(72, 116, 245);
            txtnome.BorderFocusColor = Color.DeepSkyBlue;
            txtnome.BorderRadius = 20;
            txtnome.BorderSize = 2;
            txtnome.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtnome.ForeColor = Color.White;
            txtnome.Location = new Point(270, 234);
            txtnome.Margin = new Padding(4);
            txtnome.Multiline = false;
            txtnome.Name = "txtnome";
            txtnome.Padding = new Padding(10, 7, 10, 7);
            txtnome.PasswordChar = false;
            txtnome.PlaceholderColor = Color.DarkGray;
            txtnome.PlaceholderText = "";
            txtnome.Size = new Size(250, 29);
            txtnome.TabIndex = 2;
            txtnome.Texts = "";
            txtnome.UnderlinedStyle = false;
            txtnome._TextChanged += txtnome__TextChanged;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::pi.Serasa_Senac_AppDeSosAnimal__jjcl.Properties.Resources.ATXC0623;
            this.pictureBox1.Location = new System.Drawing.Point(286, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cadastrorapido
            // 
            cadastrorapido.BackColor = Color.Black;
            cadastrorapido.BorderColor = Color.Black;
            cadastrorapido.BorderRadius = 15;
            cadastrorapido.BorderSize = 0;
            cadastrorapido.FlatAppearance.BorderSize = 0;
            cadastrorapido.FlatStyle = FlatStyle.Flat;
            cadastrorapido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrorapido.ForeColor = Color.White;
            cadastrorapido.Location = new Point(346, 397);
            cadastrorapido.Name = "cadastrorapido";
            cadastrorapido.Size = new Size(134, 22);
            cadastrorapido.TabIndex = 3;
            cadastrorapido.Text = "CADASTRO RÁPIDO";
            cadastrorapido.UseVisualStyleBackColor = false;
            cadastrorapido.Click += wilBitButton1_Click;
            // 
            // txtcpf
            // 
            txtcpf.BackColor = SystemColors.InfoText;
            txtcpf.BorderColor = Color.FromArgb(72, 116, 245);
            txtcpf.BorderFocusColor = Color.DeepSkyBlue;
            txtcpf.BorderRadius = 20;
            txtcpf.BorderSize = 2;
            txtcpf.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtcpf.ForeColor = Color.White;
            txtcpf.Location = new Point(270, 289);
            txtcpf.Margin = new Padding(4);
            txtcpf.Multiline = false;
            txtcpf.Name = "txtcpf";
            txtcpf.Padding = new Padding(10, 7, 10, 7);
            txtcpf.PasswordChar = false;
            txtcpf.PlaceholderColor = Color.DarkGray;
            txtcpf.PlaceholderText = "";
            txtcpf.Size = new Size(250, 29);
            txtcpf.TabIndex = 1;
            txtcpf.Texts = "";
            txtcpf.UnderlinedStyle = false;
            // 
            // txttelefone
            // 
            txttelefone.BackColor = SystemColors.InfoText;
            txttelefone.BorderColor = Color.FromArgb(72, 116, 245);
            txttelefone.BorderFocusColor = Color.DeepSkyBlue;
            txttelefone.BorderRadius = 20;
            txttelefone.BorderSize = 2;
            txttelefone.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefone.ForeColor = Color.White;
            txttelefone.Location = new Point(270, 343);
            txttelefone.Margin = new Padding(4);
            txttelefone.Multiline = false;
            txttelefone.Name = "txttelefone";
            txttelefone.Padding = new Padding(10, 7, 10, 7);
            txttelefone.PasswordChar = false;
            txttelefone.PlaceholderColor = Color.DarkGray;
            txttelefone.PlaceholderText = "";
            txttelefone.Size = new Size(250, 29);
            txttelefone.TabIndex = 0;
            txttelefone.Texts = "";
            txttelefone.UnderlinedStyle = false;
            // 
            // fontsInstaller1
            // 
            fontsInstaller1.AutoInstall = true;
            fontsInstaller1.AutoRestart = true;
            fontsInstaller1.ContainerControl = this;
            fontsInstaller1.CustomInstallerDialog = null;
            fontsInstaller1.DialogOptions.CollapsedContent = "{Fonts}";
            fontsInstaller1.DialogOptions.Content = "In order for '{AppName}' to look neat and work effectively, {FontsRequiredExpression} to be installed in your system before proceeding. To view {FontsExpression}, click \"See details\".";
            fontsInstaller1.DialogOptions.CustomIcon = null;
            fontsInstaller1.DialogOptions.ShowAppIcon = true;
            fontsInstaller1.DialogOptions.ShowCancelButton = false;
            fontsInstaller1.DialogOptions.Title = "Fonts installation required";
            fontsInstaller1.DialogOptions.UseElevationIcon = false;
            fontsInstaller1.DialogOptions.WindowTitle = "{AppName}";
            fontsInstaller1.FontsListBullet = "+";
            fontsInstaller1.ParentForm = this;
            fontsInstaller1.TestingMode = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Painel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Painel.ResumeLayout(false);
            Painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private WiLBiT.WiLBiTGradientPanel Painel;
        private Label label2;
        private Label label1;
        private WiLBiT.WiLBiTTextBox txtnome;
        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTButton cadastrorapido;
        private WiLBiT.WiLBiTTextBox txtcpf;
        private WiLBiT.WiLBiTTextBox txttelefone;
        private Label label4;
        private Label label3;
        private WiLBiT.WiLBiTButton btncadastrocompleto;
        private Label label6;
        private Label label5;
        private WiLBiT.FontInstaller fontInstaller1;
        private WK.Libraries.FontsInstallerNS.FontsInstaller fontsInstaller1;
        private WiLBiT.FontInstaller fontInstaller2;
        private WiLBiT.WiLBiTButton btnlogin;
    }
}