using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLS.CrudManaging;
using TesteLS.Models;
using Sirb.Documents.BR.Validation;

namespace TesteLS.Controllers
{
	public class FornecedorController : ControllerBase
	{
		class FornecedorValidator : ICrudValidator
		{
			public string Validate(ModelBase model, object value)
			{
				if (model is Fornecedor)
				{
					var f = (Fornecedor)model;

					if (f.Tipo == TipoFornecedor.PessoaFisica)
					{
						if (!CPF.IsValid(value.ToString()))
							return "CPF Inválido";

						if (DateTime.Now.AddYears(-18) < f.DataNascimento)
							return "Não é permitido cadastrar um fornecedor pessoa física menor de idade";
					}
					else
					{
						if (!CNPJ.IsValid(value.ToString()))
							return "CPJ Inválido";
					}
				}				

				return null;
			}
		}
		
		public FornecedorController()
		{
			SetValidators("CnpjCpf", new ICrudValidator[] { new FornecedorValidator(), new RequiredValidator() });
			SetValidators("Nome", new ICrudValidator[] { new RequiredValidator() });
			SetValidators("DataNascimento", new ICrudValidator[] { new RequiredValidator() });
		}
		
		public override void Save(ModelBase model)
		{
			using (var ctx = new DataContext())
			{
				var forn = ctx.Fornecedores.SingleOrDefault(e => e.FornecedorID == ((Fornecedor)model).FornecedorID);

				if (forn == null)
				{
					forn = (Fornecedor)model;
					ctx.Fornecedores.Add(forn);
				}
				else
				{
					CopyModel(model, forn);
				}

				ctx.SaveChanges();
			}
		}

		public override void Remove(ModelBase model)
		{
			using (var ctx = new DataContext())
			{
				var forn = ctx.Fornecedores.SingleOrDefault(e => e.FornecedorID == ((Fornecedor)model).FornecedorID);

				if (forn != null)
				{
					ctx.Fornecedores.Remove(forn);
					ctx.SaveChanges();
				}
			}
		}

		public override object GetList(Func<ModelBase, bool> filter) => Context.Fornecedores.Where<Fornecedor>(filter).ToList();	
	}
}
