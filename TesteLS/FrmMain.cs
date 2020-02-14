using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteLS.Models;

namespace TesteLS
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
			DoubleBuffered = true;

			WindowState = FormWindowState.Maximized;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnEmpresa_Click(object sender, EventArgs e)
		{
			var crud = CrudManaging.Crud.CreateCrud<Empresa>("Cadastro de Empresas", "Empresa");
			crud.SetContainer(pnlMainContainer);
		}

		private void btnFornecedores_Click(object sender, EventArgs e)
		{
			var crud = CrudManaging.Crud.CreateCrud<Fornecedor>("Cadastro de Fornecedores", "Fornecedor");
			crud.SetContainer(pnlMainContainer);
		}
	}
}
