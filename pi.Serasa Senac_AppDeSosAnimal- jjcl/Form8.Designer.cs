namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.panel1 = new System.Windows.Forms.Panel();
            this.painelANIMAL = new System.Windows.Forms.Panel();
            this.wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.wilBitGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.painelANIMAL);
            this.panel1.Controls.Add(this.wilBitGradientPanel1);
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1912, 1050);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // painelANIMAL
            // 
            this.painelANIMAL.AutoScroll = true;
            this.painelANIMAL.Location = new System.Drawing.Point(3, 154);
            this.painelANIMAL.Name = "painelANIMAL";
            this.painelANIMAL.Size = new System.Drawing.Size(1909, 602);
            this.painelANIMAL.TabIndex = 8;
            this.painelANIMAL.Paint += new System.Windows.Forms.PaintEventHandler(this.painelANIMAL_Paint);
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
            this.wilBitGradientPanel1.Location = new System.Drawing.Point(-48, 3);
            this.wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            this.wilBitGradientPanel1.Size = new System.Drawing.Size(2009, 157);
            this.wilBitGradientPanel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(788, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "ANIMAL RESCUE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::pi.Serasa_Senac_AppDeSosAnimal__jjcl.Properties.Resources.ATXC0623;
            this.pictureBox1.Location = new System.Drawing.Point(947, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load_1);
            this.panel1.ResumeLayout(false);
            this.wilBitGradientPanel1.ResumeLayout(false);
            this.wilBitGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel painelANIMAL;
    }
}