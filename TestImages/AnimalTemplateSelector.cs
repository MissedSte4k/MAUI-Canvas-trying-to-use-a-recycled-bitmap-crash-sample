using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestImages
{
	public class AnimalTemplateSelector : DataTemplateSelector
	{
		public DataTemplate OneAnimal { get; set; }
		public DataTemplate MultipleAnimals { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var animal = item as Animal;
			
			if (animal.Images.Count == 1)
				return OneAnimal;
			if (animal.Images.Count > 1)
				return MultipleAnimals; 

			return base.SelectTemplate(item, container);
		}
	}
}
