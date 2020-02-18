using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteLS.Models;

namespace TesteLS.CrudManaging
{
	public class EditorFactory
	{
		public static void Bind(ModelBase model, Control editor, DataContext ctx)
		{

		}

		public static Control CreateEditor(CrudDecoratorAttribute decorator, ModelBase model)
		{
			Control editor = null;

			var type = decorator.Property.PropertyType;

			if (type.Equals(typeof(DateTime)))
			{
				var p = new DateTimePicker();
				p.CustomFormat = "dd/MM/yyyy";
				editor = p;

				p.DataBindings.Add("Value", model, decorator.Property.Name);
			}

			if (typeof(ModelBase).IsAssignableFrom(type))
			{
				var cb = new ComboBox();
				cb.FormattingEnabled = true;

				var fd = (ModelBase)Activator.CreateInstance(type);

				cb.DataSource = fd.GetController().GetList();
				editor = cb;

				//cb.DataBindings.Add("Value", model, decorator.Property.Name);
			}

			if (type.IsEnum)
			{
				var gb = new GroupBox();

				var names = Enum.GetNames(type);

				foreach (var e in type.GetMembers())
				{
					if (!names.Contains(e.Name))
						continue;

					var a = e.GetCustomAttributes(typeof(DescriptionAttribute), false);
					string name = null;

					if (a != null && a.Length > 0)
					{
						name = ((DescriptionAttribute)a[0]).Description;
					}
					else
					{

					}
				}
			}

			if (editor == null)
				editor = new TextBox();

			return editor;
		}
	}
}
