namespace FormsExercicio7
{
    partial class frmConversorDeDolarParaReal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCotacao = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.txtCotacao = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(279, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor de dólar para real";
            // 
            // lblCotacao
            // 
            this.lblCotacao.AutoSize = true;
            this.lblCotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotacao.Location = new System.Drawing.Point(193, 110);
            this.lblCotacao.Name = "lblCotacao";
            this.lblCotacao.Size = new System.Drawing.Size(130, 20);
            this.lblCotacao.TabIndex = 1;
            this.lblCotacao.Text = "Cotação do dolar";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(193, 144);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(111, 20);
            this.lblDolar.TabIndex = 2;
            this.lblDolar.Text = "Valor em dolar";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(193, 176);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(330, 176);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(51, 20);
            this.lblReal.TabIndex = 4;
            this.lblReal.Text = "label5";
            // 
            // txtCotacao
            // 
            this.txtCotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotacao.Location = new System.Drawing.Point(334, 110);
            this.txtCotacao.Name = "txtCotacao";
            this.txtCotacao.Size = new System.Drawing.Size(268, 26);
            this.txtCotacao.TabIndex = 5;
            // 
            // txtDolar
            // 
            this.txtDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.Location = new System.Drawing.Point(334, 142);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(268, 26);
            this.txtDolar.TabIndex = 6;
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(367, 241);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(92, 36);
            this.btnConverter.TabIndex = 7;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.clickou_converter);
            // 
            // frmConversorDeDolarParaReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtCotacao);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblCotacao);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmConversorDeDolarParaReal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCotacao;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.TextBox txtCotacao;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Button btnConverter;
    }
}

