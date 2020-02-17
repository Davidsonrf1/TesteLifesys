using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteLS.Models;

namespace TesteLS.CrudManaging
{
	public class Crud
	{
		public CrudDetail Detail { get; private set; }
		public CrudList List { get; private set; }
		public Type ModelType { get; private set; }
		public List<ModelBase> Dataset { get; private set; }
		public ModelBase EditingModel { get; internal set; }
		public Control Container { get; private set; }

		private Crud(Type type, string listTitle, string detailTitle)
		{
			Detail = new CrudDetail(this, detailTitle);
			List = new CrudList(this, listTitle);
			ModelType = type;

			Init();
		}

		IEnumerable<CrudDecoratorAttribute> GetDecorators()
		{
			foreach (var p in GetModelFields())
			{
				var a = p.GetCustomAttribute<CrudDecoratorAttribute>();

				if (a == null)
				{
					a = new CrudDecoratorAttribute();
					a.Label = p.Name;
					a.Control = typeof(TextBox);
				}

				a.Property = p;
				yield return a;
			}
		}

		IEnumerable<PropertyInfo> GetModelFields()
		{
			foreach (var p in ModelType.GetProperties())
			{
				yield return p;
			}
		}

		void InitListColumns()
		{
			List.ClearColumns();

			foreach (var d in GetDecorators())
			{
				List.AddColumn(d.Label, d.Width);
			}
		}

		void CreateEditForm()
		{
			Detail.ClearFields();

			foreach (var d in GetDecorators())
			{
				if (!d.AllowEdit)
					continue;

				Detail.AddField(d);
			}
		}

		Crud Init()
		{
			InitListColumns();
			CreateEditForm();

			return this;
		}

		public static Crud CreateCrud<T>(string listTitle, string detailTitle) where T : ModelBase, new() => new Crud(typeof(T), listTitle, detailTitle);
		internal ModelBase CreateModel() => (ModelBase)Activator.CreateInstance(ModelType);

		public void SetContainer(Control container)
		{
			Container = container;
			ShowList();
		}

		public Type GetDefaulEditor(Type type)
		{
			if (typeof(DateTime).IsAssignableFrom(type))
				return typeof(DateTimePicker);

			return typeof(TextBox);
		}

		internal void ShowList()
		{
			Detail.Visible = false;

			Container.Controls.Clear();
			Container.Controls.Add(List);

			List.Visible = true;
			List.LoadList();
		}

		internal void ShowDetail()
		{
			List.Visible = false;

			Container.Controls.Clear();
			Container.Controls.Add(Detail);
			
			Detail.Model = EditingModel;

			Detail.Visible = true;
		}
	}
}
