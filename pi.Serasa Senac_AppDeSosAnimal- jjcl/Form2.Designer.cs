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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PainelAnimais = new System.Windows.Forms.Panel();
            this.wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PainelAnimais.SuspendLayout();
            this.wilBitGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelAnimais
            // 
            this.PainelAnimais.AutoScroll = true;
            this.PainelAnimais.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PainelAnimais.Controls.Add(this.wilBitGradientPanel1);
            this.PainelAnimais.Location = new System.Drawing.Point(-20, -1);
            this.PainelAnimais.Name = "PainelAnimais";
            this.PainelAnimais.Size = new System.Drawing.Size(823, 474);
            this.PainelAnimais.TabIndex = 1;
            // 
            // wilBitGradientPanel1
            // 
            this.wilBitGradientPanel1.BackColor = System.Drawing.Color.Indigo;
            this.wilBitGradientPanel1.BackColor2 = System.Drawing.Color.DarkViolet;
            this.wilBitGradientPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitGradientPanel1.BorderRadius = 6;
            this.wilBitGradientPanel1.BorderSize = 0;
            this.wilBitGradientPanel1.Controls.Add(this.pictureBox1);
            this.wilBitGradientPanel1.Controls.Add(this.label3);
            this.wilBitGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitGradientPanel1.Location = new System.Drawing.Point(-36, 0);
            this.wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            this.wilBitGradientPanel1.Size = new System.Drawing.Size(894, 119);
            this.wilBitGradientPanel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::pi.Serasa_Senac_AppDeSosAnimal__jjcl.Properties.Resources.ATXC0623;
            this.pictureBox1.Location = new System.Drawing.Point(766, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(329, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "ANIMAIS RESGATADOS";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PainelAnimais);
            this.Name = "Form2";
            this.Text = "Form2";
            this.PainelAnimais.ResumeLayout(false);
            this.wilBitGradientPanel1.ResumeLayout(false);
            this.wilBitGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel PainelAnimais;
        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}