using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TesteLS.Controllers;

namespace TesteLS.Models
{
	public abstract class ModelBase
	{
		public abstract ControllerBase GetController();
		
		public object ValueFromString(PropertyInfo prop, string value)
		{


			return null;
		}

		public string ValueToString(PropertyInfo prop, string value)
		{
			return null;
		}

		public void SetValue(PropertyInfo prop, object value)
		{

		}
	}
}
