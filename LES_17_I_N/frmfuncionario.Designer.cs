namespace LES_17_I_N
{
    partial class frmfuncionario
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
            this.tbcfuncionario = new System.Windows.Forms.TabControl();
            this.tbplistagem = new System.Windows.Forms.TabPage();
            this.dgvfuncionario = new System.Windows.Forms.DataGridView();
            this.FUNCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNDTNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNSALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUCNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDENDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNNUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUNNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAINOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCELU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FUNCEL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpdetalhamento = new System.Windows.Forms.TabPage();
            this.txtdtns = new System.Windows.Forms.TextBox();
            this.cmbhornome = new System.Windows.Forms.ComboBox();
            this.cmbdepnome = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpdtna = new System.Windows.Forms.DateTimePicker();
            this.txtfuncpf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbfucnome = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfunsala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfunrg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtfunnome = new System.Windows.Forms.TextBox();
            this.txtfuncodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpcontato = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.txtfuncel1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtfuncelu = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtfunfone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.lbluf = new System.Windows.Forms.Label();
            this.lblmunicipio = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfunnume = new System.Windows.Forms.TextBox();
            this.lblendereco = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtendcep = new System.Windows.Forms.TextBox();
            this.tbcfuncionario.SuspendLayout();
            this.tbplistagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).BeginInit();
            this.tbpdetalhamento.SuspendLayout();
            this.tbpcontato.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcfuncionario
            // 
            this.tbcfuncionario.Controls.Add(this.tbplistagem);
            this.tbcfuncionario.Controls.Add(this.tbpdetalhamento);
            this.tbcfuncionario.Controls.Add(this.tbpcontato);
            this.tbcfuncionario.Location = new System.Drawing.Point(3, 4);
            this.tbcfuncionario.Name = "tbcfuncionario";
            this.tbcfuncionario.SelectedIndex = 0;
            this.tbcfuncionario.Size = new System.Drawing.Size(378, 345);
            this.tbcfuncionario.TabIndex = 0;
            this.tbcfuncionario.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbclistagemfuncionario_Selected);
            this.tbcfuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmfuncionario_KeyDown);
            // 
            // tbplistagem
            // 
            this.tbplistagem.Controls.Add(this.dgvfuncionario);
            this.tbplistagem.Location = new System.Drawing.Point(4, 22);
            this.tbplistagem.Name = "tbplistagem";
            this.tbplistagem.Padding = new System.Windows.Forms.Padding(3);
            this.tbplistagem.Size = new System.Drawing.Size(370, 319);
            this.tbplistagem.TabIndex = 0;
            this.tbplistagem.Text = "Listagem";
            this.tbplistagem.UseVisualStyleBackColor = true;
            // 
            // dgvfuncionario
            // 
            this.dgvfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FUNCODI,
            this.FUNNOME,
            this.FUNRG,
            this.FUNCPF,
            this.FUNDTNA,
            this.FUNSALA,
            this.DEPNOME,
            this.FUCNOME,
            this.HORNOME,
            this.ENDENDE,
            this.FUNNUME,
            this.ENDCEP,
            this.BAINOME,
            this.MUNNOME,
            this.ESTUF,
            this.PAINOME,
            this.FUNFONE,
            this.FUNCELU,
            this.FUNCEL1});
            this.dgvfuncionario.Location = new System.Drawing.Point(-1, 0);
            this.dgvfuncionario.MultiSelect = false;
            this.dgvfuncionario.Name = "dgvfuncionario";
            this.dgvfuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfuncionario.Size = new System.Drawing.Size(365, 313);
            this.dgvfuncionario.TabIndex = 0;
            this.dgvfuncionario.DoubleClick += new System.EventHandler(this.dgvfuncionario_DoubleClick);
            this.dgvfuncionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmfuncionario_KeyDown);
            // 
            // FUNCODI
            // 
            this.FUNCODI.DataPropertyName = "FUNCODI";
            this.FUNCODI.HeaderText = "Código";
            this.FUNCODI.Name = "FUNCODI";
            // 
            // FUNNOME
            // 
            this.FUNNOME.DataPropertyName = "FUNNOME";
            this.FUNNOME.HeaderText = "Nome";
            this.FUNNOME.Name = "FUNNOME";
            // 
            // FUNRG
            // 
            this.FUNRG.DataPropertyName = "FUNRG";
            this.FUNRG.HeaderText = "RG";
            this.FUNRG.Name = "FUNRG";
            // 
            // FUNCPF
            // 
            this.FUNCPF.DataPropertyName = "FUNCPF";
            this.FUNCPF.HeaderText = "CPF";
            this.FUNCPF.Name = "FUNCPF";
            // 
            // FUNDTNA
            // 
            this.FUNDTNA.DataPropertyName = "FUNDTNA";
            this.FUNDTNA.HeaderText = "Data Nascimento";
            this.FUNDTNA.Name = "FUNDTNA";
            // 
            // FUNSALA
            // 
            this.FUNSALA.DataPropertyName = "FUNSALA";
            this.FUNSALA.HeaderText = "Salário";
            this.FUNSALA.Name = "FUNSALA";
            // 
            // DEPNOME
            // 
            this.DEPNOME.DataPropertyName = "DEPNOME";
            this.DEPNOME.HeaderText = "Depto";
            this.DEPNOME.Name = "DEPNOME";
            // 
            // FUCNOME
            // 
            this.FUCNOME.DataPropertyName = "FUCNOME";
            this.FUCNOME.HeaderText = "Função";
            this.FUCNOME.Name = "FUCNOME";
            // 
            // HORNOME
            // 
            this.HORNOME.DataPropertyName = "HORNOME";
            this.HORNOME.HeaderText = "Horário";
            this.HORNOME.Name = "HORNOME";
            // 
            // ENDENDE
            // 
            this.ENDENDE.DataPropertyName = "ENDENDE";
            this.ENDENDE.HeaderText = "Endereço";
            this.ENDENDE.Name = "ENDENDE";
            // 
            // FUNNUME
            // 
            this.FUNNUME.DataPropertyName = "FUNNUME";
            this.FUNNUME.HeaderText = "Numero";
            this.FUNNUME.Name = "FUNNUME";
            // 
            // ENDCEP
            // 
            this.ENDCEP.DataPropertyName = "ENDCEP";
            this.ENDCEP.HeaderText = "CEP";
            this.ENDCEP.Name = "ENDCEP";
            // 
            // BAINOME
            // 
            this.BAINOME.DataPropertyName = "BAINOME";
            this.BAINOME.HeaderText = "Bairro";
            this.BAINOME.Name = "BAINOME";
            // 
            // MUNNOME
            // 
            this.MUNNOME.DataPropertyName = "MUNNOME";
            this.MUNNOME.HeaderText = "Município";
            this.MUNNOME.Name = "MUNNOME";
            // 
            // ESTUF
            // 
            this.ESTUF.DataPropertyName = "ESTUF";
            this.ESTUF.HeaderText = "UF";
            this.ESTUF.Name = "ESTUF";
            // 
            // PAINOME
            // 
            this.PAINOME.DataPropertyName = "PAINOME";
            this.PAINOME.HeaderText = "País";
            this.PAINOME.Name = "PAINOME";
            // 
            // FUNFONE
            // 
            this.FUNFONE.DataPropertyName = "FUNFONE";
            this.FUNFONE.HeaderText = "Fone";
            this.FUNFONE.Name = "FUNFONE";
            // 
            // FUNCELU
            // 
            this.FUNCELU.DataPropertyName = "FUNCELU";
            this.FUNCELU.HeaderText = "Celular";
            this.FUNCELU.Name = "FUNCELU";
            // 
            // FUNCEL1
            // 
            this.FUNCEL1.DataPropertyName = "FUNCEL1";
            this.FUNCEL1.HeaderText = "Celular1";
            this.FUNCEL1.Name = "FUNCEL1";
            // 
            // tbpdetalhamento
            // 
            this.tbpdetalhamento.Controls.Add(this.txtdtns);
            this.tbpdetalhamento.Controls.Add(this.cmbhornome);
            this.tbpdetalhamento.Controls.Add(this.cmbdepnome);
            this.tbpdetalhamento.Controls.Add(this.label9);
            this.tbpdetalhamento.Controls.Add(this.label8);
            this.tbpdetalhamento.Controls.Add(this.dtpdtna);
            this.tbpdetalhamento.Controls.Add(this.txtfuncpf);
            this.tbpdetalhamento.Controls.Add(this.label7);
            this.tbpdetalhamento.Controls.Add(this.cmbfucnome);
            this.tbpdetalhamento.Controls.Add(this.label6);
            this.tbpdetalhamento.Controls.Add(this.label5);
            this.tbpdetalhamento.Controls.Add(this.txtfunsala);
            this.tbpdetalhamento.Controls.Add(this.label4);
            this.tbpdetalhamento.Controls.Add(this.txtfunrg);
            this.tbpdetalhamento.Controls.Add(this.label3);
            this.tbpdetalhamento.Controls.Add(this.btnvoltar);
            this.tbpdetalhamento.Controls.Add(this.btnexcluir);
            this.tbpdetalhamento.Controls.Add(this.btngravar);
            this.tbpdetalhamento.Controls.Add(this.btnincluir);
            this.tbpdetalhamento.Controls.Add(this.txtfunnome);
            this.tbpdetalhamento.Controls.Add(this.txtfuncodi);
            this.tbpdetalhamento.Controls.Add(this.label2);
            this.tbpdetalhamento.Controls.Add(this.label1);
            this.tbpdetalhamento.Location = new System.Drawing.Point(4, 22);
            this.tbpdetalhamento.Name = "tbpdetalhamento";
            this.tbpdetalhamento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpdetalhamento.Size = new System.Drawing.Size(370, 319);
            this.tbpdetalhamento.TabIndex = 1;
            this.tbpdetalhamento.Text = "Detalhamento";
            this.tbpdetalhamento.UseVisualStyleBackColor = true;
            // 
            // txtdtns
            // 
            this.txtdtns.Location = new System.Drawing.Point(72, 83);
            this.txtdtns.Name = "txtdtns";
            this.txtdtns.Size = new System.Drawing.Size(127, 20);
            this.txtdtns.TabIndex = 45;
            // 
            // cmbhornome
            // 
            this.cmbhornome.FormattingEnabled = true;
            this.cmbhornome.Location = new System.Drawing.Point(70, 237);
            this.cmbhornome.Name = "cmbhornome";
            this.cmbhornome.Size = new System.Drawing.Size(250, 21);
            this.cmbhornome.TabIndex = 44;
            // 
            // cmbdepnome
            // 
            this.cmbdepnome.FormattingEnabled = true;
            this.cmbdepnome.Location = new System.Drawing.Point(70, 179);
            this.cmbdepnome.Name = "cmbdepnome";
            this.cmbdepnome.Size = new System.Drawing.Size(250, 21);
            this.cmbdepnome.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Depto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Horário:";
            // 
            // dtpdtna
            // 
            this.dtpdtna.CustomFormat = "dd/MM/yyyy";
            this.dtpdtna.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdtna.Location = new System.Drawing.Point(72, 109);
            this.dtpdtna.Name = "dtpdtna";
            this.dtpdtna.Size = new System.Drawing.Size(105, 20);
            this.dtpdtna.TabIndex = 9;
            this.dtpdtna.Value = new System.DateTime(2017, 4, 3, 0, 0, 0, 0);
            // 
            // txtfuncpf
            // 
            this.txtfuncpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfuncpf.Location = new System.Drawing.Point(213, 52);
            this.txtfuncpf.Name = "txtfuncpf";
            this.txtfuncpf.Size = new System.Drawing.Size(151, 20);
            this.txtfuncpf.TabIndex = 7;
            this.txtfuncpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPF:";
            // 
            // cmbfucnome
            // 
            this.cmbfucnome.FormattingEnabled = true;
            this.cmbfucnome.Location = new System.Drawing.Point(70, 210);
            this.cmbfucnome.Name = "cmbfucnome";
            this.cmbfucnome.Size = new System.Drawing.Size(250, 21);
            this.cmbfucnome.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Função:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salário (R$):";
            // 
            // txtfunsala
            // 
            this.txtfunsala.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunsala.Location = new System.Drawing.Point(70, 148);
            this.txtfunsala.Name = "txtfunsala";
            this.txtfunsala.Size = new System.Drawing.Size(107, 20);
            this.txtfunsala.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nascimento:";
            // 
            // txtfunrg
            // 
            this.txtfunrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunrg.Location = new System.Drawing.Point(47, 52);
            this.txtfunrg.Name = "txtfunrg";
            this.txtfunrg.Size = new System.Drawing.Size(104, 20);
            this.txtfunrg.TabIndex = 5;
            this.txtfunrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(285, 289);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 34;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(197, 289);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 33;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(102, 289);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 32;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(11, 289);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 31;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtfunnome
            // 
            this.txtfunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunnome.Location = new System.Drawing.Point(137, 25);
            this.txtfunnome.Name = "txtfunnome";
            this.txtfunnome.Size = new System.Drawing.Size(230, 20);
            this.txtfunnome.TabIndex = 3;
            // 
            // txtfuncodi
            // 
            this.txtfuncodi.Location = new System.Drawing.Point(47, 25);
            this.txtfuncodi.Name = "txtfuncodi";
            this.txtfuncodi.Size = new System.Drawing.Size(50, 20);
            this.txtfuncodi.TabIndex = 1;
            this.txtfuncodi.Leave += new System.EventHandler(this.txtfuncodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tbpcontato
            // 
            this.tbpcontato.Controls.Add(this.label19);
            this.tbpcontato.Controls.Add(this.txtfuncel1);
            this.tbpcontato.Controls.Add(this.label18);
            this.tbpcontato.Controls.Add(this.txtfuncelu);
            this.tbpcontato.Controls.Add(this.label17);
            this.tbpcontato.Controls.Add(this.txtfunfone);
            this.tbpcontato.Controls.Add(this.label16);
            this.tbpcontato.Controls.Add(this.label15);
            this.tbpcontato.Controls.Add(this.label14);
            this.tbpcontato.Controls.Add(this.label13);
            this.tbpcontato.Controls.Add(this.label12);
            this.tbpcontato.Controls.Add(this.lblpais);
            this.tbpcontato.Controls.Add(this.lbluf);
            this.tbpcontato.Controls.Add(this.lblmunicipio);
            this.tbpcontato.Controls.Add(this.lblbairro);
            this.tbpcontato.Controls.Add(this.label11);
            this.tbpcontato.Controls.Add(this.txtfunnume);
            this.tbpcontato.Controls.Add(this.lblendereco);
            this.tbpcontato.Controls.Add(this.label10);
            this.tbpcontato.Controls.Add(this.txtendcep);
            this.tbpcontato.Location = new System.Drawing.Point(4, 22);
            this.tbpcontato.Name = "tbpcontato";
            this.tbpcontato.Padding = new System.Windows.Forms.Padding(3);
            this.tbpcontato.Size = new System.Drawing.Size(370, 319);
            this.tbpcontato.TabIndex = 2;
            this.tbpcontato.Text = "Contato";
            this.tbpcontato.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 62;
            this.label19.Text = "Celular2:";
            // 
            // txtfuncel1
            // 
            this.txtfuncel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfuncel1.Location = new System.Drawing.Point(58, 216);
            this.txtfuncel1.Name = "txtfuncel1";
            this.txtfuncel1.Size = new System.Drawing.Size(85, 20);
            this.txtfuncel1.TabIndex = 63;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "Celular1:";
            // 
            // txtfuncelu
            // 
            this.txtfuncelu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfuncelu.Location = new System.Drawing.Point(58, 190);
            this.txtfuncelu.Name = "txtfuncelu";
            this.txtfuncelu.Size = new System.Drawing.Size(85, 20);
            this.txtfuncelu.TabIndex = 61;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "Fone:";
            // 
            // txtfunfone
            // 
            this.txtfunfone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunfone.Location = new System.Drawing.Point(58, 164);
            this.txtfunfone.Name = "txtfunfone";
            this.txtfunfone.Size = new System.Drawing.Size(85, 20);
            this.txtfunfone.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(134, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 55;
            this.label16.Text = "País:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "UF:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Município:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Endereço:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Bairro:";
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Location = new System.Drawing.Point(164, 120);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(29, 13);
            this.lblpais.TabIndex = 56;
            this.lblpais.Text = "País";
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(25, 120);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(21, 13);
            this.lbluf.TabIndex = 57;
            this.lbluf.Text = "UF";
            // 
            // lblmunicipio
            // 
            this.lblmunicipio.AutoSize = true;
            this.lblmunicipio.Location = new System.Drawing.Point(60, 98);
            this.lblmunicipio.Name = "lblmunicipio";
            this.lblmunicipio.Size = new System.Drawing.Size(54, 13);
            this.lblmunicipio.TabIndex = 53;
            this.lblmunicipio.Text = "Município";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(43, 78);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(34, 13);
            this.lblbairro.TabIndex = 51;
            this.lblbairro.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "nº:";
            // 
            // txtfunnume
            // 
            this.txtfunnume.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunnume.Location = new System.Drawing.Point(302, 50);
            this.txtfunnume.Name = "txtfunnume";
            this.txtfunnume.Size = new System.Drawing.Size(64, 20);
            this.txtfunnume.TabIndex = 49;
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(58, 57);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(53, 13);
            this.lblendereco.TabIndex = 47;
            this.lblendereco.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "CEP:";
            // 
            // txtendcep
            // 
            this.txtendcep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendcep.Location = new System.Drawing.Point(39, 30);
            this.txtendcep.Name = "txtendcep";
            this.txtendcep.Size = new System.Drawing.Size(85, 20);
            this.txtendcep.TabIndex = 45;
            this.txtendcep.Leave += new System.EventHandler(this.txtendcep_Leave);
            // 
            // frmfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcfuncionario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos Funcionários";
            this.Load += new System.EventHandler(this.frmfuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmfuncionario_KeyDown);
            this.tbcfuncionario.ResumeLayout(false);
            this.tbplistagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).EndInit();
            this.tbpdetalhamento.ResumeLayout(false);
            this.tbpdetalhamento.PerformLayout();
            this.tbpcontato.ResumeLayout(false);
            this.tbpcontato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcfuncionario;
        private System.Windows.Forms.TabPage tbplistagem;
        private System.Windows.Forms.DataGridView dgvfuncionario;
        private System.Windows.Forms.TabPage tbpdetalhamento;
        private System.Windows.Forms.ComboBox cmbdepnome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpdtna;
        private System.Windows.Forms.TextBox txtfuncpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbfucnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfunsala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfunrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtfunnome;
        private System.Windows.Forms.TextBox txtfuncodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpcontato;
        private System.Windows.Forms.ComboBox cmbhornome;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtfuncel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtfuncelu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtfunfone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.Label lblmunicipio;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfunnume;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtendcep;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNDTNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNSALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUCNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDENDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNNUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDCEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAINOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUNNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAINOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCELU;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNCEL1;
        private System.Windows.Forms.TextBox txtdtns;
    }
}