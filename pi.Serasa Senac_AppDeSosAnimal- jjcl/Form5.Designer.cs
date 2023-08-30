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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cadastrorapido = new WiLBiT.WiLBiTButton();
            this.txtnome = new WiLBiT.WiLBiTTextBox();
            this.panel1.SuspendLayout();
            this.wilBitGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.wilBitGradientPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cadastrorapido);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Location = new System.Drawing.Point(-51, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 450);
            this.panel1.TabIndex = 0;
            // 
            // wilBitGradientPanel1
            // 
            this.wilBitGradientPanel1.BackColor = System.Drawing.Color.Indigo;
            this.wilBitGradientPanel1.BackColor2 = System.Drawing.Color.DarkViolet;
            this.wilBitGradientPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitGradientPanel1.BorderRadius = 6;
            this.wilBitGradientPanel1.BorderSize = 0;
            this.wilBitGradientPanel1.Controls.Add(this.label3);
            this.wilBitGradientPanel1.Controls.Add(this.pictureBox1);
            this.wilBitGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitGradientPanel1.Location = new System.Drawing.Point(-22, 0);
            this.wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            this.wilBitGradientPanel1.Size = new System.Drawing.Size(890, 136);
            this.wilBitGradientPanel1.TabIndex = 17;
            this.wilBitGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.wilBitGradientPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(345, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "ANIMAL RESCUE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::pi.Serasa_Senac_AppDeSosAnimal__jjcl.Properties.Resources.ATXC0623;
            this.pictureBox1.Location = new System.Drawing.Point(484, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(359, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "DOAÇÃO VIA PIX";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cadastrorapido
            // 
            this.cadastrorapido.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cadastrorapido.BorderColor = System.Drawing.Color.Black;
            this.cadastrorapido.BorderRadius = 15;
            this.cadastrorapido.BorderSize = 0;
            this.cadastrorapido.FlatAppearance.BorderSize = 0;
            this.cadastrorapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrorapido.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastrorapido.ForeColor = System.Drawing.Color.White;
            this.cadastrorapido.Location = new System.Drawing.Point(320, 262);
            this.cadastrorapido.Name = "cadastrorapido";
            this.cadastrorapido.Size = new System.Drawing.Size(251, 27);
            this.cadastrorapido.TabIndex = 4;
            this.cadastrorapido.Text = "ENVIAR";
            this.cadastrorapido.UseVisualStyleBackColor = false;
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.txtnome.BorderFocusColor = System.Drawing.Color.DeepSkyBlue;
            this.txtnome.BorderRadius = 20;
            this.txtnome.BorderSize = 2;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(320, 212);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Multiline = false;
            this.txtnome.Name = "txtnome";
            this.txtnome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnome.PasswordChar = false;
            this.txtnome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtnome.PlaceholderText = "";
            this.txtnome.Size = new System.Drawing.Size(250, 29);
            this.txtnome.TabIndex = 3;
            this.txtnome.Texts = "";
            this.txtnome.UnderlinedStyle = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.wilBitGradientPanel1.ResumeLayout(false);
            this.wilBitGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private WiLBiT.WiLBiTTextBox txtnome;
        private WiLBiT.WiLBiTButton cadastrorapido;
        private Label label2;
        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}