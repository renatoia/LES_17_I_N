namespace LES_17_I_N
{
    partial class frmdepto
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
            this.tbcdepto = new System.Windows.Forms.TabControl();
            this.tbplistagem = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvdepto = new System.Windows.Forms.DataGridView();
            this.txtdepcodi = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtdepnome = new System.Windows.Forms.TextBox();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcdepto.SuspendLayout();
            this.tbplistagem.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcdepto
            // 
            this.tbcdepto.Controls.Add(this.tbplistagem);
            this.tbcdepto.Controls.Add(this.tabPage2);
            this.tbcdepto.Location = new System.Drawing.Point(1, 1);
            this.tbcdepto.Name = "tbcdepto";
            this.tbcdepto.SelectedIndex = 0;
            this.tbcdepto.Size = new System.Drawing.Size(382, 360);
            this.tbcdepto.TabIndex = 0;
            this.tbcdepto.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbclistagemdepto_Selected);
            this.tbcdepto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmdepto_KeyDown);
            // 
            // tbplistagem
            // 
            this.tbplistagem.Controls.Add(this.dgvdepto);
            this.tbplistagem.Location = new System.Drawing.Point(4, 22);
            this.tbplistagem.Name = "tbplistagem";
            this.tbplistagem.Padding = new System.Windows.Forms.Padding(3);
            this.tbplistagem.Size = new System.Drawing.Size(374, 334);
            this.tbplistagem.TabIndex = 0;
            this.tbplistagem.Text = "Listagem";
            this.tbplistagem.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtdepcodi);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtdepnome);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(374, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvdepto
            // 
            this.dgvdepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOME});
            this.dgvdepto.Location = new System.Drawing.Point(0, 0);
            this.dgvdepto.MultiSelect = false;
            this.dgvdepto.Name = "dgvdepto";
            this.dgvdepto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdepto.Size = new System.Drawing.Size(374, 334);
            this.dgvdepto.TabIndex = 0;
            this.dgvdepto.DoubleClick += new System.EventHandler(this.dgvdepto_DoubleClick);
            // 
            // txtdepcodi
            // 
            this.txtdepcodi.Location = new System.Drawing.Point(79, 24);
            this.txtdepcodi.Name = "txtdepcodi";
            this.txtdepcodi.Size = new System.Drawing.Size(50, 20);
            this.txtdepcodi.TabIndex = 15;
            this.txtdepcodi.Leave += new System.EventHandler(this.txtdepcodi_Leave);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(287, 287);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 21;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(199, 287);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 20;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(104, 287);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 19;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome:";
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(13, 287);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 18;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtdepnome
            // 
            this.txtdepnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdepnome.Location = new System.Drawing.Point(79, 67);
            this.txtdepnome.Name = "txtdepnome";
            this.txtdepnome.Size = new System.Drawing.Size(250, 20);
            this.txtdepnome.TabIndex = 17;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "DEPCODI";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "DEPNOME";
            this.NOME.HeaderText = "Nome";
            this.NOME.Name = "NOME";
            // 
            // frmdepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcdepto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmdepto";
            this.Text = "Dados dos Departamentos";
            this.Load += new System.EventHandler(this.frmdepto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmdepto_KeyDown);
            this.tbcdepto.ResumeLayout(false);
            this.tbplistagem.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcdepto;
        private System.Windows.Forms.TabPage tbplistagem;
        private System.Windows.Forms.DataGridView dgvdepto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtdepcodi;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtdepnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
    }
}