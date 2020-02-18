using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLS.CrudManaging;
using TesteLS.Models;

namespace TesteLS.Controllers
{
	public class FornecedorController : ControllerBase
	{
		class CpfFornecedorValidator : ICrudValidator
		{
			public string Validate(object value)
			{
				return null;
			}
		}

		public FornecedorController()
		{

		}

		public override void OnSave(ModelBase model)
		{

		}

		public override object GetList(Func<ModelBase, bool> filter) => Context.Fornecedores.Where<Fornecedor>(filter).ToList();	
	}
}
