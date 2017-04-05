namespace LES_17_I_N
{
    partial class frmmunicipio
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
            this.tbcmunicipio = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvmunicipio = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbestnome = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtmunnome = new System.Windows.Forms.TextBox();
            this.txtmuncodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcmunicipio.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmunicipio)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcmunicipio
            // 
            this.tbcmunicipio.Controls.Add(this.tabPage1);
            this.tbcmunicipio.Controls.Add(this.tabPage2);
            this.tbcmunicipio.Location = new System.Drawing.Point(6, 4);
            this.tbcmunicipio.Name = "tbcmunicipio";
            this.tbcmunicipio.SelectedIndex = 0;
            this.tbcmunicipio.Size = new System.Drawing.Size(372, 352);
            this.tbcmunicipio.TabIndex = 3;
            this.tbcmunicipio.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbclistagemmunicipio_Selected);
            this.tbcmunicipio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmunicipio_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvmunicipio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvmunicipio
            // 
            this.dgvmunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmunicipio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Estado,
            this.PAINOME});
            this.dgvmunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmunicipio.Location = new System.Drawing.Point(3, 3);
            this.dgvmunicipio.MultiSelect = false;
            this.dgvmunicipio.Name = "dgvmunicipio";
            this.dgvmunicipio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmunicipio.Size = new System.Drawing.Size(358, 320);
            this.dgvmunicipio.TabIndex = 0;
            this.dgvmunicipio.DoubleClick += new System.EventHandler(this.dgvmunicipio_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblpais);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbestnome);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtmunnome);
            this.tabPage2.Controls.Add(this.txtmuncodi);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbestnome
            // 
            this.cmbestnome.FormattingEnabled = true;
            this.cmbestnome.Location = new System.Drawing.Point(75, 131);
            this.cmbestnome.Name = "cmbestnome";
            this.cmbestnome.Size = new System.Drawing.Size(250, 21);
            this.cmbestnome.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(280, 292);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(192, 292);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(97, 292);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 7;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(6, 292);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 6;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtmunnome
            // 
            this.txtmunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmunnome.Location = new System.Drawing.Point(75, 87);
            this.txtmunnome.Name = "txtmunnome";
            this.txtmunnome.Size = new System.Drawing.Size(250, 20);
            this.txtmunnome.TabIndex = 3;
            // 
            // txtmuncodi
            // 
            this.txtmuncodi.Location = new System.Drawing.Point(75, 49);
            this.txtmuncodi.Name = "txtmuncodi";
            this.txtmuncodi.Size = new System.Drawing.Size(50, 20);
            this.txtmuncodi.TabIndex = 1;
            this.txtmuncodi.Leave += new System.EventHandler(this.txtmuncodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "País:";
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Location = new System.Drawing.Point(74, 180);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(29, 13);
            this.lblpais.TabIndex = 11;
            this.lblpais.Text = "País";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "muncodi";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "MUNNOME";
            this.Nome.HeaderText = "Município";
            this.Nome.Name = "Nome";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estnome";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // PAINOME
            // 
            this.PAINOME.DataPropertyName = "PAINOME";
            this.PAINOME.HeaderText = "País";
            this.PAINOME.Name = "PAINOME";
            // 
            // frmmunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcmunicipio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Municípios";
            this.Load += new System.EventHandler(this.frmmunicipio_Load);
            this.tbcmunicipio.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmunicipio)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcmunicipio;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvmunicipio;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbestnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtmunnome;
        private System.Windows.Forms.TextBox txtmuncodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAINOME;
    }
}