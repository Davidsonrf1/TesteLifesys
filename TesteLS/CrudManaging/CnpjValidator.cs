using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirb.Documents.BR.Validation;
using TesteLS.Models;

namespace TesteLS.CrudManaging
{
	public class CnpjValidator : ICrudValidator
	{
		public string Validate(ModelBase model, object value)
		{
			if (value == null || !CNPJ.IsValid(value.ToString()))
				return "CNPJ Inválido!";

			return null;
		}
	}
}
