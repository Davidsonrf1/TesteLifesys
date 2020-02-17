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
				throw new NotImplementedException();
			}
		}

		public FornecedorController()
		{

		}

		public override void OnSave(ModelBase model)
		{
			
		}

		public override List<ModelBase> LoadList<T>(DataContext ctx, Func<ModelBase, bool> filter)
		{
			if (filter == null)
				filter = e => true;

			var list = ctx.Fornecedores.Where(m => true).ToList();

			List<ModelBase> ret = new List<ModelBase>();

			foreach (var e in list)
				ret.Add(e);

			return ret;
		}
	}
}
