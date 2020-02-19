using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLS.Models;

namespace TesteLS.CrudManaging
{
	public class RequiredValidator : ICrudValidator
	{
		public string Validate(ModelBase model, object value)
		{
			if ((value == null) || string.IsNullOrEmpty(value.ToString()))
			{
				return "Campo precisa ser informado";
			}

			return null;
		}
	}
}
