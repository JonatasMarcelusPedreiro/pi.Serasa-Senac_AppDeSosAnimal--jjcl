namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    partial class InfoAnimais
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
            this.pbInfoAnimais = new System.Windows.Forms.PictureBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfoAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInfoAnimais
            // 
            this.pbInfoAnimais.Location = new System.Drawing.Point(40, 23);
            this.pbInfoAnimais.Name = "pbInfoAnimais";
            this.pbInfoAnimais.Size = new System.Drawing.Size(295, 217);
            this.pbInfoAnimais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInfoAnimais.TabIndex = 0;
            this.pbInfoAnimais.TabStop = false;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnimal.Location = new System.Drawing.Point(40, 262);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(73, 25);
            this.lblAnimal.TabIndex = 1;
            this.lblAnimal.Text = "Animal";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSituacao.Location = new System.Drawing.Point(40, 315);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(85, 25);
            this.lblSituacao.TabIndex = 2;
            this.lblSituacao.Text = "Situação";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(40, 367);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(53, 25);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // InfoAnimais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.pbInfoAnimais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoAnimais";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.pbInfoAnimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbInfoAnimais;
        private Label lblAnimal;
        private Label lblSituacao;
        private Label lblSexo;
    }
}