namespace LES_17_I_N
{
    partial class frmestado
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
            this.tbcestado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvestado = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbpainome = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtesticms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtestuf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtestnome = new System.Windows.Forms.TextBox();
            this.txtestcodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcestado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcestado
            // 
            this.tbcestado.Controls.Add(this.tabPage1);
            this.tbcestado.Controls.Add(this.tabPage2);
            this.tbcestado.Location = new System.Drawing.Point(6, 4);
            this.tbcestado.Name = "tbcestado";
            this.tbcestado.SelectedIndex = 0;
            this.tbcestado.Size = new System.Drawing.Size(372, 352);
            this.tbcestado.TabIndex = 1;
            this.tbcestado.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbclistagemestado_Selected);
            this.tbcestado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmestado_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvestado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvestado
            // 
            this.dgvestado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NOME,
            this.UF,
            this.ICMS,
            this.PAIS});
            this.dgvestado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvestado.Location = new System.Drawing.Point(3, 3);
            this.dgvestado.MultiSelect = false;
            this.dgvestado.Name = "dgvestado";
            this.dgvestado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvestado.Size = new System.Drawing.Size(358, 320);
            this.dgvestado.TabIndex = 0;
            this.dgvestado.DoubleClick += new System.EventHandler(this.dgvestado_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ESTCODI";
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.Name = "Codigo";
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "ESTNOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // UF
            // 
            this.UF.DataPropertyName = "ESTUF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            // 
            // ICMS
            // 
            this.ICMS.DataPropertyName = "ESTICMS";
            this.ICMS.HeaderText = "% ICMS";
            this.ICMS.Name = "ICMS";
            // 
            // PAIS
            // 
            this.PAIS.DataPropertyName = "PAINOME";
            this.PAIS.HeaderText = "PAIS";
            this.PAIS.Name = "PAIS";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbpainome);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtesticms);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtestuf);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtestnome);
            this.tabPage2.Controls.Add(this.txtestcodi);
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
            // cmbpainome
            // 
            this.cmbpainome.FormattingEnabled = true;
            this.cmbpainome.Location = new System.Drawing.Point(65, 221);
            this.cmbpainome.Name = "cmbpainome";
            this.cmbpainome.Size = new System.Drawing.Size(250, 21);
            this.cmbpainome.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "País:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "%";
            // 
            // txtesticms
            // 
            this.txtesticms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtesticms.Location = new System.Drawing.Point(65, 181);
            this.txtesticms.Name = "txtesticms";
            this.txtesticms.Size = new System.Drawing.Size(50, 20);
            this.txtesticms.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "% ICMS:";
            // 
            // txtestuf
            // 
            this.txtestuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestuf.Location = new System.Drawing.Point(65, 137);
            this.txtestuf.Name = "txtestuf";
            this.txtestuf.Size = new System.Drawing.Size(27, 20);
            this.txtestuf.TabIndex = 3;
            this.txtestuf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "UF:";
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
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click_1);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(97, 292);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 7;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click_1);
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
            // txtestnome
            // 
            this.txtestnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestnome.Location = new System.Drawing.Point(65, 92);
            this.txtestnome.Name = "txtestnome";
            this.txtestnome.Size = new System.Drawing.Size(250, 20);
            this.txtestnome.TabIndex = 2;
            // 
            // txtestcodi
            // 
            this.txtestcodi.Location = new System.Drawing.Point(65, 49);
            this.txtestcodi.Name = "txtestcodi";
            this.txtestcodi.Size = new System.Drawing.Size(50, 20);
            this.txtestcodi.TabIndex = 1;
            this.txtestcodi.Leave += new System.EventHandler(this.txtestcodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
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
            // frmestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcestado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Estados";
            this.Load += new System.EventHandler(this.frmestado_Load);
            this.tbcestado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvestado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcestado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvestado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtestnome;
        private System.Windows.Forms.TextBox txtestcodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtesticms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtestuf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbpainome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAIS;
    }
}