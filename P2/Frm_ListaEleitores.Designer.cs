namespace P2
{
    partial class Frm_ListaEleitores
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
            this.dgv_eleitores = new System.Windows.Forms.DataGridView();
            this.eleitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDaMaeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDoTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biometriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eleitores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleitorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_eleitores
            // 
            this.dgv_eleitores.AllowUserToAddRows = false;
            this.dgv_eleitores.AllowUserToDeleteRows = false;
            this.dgv_eleitores.AutoGenerateColumns = false;
            this.dgv_eleitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eleitores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nomeDaMaeDataGridViewTextBoxColumn,
            this.numeroDoTituloDataGridViewTextBoxColumn,
            this.biometriaDataGridViewTextBoxColumn});
            this.dgv_eleitores.DataSource = this.eleitorBindingSource;
            this.dgv_eleitores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_eleitores.Location = new System.Drawing.Point(0, 0);
            this.dgv_eleitores.Name = "dgv_eleitores";
            this.dgv_eleitores.ReadOnly = true;
            this.dgv_eleitores.RowHeadersWidth = 51;
            this.dgv_eleitores.RowTemplate.Height = 24;
            this.dgv_eleitores.Size = new System.Drawing.Size(800, 450);
            this.dgv_eleitores.TabIndex = 0;
            // 
            // eleitorBindingSource
            // 
            this.eleitorBindingSource.DataSource = typeof(P2.Models.Eleitor);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDaMaeDataGridViewTextBoxColumn
            // 
            this.nomeDaMaeDataGridViewTextBoxColumn.DataPropertyName = "NomeDaMae";
            this.nomeDaMaeDataGridViewTextBoxColumn.HeaderText = "NomeDaMae";
            this.nomeDaMaeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDaMaeDataGridViewTextBoxColumn.Name = "nomeDaMaeDataGridViewTextBoxColumn";
            this.nomeDaMaeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDaMaeDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroDoTituloDataGridViewTextBoxColumn
            // 
            this.numeroDoTituloDataGridViewTextBoxColumn.DataPropertyName = "NumeroDoTitulo";
            this.numeroDoTituloDataGridViewTextBoxColumn.HeaderText = "NumeroDoTitulo";
            this.numeroDoTituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDoTituloDataGridViewTextBoxColumn.Name = "numeroDoTituloDataGridViewTextBoxColumn";
            this.numeroDoTituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDoTituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // biometriaDataGridViewTextBoxColumn
            // 
            this.biometriaDataGridViewTextBoxColumn.DataPropertyName = "Biometria";
            this.biometriaDataGridViewTextBoxColumn.HeaderText = "Biometria";
            this.biometriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biometriaDataGridViewTextBoxColumn.Name = "biometriaDataGridViewTextBoxColumn";
            this.biometriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.biometriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Frm_ListaEleitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_eleitores);
            this.Name = "Frm_ListaEleitores";
            this.Text = "Frm_ListaEleitores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eleitores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleitorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_eleitores;
        private System.Windows.Forms.BindingSource eleitorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDaMaeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDoTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biometriaDataGridViewTextBoxColumn;
    }
}