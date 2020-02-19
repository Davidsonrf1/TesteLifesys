using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

		public class EnumMap
		{
			public string Name { get; set; }
			public object Value { get; set; }

			public override string ToString() => Name;
		}

		public static Control CreateEditor(CrudDecoratorAttribute decorator, ModelBase model)
		{
			Control editor = null;

			var type = decorator.Property.PropertyType;

			if (type.Equals(typeof(DateTime)))
			{
				var p = new DateTimePicker();
				p.CustomFormat = "dd/MM/yyyy";
				p.Format = DateTimePickerFormat.Short;
				editor = p;

				p.DataBindings.Add("Value", model, decorator.Property.Name);
			}

			string pn = decorator.Property.Name;

			if (pn.ToLower().EndsWith("id"))
			{
				var tp = Type.GetType($"{model.GetType().Namespace}.{pn.Substring(0, pn.Length-2)}", false, true);

				if (tp != null && !tp.Equals(model.GetType()))
				{
					var cb = new ComboBox();
					cb.FormattingEnabled = true;

					var fd = (ModelBase)Activator.CreateInstance(tp);

					cb.DataSource = fd.GetController().GetList();
					editor = cb;

					PropertyInfo id = null;

					foreach (var p in tp.GetProperties())
					{
						if (p.Name.Equals($"{tp.Name}id", StringComparison.CurrentCultureIgnoreCase))
						{
							id = p;
							break;
						}
					}

					if (id != null)
						cb.ValueMember = id.Name;

					cb.DataBindings.Add("SelectedValue", model, pn);
				}
			}

			if (type.IsEnum)
			{
				var cb = new ComboBox();

				var names = Enum.GetNames(type);
				var values = Enum.GetValues(type);
				List<EnumMap> map = new List<EnumMap>();

				int index = 0;

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
						name = e.Name;
					}

					map.Add(new EnumMap() { Name = name, Value = values.GetValue(index) });
					index++;
				}

				cb.DataSource = map;
				cb.ValueMember = "Value";

				cb.DataBindings.Add("SelectedValue", model, decorator.Property.Name);

				editor = cb;
			}

			if (editor == null)
			{
				editor = new TextBox();
				editor.DataBindings.Add("Text", model, decorator.Property.Name);
			}

			return editor;
		}
	}
}
