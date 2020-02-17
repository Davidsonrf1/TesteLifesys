using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TesteLS.CrudManaging
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class CrudDecoratorAttribute: Attribute
	{
		public CrudDecoratorAttribute ()
		{

		}

		public CrudDecoratorAttribute (string label)
		{
			Label = label;
		}

		public PropertyInfo Property { get; internal set; }
		public bool AllowEdit { get; set; } = true;
		public string Label { get; set; }
		public Type Control { get; set; }
		public int Width { get; set; } = 240;
	}
}
