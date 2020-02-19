using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLS.Controllers;
using TesteLS.CrudManaging;

namespace TesteLS.Models
{
	public enum TipoFornecedor
	{
		[Description("Física")]
		PessoaFisica,

		[Description("Jurídica")]
		PessoaJuridica
	}

	public class Fornecedor : ModelBase
	{
		[CrudDecorator("Código", AllowEdit = false, Width = 80)]
		public int FornecedorID { get; set; }

		[CrudDecorator("Nome", Width = 450)]
		public string Nome { get; set; }

		[CrudDecorator("Empresa", Width = 250)]
		public int EmpresaID { get; set; }

		[CrudDecorator("Cnpj/Cpf", Width = 190)]
		public string CnpjCpf { get; set; }

		[CrudDecorator("Data de Nascimento", Width = 200)]
		public DateTime DataNascimento { get; set; } = DateTime.Now;

		[CrudDecorator("Tipo", Width = 150, EnumMap = new string[] { "Física","Juridica" })]
		public TipoFornecedor Tipo { get; set; }

		public override ControllerBase GetController()
		{
			return new FornecedorController();
		}

		public override string TranslateEnum(string name)
		{
			if (TipoFornecedor.PessoaFisica.ToString().Equals(name))
				return "Física";

			if (TipoFornecedor.PessoaJuridica.ToString().Equals(name))
				return "Jurídica";

			return base.TranslateEnum(name);
		}

		public override string ToString()
		{
			return $"{FornecedorID} - {Nome}";
		}
	}
}
