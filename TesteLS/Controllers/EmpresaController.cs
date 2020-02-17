using System;
using System.Collections.Generic;
using System.Linq;
using TesteLS.CrudManaging;
using TesteLS.Models;

namespace TesteLS.Controllers
{
	public class EmpresaController : ControllerBase
	{
		public EmpresaController()
		{
			SetValidators("NomeFantasia", new ICrudValidator[] { new RequiredValidator() });
			SetValidators("Cnpj", new ICrudValidator[] {
				new RequiredValidator(),
				new CnpjValidator()
			});
		}

		public override List<ModelBase> LoadList<T>(DataContext ctx, Func<ModelBase, bool> filter) 
		{
			if (filter == null)
				filter = e => true;

			var list = ctx.Empresas.Where(m => true).ToList();

			List<ModelBase> ret = new List<ModelBase>();

			foreach (var e in list)
				ret.Add(e);

			return ret;
		}

		public override void OnLoad()
		{
			
		}

		public override void OnSave(ModelBase model)
		{
			using(var ctx = Program.CreateContext())
			{
				var emp = ctx.Empresas.SingleOrDefault(e => e.EmpresaID == ((Empresa)model).EmpresaID);

				if (emp == null)
				{
					emp = (Empresa)model;
					ctx.Empresas.Add(emp);
				}
				else
				{
					CopyModel(model, emp);
				}

				ctx.SaveChanges();
			}
		}
	}
}
