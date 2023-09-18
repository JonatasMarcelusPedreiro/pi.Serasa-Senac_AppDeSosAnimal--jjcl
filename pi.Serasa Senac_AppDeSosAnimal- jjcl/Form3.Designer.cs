namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Painel3 = new WiLBiT.WiLBiTGradientPanel();
            btnlogin = new WiLBiT.WiLBiTButton();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            TXTnome = new WiLBiT.WiLBiTTextBox();
            pictureBox1 = new PictureBox();
            TXTsenha = new WiLBiT.WiLBiTTextBox();
            Painel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Painel3
            // 
            Painel3.AutoSize = true;
            Painel3.BackColor = Color.FromArgb(87, 49, 130);
            Painel3.BackColor2 = Color.FromArgb(113, 65, 135);
            Painel3.BorderColor = Color.PaleVioletRed;
            Painel3.BorderRadius = 6;
            Painel3.BorderSize = 0;
            Painel3.Controls.Add(btnlogin);
            Painel3.Controls.Add(label6);
            Painel3.Controls.Add(label4);
            Painel3.Controls.Add(label1);
            Painel3.Controls.Add(TXTnome);
            Painel3.Controls.Add(pictureBox1);
            Painel3.Controls.Add(TXTsenha);
            Painel3.Dock = DockStyle.Fill;
            Painel3.ForeColor = Color.DarkOrchid;
            Painel3.Location = new Point(0, 0);
            Painel3.Name = "Painel3";
            Painel3.Size = new Size(1370, 749);
            Painel3.TabIndex = 5;
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
            btnlogin.Location = new Point(874, 620);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(343, 35);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "LOGAR";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Gainsboro;
            label6.Location = new Point(700, 550);
            label6.Name = "label6";
            label6.Size = new Size(54, 16);
            label6.TabIndex = 10;
            label6.Text = "SENHA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(704, 461);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 8;
            label4.Text = "NOME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(1021, 428);
            label1.Name = "label1";
            label1.Size = new Size(47, 16);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            // 
            // TXTnome
            // 
            TXTnome.BackColor = SystemColors.Desktop;
            TXTnome.BorderColor = Color.FromArgb(72, 116, 245);
            TXTnome.BorderFocusColor = Color.DeepSkyBlue;
            TXTnome.BorderRadius = 20;
            TXTnome.BorderSize = 2;
            TXTnome.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TXTnome.ForeColor = Color.Transparent;
            TXTnome.Location = new Point(753, 447);
            TXTnome.Margin = new Padding(4);
            TXTnome.Multiline = false;
            TXTnome.Name = "TXTnome";
            TXTnome.Padding = new Padding(10, 7, 10, 7);
            TXTnome.PasswordChar = false;
            TXTnome.PlaceholderColor = Color.DarkGray;
            TXTnome.PlaceholderText = "";
            TXTnome.Size = new Size(567, 29);
            TXTnome.TabIndex = 0;
            TXTnome.Texts = "leo";
            TXTnome.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = Properties.Resources.ATXC0623;
            pictureBox1.Location = new Point(931, 302);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TXTsenha
            // 
            TXTsenha.BackColor = SystemColors.InfoText;
            TXTsenha.BorderColor = Color.FromArgb(72, 116, 245);
            TXTsenha.BorderFocusColor = Color.DeepSkyBlue;
            TXTsenha.BorderRadius = 20;
            TXTsenha.BorderSize = 2;
            TXTsenha.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TXTsenha.ForeColor = Color.White;
            TXTsenha.Location = new Point(753, 536);
            TXTsenha.Margin = new Padding(4);
            TXTsenha.Multiline = false;
            TXTsenha.Name = "TXTsenha";
            TXTsenha.Padding = new Padding(10, 7, 10, 7);
            TXTsenha.PasswordChar = true;
            TXTsenha.PlaceholderColor = Color.DarkGray;
            TXTsenha.PlaceholderText = "";
            TXTsenha.Size = new Size(563, 29);
            TXTsenha.TabIndex = 1;
            TXTsenha.Texts = "leo";
            TXTsenha.UnderlinedStyle = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(Painel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            Text = "Form3";
            Painel3.ResumeLayout(false);
            Painel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WiLBiT.WiLBiTGradientPanel Painel3;
        private WiLBiT.WiLBiTButton btnlogin;
        private Label label6;
        private Label label4;
        private Label label1;
        private WiLBiT.WiLBiTTextBox TXTnome;
        private PictureBox pictureBox1;
        private WiLBiT.WiLBiTTextBox TXTsenha;
    }
}