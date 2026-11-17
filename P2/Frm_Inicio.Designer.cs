namespace P2
{
    partial class Frm_Carregamento
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
            this.lbl_percentual = new System.Windows.Forms.Label();
            this.PB_carga = new System.Windows.Forms.ProgressBar();
            this.lbl_etapa = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_percentual
            // 
            this.lbl_percentual.AutoSize = true;
            this.lbl_percentual.Location = new System.Drawing.Point(229, 74);
            this.lbl_percentual.Name = "lbl_percentual";
            this.lbl_percentual.Size = new System.Drawing.Size(26, 16);
            this.lbl_percentual.TabIndex = 5;
            this.lbl_percentual.Text = "0%";
            // 
            // PB_carga
            // 
            this.PB_carga.Location = new System.Drawing.Point(12, 103);
            this.PB_carga.Name = "PB_carga";
            this.PB_carga.Size = new System.Drawing.Size(458, 30);
            this.PB_carga.TabIndex = 3;
            // 
            // lbl_etapa
            // 
            this.lbl_etapa.AutoSize = true;
            this.lbl_etapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etapa.Location = new System.Drawing.Point(151, 33);
            this.lbl_etapa.Name = "lbl_etapa";
            this.lbl_etapa.Size = new System.Drawing.Size(184, 25);
            this.lbl_etapa.TabIndex = 6;
            this.lbl_etapa.Text = "Aguardando início...";
            this.lbl_etapa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(203, 139);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(74, 33);
            this.btn_iniciar.TabIndex = 7;
            this.btn_iniciar.Text = "iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // Frm_Carregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(500, 222);
            this.ControlBox = false;
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.lbl_etapa);
            this.Controls.Add(this.lbl_percentual);
            this.Controls.Add(this.PB_carga);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Carregamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna Eletronica - Carregando";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_percentual;
        private System.Windows.Forms.ProgressBar PB_carga;
        private System.Windows.Forms.Label lbl_etapa;
        private System.Windows.Forms.Button btn_iniciar;
    }
}

