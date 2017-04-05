namespace LES_17_I_N
{
    partial class frmhorario
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
            this.tbchorario1 = new System.Windows.Forms.TabControl();
            this.tbchorario = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txthornome = new System.Windows.Forms.TextBox();
            this.txthorcodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbthonome = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txthormane = new System.Windows.Forms.TextBox();
            this.txthormans = new System.Windows.Forms.TextBox();
            this.txthortare = new System.Windows.Forms.TextBox();
            this.txthortars = new System.Windows.Forms.TextBox();
            this.dgvhorario = new System.Windows.Forms.DataGridView();
            this.horcodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hornome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hormane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hormans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hortare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hortars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thonome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbchorario1.SuspendLayout();
            this.tbchorario.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).BeginInit();
            this.SuspendLayout();
            // 
            // tbchorario1
            // 
            this.tbchorario1.Controls.Add(this.tbchorario);
            this.tbchorario1.Controls.Add(this.tabPage2);
            this.tbchorario1.Location = new System.Drawing.Point(2, 0);
            this.tbchorario1.Name = "tbchorario1";
            this.tbchorario1.SelectedIndex = 0;
            this.tbchorario1.Size = new System.Drawing.Size(379, 358);
            this.tbchorario1.TabIndex = 0;
            this.tbchorario1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbclistagemhorario1_Selected);
            this.tbchorario1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmhorario_KeyDown);
            // 
            // tbchorario
            // 
            this.tbchorario.Controls.Add(this.dgvhorario);
            this.tbchorario.Location = new System.Drawing.Point(4, 22);
            this.tbchorario.Name = "tbchorario";
            this.tbchorario.Padding = new System.Windows.Forms.Padding(3);
            this.tbchorario.Size = new System.Drawing.Size(371, 332);
            this.tbchorario.TabIndex = 0;
            this.tbchorario.Text = "Listagem";
            this.tbchorario.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txthortars);
            this.tabPage2.Controls.Add(this.txthortare);
            this.tabPage2.Controls.Add(this.txthormans);
            this.tabPage2.Controls.Add(this.txthormane);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbthonome);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txthornome);
            this.tabPage2.Controls.Add(this.txthorcodi);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(371, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txthornome
            // 
            this.txthornome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthornome.Location = new System.Drawing.Point(69, 59);
            this.txthornome.Name = "txthornome";
            this.txthornome.Size = new System.Drawing.Size(250, 20);
            this.txthornome.TabIndex = 3;
            // 
            // txthorcodi
            // 
            this.txthorcodi.Location = new System.Drawing.Point(69, 25);
            this.txthorcodi.Name = "txthorcodi";
            this.txthorcodi.Size = new System.Drawing.Size(50, 20);
            this.txthorcodi.TabIndex = 1;
            this.txthorcodi.Leave += new System.EventHandler(this.txthorcodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // cmbthonome
            // 
            this.cmbthonome.FormattingEnabled = true;
            this.cmbthonome.Location = new System.Drawing.Point(99, 235);
            this.cmbthonome.Name = "cmbthonome";
            this.cmbthonome.Size = new System.Drawing.Size(220, 21);
            this.cmbthonome.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Horário:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(284, 303);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 17;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(196, 303);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 16;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(101, 303);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 15;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(10, 303);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 14;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manhã Entrada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manhã Saída:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tarde Saída:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tarde Entrada:";
            // 
            // txthormane
            // 
            this.txthormane.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthormane.Location = new System.Drawing.Point(94, 128);
            this.txthormane.Name = "txthormane";
            this.txthormane.Size = new System.Drawing.Size(77, 20);
            this.txthormane.TabIndex = 5;
            // 
            // txthormans
            // 
            this.txthormans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthormans.Location = new System.Drawing.Point(270, 128);
            this.txthormans.Name = "txthormans";
            this.txthormans.Size = new System.Drawing.Size(77, 20);
            this.txthormans.TabIndex = 7;
            // 
            // txthortare
            // 
            this.txthortare.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthortare.Location = new System.Drawing.Point(94, 170);
            this.txthortare.Name = "txthortare";
            this.txthortare.Size = new System.Drawing.Size(77, 20);
            this.txthortare.TabIndex = 9;
            // 
            // txthortars
            // 
            this.txthortars.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthortars.Location = new System.Drawing.Point(270, 170);
            this.txthortars.Name = "txthortars";
            this.txthortars.Size = new System.Drawing.Size(77, 20);
            this.txthortars.TabIndex = 11;
            // 
            // dgvhorario
            // 
            this.dgvhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horcodi,
            this.hornome,
            this.hormane,
            this.hormans,
            this.hortare,
            this.hortars,
            this.thonome});
            this.dgvhorario.Location = new System.Drawing.Point(0, 0);
            this.dgvhorario.MultiSelect = false;
            this.dgvhorario.Name = "dgvhorario";
            this.dgvhorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhorario.Size = new System.Drawing.Size(371, 332);
            this.dgvhorario.TabIndex = 0;
            this.dgvhorario.DoubleClick += new System.EventHandler(this.dgvestado_DoubleClick);
            // 
            // horcodi
            // 
            this.horcodi.DataPropertyName = "horcodi";
            this.horcodi.HeaderText = "Código";
            this.horcodi.Name = "horcodi";
            // 
            // hornome
            // 
            this.hornome.DataPropertyName = "hornome";
            this.hornome.HeaderText = "Nome";
            this.hornome.Name = "hornome";
            // 
            // hormane
            // 
            this.hormane.DataPropertyName = "hormane";
            this.hormane.HeaderText = "Manhã Entrada";
            this.hormane.Name = "hormane";
            // 
            // hormans
            // 
            this.hormans.DataPropertyName = "hormans";
            this.hormans.HeaderText = "Manhã Saída";
            this.hormans.Name = "hormans";
            // 
            // hortare
            // 
            this.hortare.DataPropertyName = "hortare";
            this.hortare.HeaderText = "Tarde Entrada";
            this.hortare.Name = "hortare";
            // 
            // hortars
            // 
            this.hortars.DataPropertyName = "hortars";
            this.hortars.HeaderText = "Tarde Saída";
            this.hortars.Name = "hortars";
            // 
            // thonome
            // 
            this.thonome.DataPropertyName = "thonome";
            this.thonome.HeaderText = "Tipo de Horário";
            this.thonome.Name = "thonome";
            // 
            // frmhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbchorario1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmhorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos Horarios";
            this.Load += new System.EventHandler(this.frmhorario_Load);
            this.tbchorario1.ResumeLayout(false);
            this.tbchorario.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbchorario1;
        private System.Windows.Forms.TabPage tbchorario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txthornome;
        private System.Windows.Forms.TextBox txthorcodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthortars;
        private System.Windows.Forms.TextBox txthortare;
        private System.Windows.Forms.TextBox txthormans;
        private System.Windows.Forms.TextBox txthormane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbthonome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.DataGridView dgvhorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn horcodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hornome;
        private System.Windows.Forms.DataGridViewTextBoxColumn hormane;
        private System.Windows.Forms.DataGridViewTextBoxColumn hormans;
        private System.Windows.Forms.DataGridViewTextBoxColumn hortare;
        private System.Windows.Forms.DataGridViewTextBoxColumn hortars;
        private System.Windows.Forms.DataGridViewTextBoxColumn thonome;
    }
}