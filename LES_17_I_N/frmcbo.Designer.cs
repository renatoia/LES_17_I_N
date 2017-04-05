namespace LES_17_I_N
{
    partial class frmcbo
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
            this.tbccbo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvcbo = new System.Windows.Forms.DataGridView();
            this.txtcbonome = new System.Windows.Forms.TextBox();
            this.txtcbocodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfucnome = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.CBOCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBONOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUCNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbccbo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcbo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbccbo
            // 
            this.tbccbo.Controls.Add(this.tabPage1);
            this.tbccbo.Controls.Add(this.tabPage2);
            this.tbccbo.Location = new System.Drawing.Point(1, 1);
            this.tbccbo.Name = "tbccbo";
            this.tbccbo.SelectedIndex = 0;
            this.tbccbo.Size = new System.Drawing.Size(384, 361);
            this.tbccbo.TabIndex = 0;
            this.tbccbo.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbclistagemcbo_Selected);
            this.tbccbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmcbo_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvcbo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbfucnome);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtcbonome);
            this.tabPage2.Controls.Add(this.txtcbocodi);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvcbo
            // 
            this.dgvcbo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvcbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBOCODI,
            this.CBONOME,
            this.FUCNOME});
            this.dgvcbo.Location = new System.Drawing.Point(0, 0);
            this.dgvcbo.MultiSelect = false;
            this.dgvcbo.Name = "dgvcbo";
            this.dgvcbo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcbo.Size = new System.Drawing.Size(376, 335);
            this.dgvcbo.TabIndex = 0;
            this.dgvcbo.DoubleClick += new System.EventHandler(this.dgvcbo_DoubleClick);
            // 
            // txtcbonome
            // 
            this.txtcbonome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcbonome.Location = new System.Drawing.Point(72, 58);
            this.txtcbonome.Name = "txtcbonome";
            this.txtcbonome.Size = new System.Drawing.Size(250, 20);
            this.txtcbonome.TabIndex = 6;
            // 
            // txtcbocodi
            // 
            this.txtcbocodi.Location = new System.Drawing.Point(72, 15);
            this.txtcbocodi.Name = "txtcbocodi";
            this.txtcbocodi.Size = new System.Drawing.Size(50, 20);
            this.txtcbocodi.TabIndex = 4;
            this.txtcbocodi.Leave += new System.EventHandler(this.txtcbocodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // cmbfucnome
            // 
            this.cmbfucnome.FormattingEnabled = true;
            this.cmbfucnome.Location = new System.Drawing.Point(73, 120);
            this.cmbfucnome.Name = "cmbfucnome";
            this.cmbfucnome.Size = new System.Drawing.Size(250, 21);
            this.cmbfucnome.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Função:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(288, 301);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 17;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(200, 301);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 16;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(105, 301);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 15;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(14, 301);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 14;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // CBOCODI
            // 
            this.CBOCODI.DataPropertyName = "CBOCODI";
            this.CBOCODI.HeaderText = "Código";
            this.CBOCODI.Name = "CBOCODI";
            // 
            // CBONOME
            // 
            this.CBONOME.DataPropertyName = "CBONOME";
            this.CBONOME.HeaderText = "Nome";
            this.CBONOME.Name = "CBONOME";
            // 
            // FUCNOME
            // 
            this.FUCNOME.DataPropertyName = "FUCNOME";
            this.FUCNOME.HeaderText = "Função";
            this.FUCNOME.Name = "FUCNOME";
            // 
            // frmcbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbccbo);
            this.Name = "frmcbo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos CBO";
            this.Load += new System.EventHandler(this.frmcbo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmcbo_KeyDown);
            this.tbccbo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcbo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbccbo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvcbo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtcbonome;
        private System.Windows.Forms.TextBox txtcbocodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbfucnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBOCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBONOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCNOME;
    }
}