using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_PickerObservableDemo.Models
{
    public class Person
    {
		private string name;
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

        public Person(string _name, int _age)
        {
            name = _name;
			age = _age;
        }
    }
}
