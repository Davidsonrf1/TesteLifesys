using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirb.Documents.BR.Validation;

namespace TesteLS.CrudManaging
{
	public class CnpjValidator : ICrudValidator
	{
		public string Validate(object value)
		{
			if (value == null || !CNPJ.IsValid(value.ToString()))
				return "CNPJ Inválido!";

			return null;
		}
	}
}
