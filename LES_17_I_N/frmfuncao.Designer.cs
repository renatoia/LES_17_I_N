namespace LES_17_I_N
{
    partial class frmfuncao
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
            this.tbcfuncao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvfuncao = new System.Windows.Forms.DataGridView();
            this.cmbcbonome = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtfucnome = new System.Windows.Forms.TextBox();
            this.txtfuccodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUCNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcfuncao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncao)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcfuncao
            // 
            this.tbcfuncao.Controls.Add(this.tabPage1);
            this.tbcfuncao.Controls.Add(this.tabPage2);
            this.tbcfuncao.Location = new System.Drawing.Point(0, 0);
            this.tbcfuncao.Name = "tbcfuncao";
            this.tbcfuncao.SelectedIndex = 0;
            this.tbcfuncao.Size = new System.Drawing.Size(385, 364);
            this.tbcfuncao.TabIndex = 0;
            this.tbcfuncao.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbclistagemcbo_Selected);
            this.tbcfuncao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmcbo_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvfuncao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbcbonome);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtfucnome);
            this.tabPage2.Controls.Add(this.txtfuccodi);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(377, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvfuncao
            // 
            this.dgvfuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.FUCNOME,
            this.CBONOME});
            this.dgvfuncao.Location = new System.Drawing.Point(0, 0);
            this.dgvfuncao.MultiSelect = false;
            this.dgvfuncao.Name = "dgvfuncao";
            this.dgvfuncao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfuncao.Size = new System.Drawing.Size(377, 338);
            this.dgvfuncao.TabIndex = 0;
            this.dgvfuncao.DoubleClick += new System.EventHandler(this.dgvfuncao_DoubleClick);
            // 
            // cmbcbonome
            // 
            this.cmbcbonome.FormattingEnabled = true;
            this.cmbcbonome.Location = new System.Drawing.Point(73, 120);
            this.cmbcbonome.Name = "cmbcbonome";
            this.cmbcbonome.Size = new System.Drawing.Size(250, 21);
            this.cmbcbonome.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "CBO:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(288, 301);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 27;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(200, 301);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 26;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(105, 301);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 25;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(14, 301);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 24;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtfucnome
            // 
            this.txtfucnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfucnome.Location = new System.Drawing.Point(72, 58);
            this.txtfucnome.Name = "txtfucnome";
            this.txtfucnome.Size = new System.Drawing.Size(250, 20);
            this.txtfucnome.TabIndex = 22;
            // 
            // txtfuccodi
            // 
            this.txtfuccodi.Location = new System.Drawing.Point(72, 15);
            this.txtfuccodi.Name = "txtfuccodi";
            this.txtfuccodi.Size = new System.Drawing.Size(50, 20);
            this.txtfuccodi.TabIndex = 20;
            this.txtfuccodi.Leave += new System.EventHandler(this.txtfuccodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código:";
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "FUCCODI";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            // 
            // FUCNOME
            // 
            this.FUCNOME.DataPropertyName = "FUCNOME";
            this.FUCNOME.HeaderText = "Nome";
            this.FUCNOME.Name = "FUCNOME";
            // 
            // CBONOME
            // 
            this.CBONOME.DataPropertyName = "CBONOME";
            this.CBONOME.HeaderText = "CBO";
            this.CBONOME.Name = "CBONOME";
            // 
            // frmfuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcfuncao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados das Funções";
            this.Load += new System.EventHandler(this.frmcbo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmcbo_KeyDown);
            this.tbcfuncao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcfuncao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvfuncao;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBONOME;
        private System.Windows.Forms.ComboBox cmbcbonome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtfucnome;
        private System.Windows.Forms.TextBox txtfuccodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}