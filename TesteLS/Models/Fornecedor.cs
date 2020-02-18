using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLS.Controllers;
using TesteLS.CrudManaging;

namespace TesteLS.Models
{
	public enum TipoFornecedor { PessoaFisica, PessoaJuridica }

	public class Fornecedor : ModelBase
	{
		[CrudDecorator("Código", AllowEdit = false, Width = 80)]
		public int FornecedorID { get; set; }

		[CrudDecorator("Nome", Width = 250)]
		public string Nome { get; set; }

		[CrudDecorator("Empresa", AllowEdit = true, Width = 80)]
		public Empresa EmpresaID { get; set; }

		[CrudDecorator("Cnpj/Cpf", Width = 80)]
		public string CnpjCpf { get; set; }

		[CrudDecorator("Data de Nascimento", Width = 80)]
		public DateTime DataNascimento { get; set; }

		[CrudDecorator("Tipo", AllowEdit = false, Width = 80)]
		public TipoFornecedor Tipo { get; set; }

		public override ControllerBase GetController()
		{
			return new FornecedorController();
		}
	}
}
