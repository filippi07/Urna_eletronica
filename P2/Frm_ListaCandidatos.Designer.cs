namespace P2
{
    partial class Frm_ListaCandidatos
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
            this.components = new System.ComponentModel.Container();
            this.dgv_candidatos = new System.Windows.Forms.DataGridView();
            this.candidatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeCandidatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePartidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglaPartidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_candidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_candidatos
            // 
            this.dgv_candidatos.AllowUserToResizeRows = false;
            this.dgv_candidatos.AutoGenerateColumns = false;
            this.dgv_candidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_candidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeCandidatoDataGridViewTextBoxColumn,
            this.nomePartidoDataGridViewTextBoxColumn,
            this.siglaPartidoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dgv_candidatos.DataSource = this.candidatoBindingSource;
            this.dgv_candidatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_candidatos.Location = new System.Drawing.Point(0, 0);
            this.dgv_candidatos.Name = "dgv_candidatos";
            this.dgv_candidatos.ReadOnly = true;
            this.dgv_candidatos.RowHeadersWidth = 51;
            this.dgv_candidatos.RowTemplate.Height = 24;
            this.dgv_candidatos.Size = new System.Drawing.Size(803, 450);
            this.dgv_candidatos.TabIndex = 0;
            // 
            // candidatoBindingSource
            // 
            this.candidatoBindingSource.DataSource = typeof(P2.Models.Candidato);
            // 
            // nomeCandidatoDataGridViewTextBoxColumn
            // 
            this.nomeCandidatoDataGridViewTextBoxColumn.DataPropertyName = "NomeCandidato";
            this.nomeCandidatoDataGridViewTextBoxColumn.HeaderText = "NomeCandidato";
            this.nomeCandidatoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeCandidatoDataGridViewTextBoxColumn.Name = "nomeCandidatoDataGridViewTextBoxColumn";
            this.nomeCandidatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeCandidatoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomePartidoDataGridViewTextBoxColumn
            // 
            this.nomePartidoDataGridViewTextBoxColumn.DataPropertyName = "NomePartido";
            this.nomePartidoDataGridViewTextBoxColumn.HeaderText = "NomePartido";
            this.nomePartidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomePartidoDataGridViewTextBoxColumn.Name = "nomePartidoDataGridViewTextBoxColumn";
            this.nomePartidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomePartidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // siglaPartidoDataGridViewTextBoxColumn
            // 
            this.siglaPartidoDataGridViewTextBoxColumn.DataPropertyName = "SiglaPartido";
            this.siglaPartidoDataGridViewTextBoxColumn.HeaderText = "SiglaPartido";
            this.siglaPartidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siglaPartidoDataGridViewTextBoxColumn.Name = "siglaPartidoDataGridViewTextBoxColumn";
            this.siglaPartidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.siglaPartidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 125;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Frm_ListaCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.dgv_candidatos);
            this.Name = "Frm_ListaCandidatos";
            this.Text = "Frm_ListaCandidatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_candidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_candidatos;
        private System.Windows.Forms.BindingSource candidatoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCandidatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePartidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaPartidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
    }
}