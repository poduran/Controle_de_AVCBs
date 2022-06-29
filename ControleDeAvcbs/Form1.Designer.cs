namespace ControleDeAvcbs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpMain = new System.Windows.Forms.TabPage();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.tmpPesquisa = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpirateDays = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtFiltroPesquisa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.grdSearchResult = new System.Windows.Forms.DataGridView();
            this.tbpAdd = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddOrigem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrigemCadastro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmOrigens = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.dtpRegistre = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtNumeroAVCB = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroContato = new System.Windows.Forms.TextBox();
            this.tbpApagar = new System.Windows.Forms.TabPage();
            this.btnDellClient = new System.Windows.Forms.Button();
            this.asterisco = new System.Windows.Forms.Label();
            this.txtClienteIdToDell = new System.Windows.Forms.TextBox();
            this.grdClientToDell = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.tmpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchResult)).BeginInit();
            this.tbpAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientToDell)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpMain);
            this.tabControl1.Controls.Add(this.tmpPesquisa);
            this.tabControl1.Controls.Add(this.tbpAdd);
            this.tabControl1.Controls.Add(this.tbpApagar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpMain
            // 
            this.tbpMain.Controls.Add(this.grdClientes);
            this.tbpMain.Location = new System.Drawing.Point(4, 24);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMain.Size = new System.Drawing.Size(768, 398);
            this.tbpMain.TabIndex = 0;
            this.tbpMain.Text = "Todos os Clientes";
            this.tbpMain.UseVisualStyleBackColor = true;
            // 
            // grdClientes
            // 
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(0, 6);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.RowTemplate.Height = 25;
            this.grdClientes.Size = new System.Drawing.Size(772, 392);
            this.grdClientes.TabIndex = 0;
            // 
            // tmpPesquisa
            // 
            this.tmpPesquisa.Controls.Add(this.label8);
            this.tmpPesquisa.Controls.Add(this.txtExpirateDays);
            this.tmpPesquisa.Controls.Add(this.dtpData);
            this.tmpPesquisa.Controls.Add(this.label7);
            this.tmpPesquisa.Controls.Add(this.btnSearch);
            this.tmpPesquisa.Controls.Add(this.label);
            this.tmpPesquisa.Controls.Add(this.txtFiltroPesquisa);
            this.tmpPesquisa.Controls.Add(this.label6);
            this.tmpPesquisa.Controls.Add(this.cmbFilterType);
            this.tmpPesquisa.Controls.Add(this.grdSearchResult);
            this.tmpPesquisa.Location = new System.Drawing.Point(4, 24);
            this.tmpPesquisa.Name = "tmpPesquisa";
            this.tmpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tmpPesquisa.Size = new System.Drawing.Size(768, 398);
            this.tmpPesquisa.TabIndex = 1;
            this.tmpPesquisa.Text = "Pesquisar";
            this.tmpPesquisa.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Vencimento em dias";
            // 
            // txtExpirateDays
            // 
            this.txtExpirateDays.Location = new System.Drawing.Point(489, 35);
            this.txtExpirateDays.Name = "txtExpirateDays";
            this.txtExpirateDays.Size = new System.Drawing.Size(114, 23);
            this.txtExpirateDays.TabIndex = 9;
            this.txtExpirateDays.Text = "30";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(373, 35);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(110, 23);
            this.dtpData.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(687, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 41);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(177, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(33, 15);
            this.label.TabIndex = 4;
            this.label.Text = "Valor";
            // 
            // txtFiltroPesquisa
            // 
            this.txtFiltroPesquisa.Location = new System.Drawing.Point(177, 35);
            this.txtFiltroPesquisa.Name = "txtFiltroPesquisa";
            this.txtFiltroPesquisa.Size = new System.Drawing.Size(190, 23);
            this.txtFiltroPesquisa.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filtro";
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(6, 35);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(165, 23);
            this.cmbFilterType.TabIndex = 1;
            // 
            // grdSearchResult
            // 
            this.grdSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchResult.Location = new System.Drawing.Point(6, 64);
            this.grdSearchResult.Name = "grdSearchResult";
            this.grdSearchResult.RowTemplate.Height = 25;
            this.grdSearchResult.Size = new System.Drawing.Size(756, 328);
            this.grdSearchResult.TabIndex = 0;
            // 
            // tbpAdd
            // 
            this.tbpAdd.Controls.Add(this.groupBox2);
            this.tbpAdd.Controls.Add(this.groupBox1);
            this.tbpAdd.Location = new System.Drawing.Point(4, 24);
            this.tbpAdd.Name = "tbpAdd";
            this.tbpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdd.Size = new System.Drawing.Size(768, 398);
            this.tbpAdd.TabIndex = 2;
            this.tbpAdd.Text = "Adicionar";
            this.tbpAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddOrigem);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtOrigemCadastro);
            this.groupBox2.Location = new System.Drawing.Point(6, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 148);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adicionar Origem";
            // 
            // btnAddOrigem
            // 
            this.btnAddOrigem.Location = new System.Drawing.Point(304, 37);
            this.btnAddOrigem.Name = "btnAddOrigem";
            this.btnAddOrigem.Size = new System.Drawing.Size(75, 67);
            this.btnAddOrigem.TabIndex = 14;
            this.btnAddOrigem.Text = "Adicionar";
            this.btnAddOrigem.UseVisualStyleBackColor = true;
            this.btnAddOrigem.Click += new System.EventHandler(this.btnAddOrigem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Origem";
            // 
            // txtOrigemCadastro
            // 
            this.txtOrigemCadastro.Location = new System.Drawing.Point(6, 37);
            this.txtOrigemCadastro.Name = "txtOrigemCadastro";
            this.txtOrigemCadastro.Size = new System.Drawing.Size(292, 23);
            this.txtOrigemCadastro.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmOrigens);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAddCliente);
            this.groupBox1.Controls.Add(this.dtpRegistre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNomeEmpresa);
            this.groupBox1.Controls.Add(this.txtNumeroAVCB);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumeroContato);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 232);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Cliente";
            // 
            // cbmOrigens
            // 
            this.cbmOrigens.FormattingEnabled = true;
            this.cbmOrigens.Location = new System.Drawing.Point(304, 125);
            this.cbmOrigens.Name = "cbmOrigens";
            this.cbmOrigens.Size = new System.Drawing.Size(292, 23);
            this.cbmOrigens.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Origem do Cliente";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(304, 154);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(75, 67);
            this.btnAddCliente.TabIndex = 10;
            this.btnAddCliente.Text = "Adicionar";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // dtpRegistre
            // 
            this.dtpRegistre.Location = new System.Drawing.Point(6, 125);
            this.dtpRegistre.Name = "dtpRegistre";
            this.dtpRegistre.Size = new System.Drawing.Size(126, 23);
            this.dtpRegistre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero do AVCB";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(6, 37);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(292, 23);
            this.txtNomeEmpresa.TabIndex = 0;
            // 
            // txtNumeroAVCB
            // 
            this.txtNumeroAVCB.Location = new System.Drawing.Point(304, 81);
            this.txtNumeroAVCB.Name = "txtNumeroAVCB";
            this.txtNumeroAVCB.Size = new System.Drawing.Size(292, 23);
            this.txtNumeroAVCB.TabIndex = 8;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(304, 37);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(292, 23);
            this.txtNomeCliente.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de Expiração do AVCB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero de contato";
            // 
            // txtNumeroContato
            // 
            this.txtNumeroContato.Location = new System.Drawing.Point(6, 81);
            this.txtNumeroContato.Name = "txtNumeroContato";
            this.txtNumeroContato.Size = new System.Drawing.Size(292, 23);
            this.txtNumeroContato.TabIndex = 4;
            // 
            // tbpApagar
            // 
            this.tbpApagar.Controls.Add(this.btnDellClient);
            this.tbpApagar.Controls.Add(this.asterisco);
            this.tbpApagar.Controls.Add(this.txtClienteIdToDell);
            this.tbpApagar.Controls.Add(this.grdClientToDell);
            this.tbpApagar.Location = new System.Drawing.Point(4, 24);
            this.tbpApagar.Name = "tbpApagar";
            this.tbpApagar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpApagar.Size = new System.Drawing.Size(768, 398);
            this.tbpApagar.TabIndex = 3;
            this.tbpApagar.Text = "Apagar Cliente";
            this.tbpApagar.UseVisualStyleBackColor = true;
            // 
            // btnDellClient
            // 
            this.btnDellClient.Location = new System.Drawing.Point(249, 6);
            this.btnDellClient.Name = "btnDellClient";
            this.btnDellClient.Size = new System.Drawing.Size(75, 38);
            this.btnDellClient.TabIndex = 3;
            this.btnDellClient.Text = "Apagar";
            this.btnDellClient.UseVisualStyleBackColor = true;
            this.btnDellClient.Click += new System.EventHandler(this.btnDellClient_Click);
            // 
            // asterisco
            // 
            this.asterisco.AutoSize = true;
            this.asterisco.Location = new System.Drawing.Point(6, 3);
            this.asterisco.Name = "asterisco";
            this.asterisco.Size = new System.Drawing.Size(149, 15);
            this.asterisco.TabIndex = 2;
            this.asterisco.Text = "ID do cliente a ser apagado";
            // 
            // txtClienteIdToDell
            // 
            this.txtClienteIdToDell.Location = new System.Drawing.Point(6, 21);
            this.txtClienteIdToDell.Name = "txtClienteIdToDell";
            this.txtClienteIdToDell.Size = new System.Drawing.Size(100, 23);
            this.txtClienteIdToDell.TabIndex = 1;
            this.txtClienteIdToDell.TextChanged += new System.EventHandler(this.txtClienteIdToDell_TextChanged);
            // 
            // grdClientToDell
            // 
            this.grdClientToDell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientToDell.Location = new System.Drawing.Point(6, 81);
            this.grdClientToDell.Name = "grdClientToDell";
            this.grdClientToDell.RowTemplate.Height = 25;
            this.grdClientToDell.Size = new System.Drawing.Size(756, 60);
            this.grdClientToDell.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.tmpPesquisa.ResumeLayout(false);
            this.tmpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchResult)).EndInit();
            this.tbpAdd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpApagar.ResumeLayout(false);
            this.tbpApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientToDell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpMain;
        private TabPage tmpPesquisa;
        private TabPage tbpAdd;
        private DataGridView grdClientes;
        private Label label1;
        private TextBox txtNomeEmpresa;
        private Label label5;
        private TextBox txtNumeroAVCB;
        private Label label4;
        private Label label3;
        private TextBox txtNumeroContato;
        private Label label2;
        private TextBox txtNomeCliente;
        private Button btnAddCliente;
        private Button btnSearch;
        private Label label;
        private TextBox txtFiltroPesquisa;
        private Label label6;
        private ComboBox cmbFilterType;
        private DataGridView grdSearchResult;
        private DateTimePicker dtpData;
        private Label label7;
        private DateTimePicker dtpRegistre;
        private Label label8;
        private TextBox txtExpirateDays;
        private TabPage tbpApagar;
        private Button btnDellClient;
        private Label asterisco;
        private TextBox txtClienteIdToDell;
        private DataGridView grdClientToDell;
        private GroupBox groupBox2;
        private Button btnAddOrigem;
        private Label label10;
        private TextBox txtOrigemCadastro;
        private GroupBox groupBox1;
        private ComboBox cbmOrigens;
        private Label label9;
    }
}