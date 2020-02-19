using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLS.CrudManaging;
using TesteLS.Models;

namespace TesteLS.Controllers
{
	public class ValidateResult
	{
		public string Field { get; set; }
		public string Message { get; set; }
	}

	public abstract class ControllerBase
	{
		public DataContext Context { get; private set; }

		protected ControllerBase()
		{
			Context = new DataContext();
		}

		Dictionary<string, IEnumerable<ICrudValidator>> _validators = new Dictionary<string, IEnumerable<ICrudValidator>>();
		public void SetValidators(string field, IEnumerable<ICrudValidator> validators)
		{
			_validators[field] = validators;
		}
		public IEnumerable<ValidateResult> CallValidators(ModelBase model)
		{
			List<ValidateResult> result = new List<ValidateResult>();

			foreach (var p in model.GetType().GetProperties())
			{
				if (_validators.TryGetValue(p.Name, out IEnumerable<ICrudValidator> validators))
				{
					foreach (var v in validators)
					{
						var value = p.GetValue(model);
						var vm = v.Validate(model, value);

						if (vm != null)
						{
							result.Add(new ValidateResult()
							{
								Field = p.Name,
								Message = vm
							});
						}
					}
				}
			}

			return result;
		}
		public virtual List<ValidateResult> OnValidate(ModelBase model) => (List<ValidateResult>)CallValidators(model);
		public void CopyModel(ModelBase origin, ModelBase dest)
		{
			if (origin.GetType().Equals(dest.GetType()))
			{
				foreach (var p in origin.GetType().GetProperties())
				{
					var value = p.GetValue(origin);
					p.SetValue(dest, value);
				}
			}
		}
		public abstract void OnSave(ModelBase model);

		public abstract object GetList(Func<ModelBase, bool> filter);
		public object GetList() => GetList(e => true);
	}
}
