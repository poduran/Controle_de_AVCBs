using ControleDeAvcbs.Models;

namespace ControleDeAvcbs
{
    public partial class Form1 : Form
    {
        ContextBase ctx = new ContextBase();

        #region "FUNCOES"
        public void CarregarMainGridClientes()
        {
            grdClientes.DataSource = ctx.Clientes.Take(50).ToList();
            grdClientes.Refresh();
        }

        public void CarregarCombo()
        {
            cbmOrigens.DataSource = ctx.Origem.Select(x => x.Origens).ToList();
            cbmOrigens.Refresh();
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            CarregarCombo();
            cmbFilterType.Items.Add("Nome da Empresa");
            cmbFilterType.Items.Add("Nome do Cliente");
            cmbFilterType.Items.Add("Contato do Cliente");
            cmbFilterType.Items.Add("Numero AVCB");
            cmbFilterType.Items.Add("Origem");

            cmbFilterType.SelectedIndex = 0;

            dtpRegistre.Format = DateTimePickerFormat.Short;
            dtpData.Format = DateTimePickerFormat.Short;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarMainGridClientes();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes()
            {
                NomeEmpresa = txtNomeEmpresa.Text,
                NomeCliente = txtNomeCliente.Text,
                Contato = txtNumeroContato.Text,
                DataExpiracao = Convert.ToDateTime(dtpRegistre.Text),
                NumeroAVCB = txtNumeroAVCB.Text,
                Origem = cbmOrigens.Text
            };

            ctx.Clientes.Add(cli);
            ctx.SaveChanges();

            CarregarMainGridClientes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Clientes> cliList = new List<Clientes>();
            switch (cmbFilterType.SelectedIndex)
            {
                case 0:
                    cliList = (from cli in ctx.Clientes
                               where cli.NomeEmpresa.Contains(txtFiltroPesquisa.Text)
                               select cli).ToList();
                    break;
                case 1:
                    cliList = (from cli in ctx.Clientes
                               where cli.NomeCliente.Contains(txtFiltroPesquisa.Text)
                               select cli).ToList();
                    break;
                case 2:
                    cliList = (from cli in ctx.Clientes
                               where cli.Contato.Contains(txtFiltroPesquisa.Text)
                               select cli).ToList();
                    break;
                case 3:
                    cliList = (from cli in ctx.Clientes
                               where cli.NumeroAVCB.Contains(txtFiltroPesquisa.Text)
                               select cli).ToList();
                    break;
                case 4:
                    cliList = (from cli in ctx.Clientes
                               where cli.Origem.Contains(txtFiltroPesquisa.Text)
                               select cli).ToList();
                    break;
                default:
                    break;
            }
            cliList = cliList.Where(x => x.DataExpiracao <= DateTime.Now.AddDays(Convert.ToInt32(txtExpirateDays.Text))).ToList();
            grdSearchResult.DataSource = cliList.Count == 0 ? null : cliList;
            grdSearchResult.Refresh();

            //MessageBox.Show($"{cmbFilterType.SelectedItem.ToString()} - {cmbFilterType.SelectedIndex}");
        }

        private void txtClienteIdToDell_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtClienteIdToDell.Text == String.Empty) return;

                grdClientToDell.DataSource = ctx.Clientes.Where(x => x.ID == Convert.ToInt32(txtClienteIdToDell.Text)).ToList();
                grdClientToDell.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDellClient_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(grdClientToDell.Rows[0].Cells[0].Value.ToString());
            Clientes cli = ctx.Clientes.Where(x => x.ID == ID).FirstOrDefault();
            ctx.Clientes.Remove(cli);

            ctx.SaveChanges();

            CarregarMainGridClientes();

            MessageBox.Show("Cliente Apagado.");
        }

        private void btnAddOrigem_Click(object sender, EventArgs e)
        {
            ctx.Origem.Add(new Origem() { Origens = txtOrigemCadastro.Text});
            ctx.SaveChanges();
            CarregarCombo();
        }
    }
}