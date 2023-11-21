namespace WindowsFormsApp
{
    partial class Frm_HelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.Btm_Sair = new System.Windows.Forms.Button();
            this.Btm_ModicaLabel = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(30, 30);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(213, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .NET Version";
            this.lbl_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btm_Sair
            // 
            this.Btm_Sair.Location = new System.Drawing.Point(506, 416);
            this.Btm_Sair.Name = "Btm_Sair";
            this.Btm_Sair.Size = new System.Drawing.Size(168, 22);
            this.Btm_Sair.TabIndex = 1;
            this.Btm_Sair.Text = "Fechar a Aplicação";
            this.Btm_Sair.UseVisualStyleBackColor = true;
            this.Btm_Sair.Click += new System.EventHandler(this.Btm_Sair_Click);
            // 
            // Btm_ModicaLabel
            // 
            this.Btm_ModicaLabel.Location = new System.Drawing.Point(34, 52);
            this.Btm_ModicaLabel.Name = "Btm_ModicaLabel";
            this.Btm_ModicaLabel.Size = new System.Drawing.Size(209, 23);
            this.Btm_ModicaLabel.TabIndex = 2;
            this.Btm_ModicaLabel.Text = "Modifica Texto do Label";
            this.Btm_ModicaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btm_ModicaLabel.UseVisualStyleBackColor = true;
            this.Btm_ModicaLabel.Click += new System.EventHandler(this.Btm_ModicaLabel_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(34, 81);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(338, 20);
            this.Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btm_ModicaLabel);
            this.Controls.Add(this.Btm_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.HelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button Btm_Sair;
        private System.Windows.Forms.Button Btm_ModicaLabel;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
    }
}

