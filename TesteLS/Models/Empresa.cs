using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteLS.Controllers;
using TesteLS.CrudManaging;

namespace TesteLS.Models
{
	public class Empresa: ModelBase
	{
		[CrudDecorator("Código", AllowEdit = false, Width = 80)]
		public int EmpresaID { get; set; }

		[CrudDecorator("Nome Fantasia", Control = typeof(TextBox), Width = 450)]
		public string NomeFantasia { get; set; }

		[CrudDecorator("Número CNPJ", Control = typeof(TextBox), Width = 190)]
		public string Cnpj { get; set; }

		public override ControllerBase GetController()
		{
			return new EmpresaController();
		}

		public override string ToString()
		{
			return $"{EmpresaID} - {NomeFantasia}";
		}
	}
}
