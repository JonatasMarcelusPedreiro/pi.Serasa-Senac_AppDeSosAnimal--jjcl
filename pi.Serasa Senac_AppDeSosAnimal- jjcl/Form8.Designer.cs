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
            panel1 = new Panel();
            wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            painelANIMAL = new Panel();
            panel1.SuspendLayout();
            wilBitGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(painelANIMAL);
            panel1.Controls.Add(wilBitGradientPanel1);
            panel1.Location = new Point(0, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(1912, 1050);
            panel1.TabIndex = 0;
            // 
            // wilBitGradientPanel1
            // 
            wilBitGradientPanel1.BackColor = Color.Indigo;
            wilBitGradientPanel1.BackColor2 = Color.DarkViolet;
            wilBitGradientPanel1.BorderColor = Color.PaleVioletRed;
            wilBitGradientPanel1.BorderRadius = 6;
            wilBitGradientPanel1.BorderSize = 0;
            wilBitGradientPanel1.Controls.Add(label3);
            wilBitGradientPanel1.Controls.Add(pictureBox1);
            wilBitGradientPanel1.ForeColor = Color.White;
            wilBitGradientPanel1.Location = new Point(-48, 3);
            wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            wilBitGradientPanel1.Size = new Size(2009, 157);
            wilBitGradientPanel1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(788, 80);
            label3.Name = "label3";
            label3.Size = new Size(236, 31);
            label3.TabIndex = 7;
            label3.Text = "ANIMAL RESCUE";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = Properties.Resources.ATXC0623;
            pictureBox1.Location = new Point(947, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // painelANIMAL
            // 
            painelANIMAL.Location = new Point(3, 166);
            painelANIMAL.Name = "painelANIMAL";
            painelANIMAL.Size = new Size(1373, 594);
            painelANIMAL.TabIndex = 8;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            panel1.ResumeLayout(false);
            wilBitGradientPanel1.ResumeLayout(false);
            wilBitGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel painelANIMAL;
    }
}