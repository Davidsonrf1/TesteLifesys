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
		[CrudDecorator("Código: ", AllowEdit = false, Width = 80)]
		public int FornecedorID { get; set; }

		[CrudDecorator("Nome: ", Width = 250)]
		public string Nome { get; set; }

		[CrudDecorator("Cnpj/Cpf: ", AllowEdit = false, Width = 80)]
		public string CnpjCpf { get; set; }

		[CrudDecorator("Data de Nascimento: ", AllowEdit = false, Width = 80)]
		public DateTime DataNascimento { get; set; }

		public override ControllerBase GetController(string field)
		{
			throw new NotImplementedException();
		}
	}
}
