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

		public override object GetList(Func<ModelBase, bool> filter) => Context.Empresas.Where<Empresa>(filter).ToList();

		public override void OnSave(ModelBase model)
		{
			using(var ctx = new DataContext())
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
