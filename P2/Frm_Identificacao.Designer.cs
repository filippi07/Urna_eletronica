namespace P2
{
    partial class Frm_Identificacao
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.btn_validar_titulo = new System.Windows.Forms.Button();
            this.btn_validar_biometria = new System.Windows.Forms.Button();
            this.txt_biometria = new System.Windows.Forms.TextBox();
            this.lbl_biometria = new System.Windows.Forms.Label();
            this.btn_encerrar = new System.Windows.Forms.Button();
            this.lbl_mensagem = new System.Windows.Forms.Label();
            this.btn_verèleitores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(80, 7);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(145, 16);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Digite o título de eleitor:";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(80, 26);
            this.txt_titulo.MaxLength = 12;
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(145, 22);
            this.txt_titulo.TabIndex = 1;
            // 
            // btn_validar_titulo
            // 
            this.btn_validar_titulo.Location = new System.Drawing.Point(80, 54);
            this.btn_validar_titulo.Name = "btn_validar_titulo";
            this.btn_validar_titulo.Size = new System.Drawing.Size(145, 42);
            this.btn_validar_titulo.TabIndex = 2;
            this.btn_validar_titulo.Text = "Confirmar titulo";
            this.btn_validar_titulo.UseVisualStyleBackColor = true;
            this.btn_validar_titulo.Click += new System.EventHandler(this.btn_validar_titulo_Click);
            // 
            // btn_validar_biometria
            // 
            this.btn_validar_biometria.Location = new System.Drawing.Point(83, 159);
            this.btn_validar_biometria.Name = "btn_validar_biometria";
            this.btn_validar_biometria.Size = new System.Drawing.Size(142, 42);
            this.btn_validar_biometria.TabIndex = 5;
            this.btn_validar_biometria.Text = "Confirmar biometria";
            this.btn_validar_biometria.UseVisualStyleBackColor = true;
            this.btn_validar_biometria.Visible = false;
            this.btn_validar_biometria.Click += new System.EventHandler(this.btn_validar_biometria_Click);
            // 
            // txt_biometria
            // 
            this.txt_biometria.Location = new System.Drawing.Point(83, 130);
            this.txt_biometria.MaxLength = 8;
            this.txt_biometria.Name = "txt_biometria";
            this.txt_biometria.Size = new System.Drawing.Size(142, 22);
            this.txt_biometria.TabIndex = 4;
            this.txt_biometria.Visible = false;
            // 
            // lbl_biometria
            // 
            this.lbl_biometria.AutoSize = true;
            this.lbl_biometria.Location = new System.Drawing.Point(98, 111);
            this.lbl_biometria.Name = "lbl_biometria";
            this.lbl_biometria.Size = new System.Drawing.Size(115, 16);
            this.lbl_biometria.TabIndex = 3;
            this.lbl_biometria.Text = "Digite a biometria:";
            this.lbl_biometria.Visible = false;
            // 
            // btn_encerrar
            // 
            this.btn_encerrar.Location = new System.Drawing.Point(83, 368);
            this.btn_encerrar.Name = "btn_encerrar";
            this.btn_encerrar.Size = new System.Drawing.Size(142, 68);
            this.btn_encerrar.TabIndex = 8;
            this.btn_encerrar.Text = "Encerrar votação";
            this.btn_encerrar.UseVisualStyleBackColor = true;
            this.btn_encerrar.Click += new System.EventHandler(this.btn_encerrar_Click);
            // 
            // lbl_mensagem
            // 
            this.lbl_mensagem.AutoSize = true;
            this.lbl_mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensagem.ForeColor = System.Drawing.Color.Red;
            this.lbl_mensagem.Location = new System.Drawing.Point(38, 213);
            this.lbl_mensagem.Name = "lbl_mensagem";
            this.lbl_mensagem.Size = new System.Drawing.Size(0, 25);
            this.lbl_mensagem.TabIndex = 6;
            // 
            // btn_verèleitores
            // 
            this.btn_verèleitores.Location = new System.Drawing.Point(83, 320);
            this.btn_verèleitores.Name = "btn_verèleitores";
            this.btn_verèleitores.Size = new System.Drawing.Size(142, 42);
            this.btn_verèleitores.TabIndex = 9;
            this.btn_verèleitores.Text = "Ver eleitores";
            this.btn_verèleitores.UseVisualStyleBackColor = true;
            this.btn_verèleitores.Click += new System.EventHandler(this.btn_verèleitores_Click);
            // 
            // Frm_Identificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(313, 444);
            this.ControlBox = false;
            this.Controls.Add(this.btn_verèleitores);
            this.Controls.Add(this.btn_encerrar);
            this.Controls.Add(this.lbl_mensagem);
            this.Controls.Add(this.btn_validar_biometria);
            this.Controls.Add(this.txt_biometria);
            this.Controls.Add(this.lbl_biometria);
            this.Controls.Add(this.btn_validar_titulo);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Frm_Identificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urna Eletronica - Identificacao";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Identificacao_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Button btn_validar_titulo;
        private System.Windows.Forms.Button btn_validar_biometria;
        private System.Windows.Forms.TextBox txt_biometria;
        private System.Windows.Forms.Label lbl_biometria;
        private System.Windows.Forms.Button btn_encerrar;
        private System.Windows.Forms.Label lbl_mensagem;
        private System.Windows.Forms.Button btn_verèleitores;
    }
}