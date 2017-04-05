namespace LES_17_I_N
{
    partial class frmtipohorario
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
            this.txtthonome = new System.Windows.Forms.TextBox();
            this.txtthocodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.tbctipohorario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvtipohorario = new System.Windows.Forms.DataGridView();
            this.thocodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thonome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbctipohorario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipohorario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtthonome
            // 
            this.txtthonome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtthonome.Location = new System.Drawing.Point(72, 61);
            this.txtthonome.Name = "txtthonome";
            this.txtthonome.Size = new System.Drawing.Size(250, 20);
            this.txtthonome.TabIndex = 6;
            // 
            // txtthocodi
            // 
            this.txtthocodi.Location = new System.Drawing.Point(72, 18);
            this.txtthocodi.Name = "txtthocodi";
            this.txtthocodi.Size = new System.Drawing.Size(50, 20);
            this.txtthocodi.TabIndex = 4;
            this.txtthocodi.Leave += new System.EventHandler(this.txtthocodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(280, 281);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(192, 281);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 12;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click_1);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(97, 281);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 11;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click_1);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(6, 281);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 10;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // tbctipohorario
            // 
            this.tbctipohorario.Controls.Add(this.tabPage1);
            this.tbctipohorario.Controls.Add(this.tabPage2);
            this.tbctipohorario.Location = new System.Drawing.Point(-1, 3);
            this.tbctipohorario.Name = "tbctipohorario";
            this.tbctipohorario.SelectedIndex = 0;
            this.tbctipohorario.Size = new System.Drawing.Size(373, 346);
            this.tbctipohorario.TabIndex = 14;
            this.tbctipohorario.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbclistagemtipohorario_Selected);
            this.tbctipohorario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmtipohorario_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvtipohorario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtthocodi);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtthonome);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvtipohorario
            // 
            this.dgvtipohorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipohorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thocodi,
            this.thonome});
            this.dgvtipohorario.Location = new System.Drawing.Point(6, 6);
            this.dgvtipohorario.MultiSelect = false;
            this.dgvtipohorario.Name = "dgvtipohorario";
            this.dgvtipohorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtipohorario.Size = new System.Drawing.Size(353, 308);
            this.dgvtipohorario.TabIndex = 0;
            this.dgvtipohorario.DoubleClick += new System.EventHandler(this.dgvtipohorario_DoubleClick);
            // 
            // thocodi
            // 
            this.thocodi.DataPropertyName = "thocodi";
            this.thocodi.HeaderText = "Código";
            this.thocodi.Name = "thocodi";
            // 
            // thonome
            // 
            this.thonome.DataPropertyName = "thonome";
            this.thonome.HeaderText = "Nome";
            this.thonome.Name = "thonome";
            // 
            // frmtipohorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbctipohorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmtipohorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos Tipos de Horários";
            this.Load += new System.EventHandler(this.frmtipohorario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmtipohorario_KeyDown);
            this.tbctipohorario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipohorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtthonome;
        private System.Windows.Forms.TextBox txtthocodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TabControl tbctipohorario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvtipohorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn thocodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn thonome;
    }
}