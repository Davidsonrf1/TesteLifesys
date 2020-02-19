using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLS.Models;

namespace TesteLS.CrudManaging
{
	public interface ICrudValidator
	{
		string Validate(ModelBase model, object value); // Se válido, retornar null. Caso contrário retornar o erro
	}
}
