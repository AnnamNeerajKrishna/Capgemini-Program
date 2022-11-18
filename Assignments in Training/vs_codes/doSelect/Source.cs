using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doSelect
{
	class Source
	{
		public static void Main()
		{
			List<Person> per = new List<Person>();
			/*p.Add(new Person {p.Name="Aarya",p.Address="A2101",p.Age=69})
			p.Add(new Person{p.Name="Daniel",p.Address="D104",p.Age=40})
			p.Add(new Person{p.Name="Ira",p.Address="H801",p.Age=25})
			p.Add(new Person{p.Name="Jennifer",p.Address="I1704",p.Age=33})*/

			Person p1 = new Person("Aarya", "A2101", 69);
			Person p2 = new Person("Daniel", "D104", 40);
			Person p3 = new Person("Ira", "H801", 25);
			Person p4 = new Person("Jennifer", "I1704", 33);

			per.Add(p1);
			per.Add(p2);
			per.Add(p3);
			per.Add(p4);




			PersonImplementation pp = new PersonImplementation();
			Console.WriteLine(pp.GetName(per));
			Console.WriteLine(pp.Average(per));
			Console.WriteLine(pp.Max(per));
			Console.ReadKey();
		}
	}
	class PersonImplementation
	{
		public string GetName(IList<Person> l1)
		{
			string str = "";
			foreach (Person pe1 in l1)
			{
				str=str+pe1.Name + " " + pe1.Address+" ";
			}
			return str;
		}
		public double Average(IList<Person> l2)
		{
			double sum = 0;
			double cnt = l2.Count;

			foreach (Person pe2 in l2)
			{
				sum = sum + pe2.Age;
				//cnt++;
			}
			return sum / cnt;
			

		}
		public int Max(IList<Person> l3)
		{
			int max = 0;
			foreach (Person pe3 in l3)
			{
				if (pe3.Age >= max)
				{
					max = pe3.Age;
				}
			}
			return max;
		}
	}
	class Person
	{
		string name;
		string address;
		int age;
		public Person()
		{
			name = Name;
			address = Address;
			age = Age;

		}
		public Person(string Name, string Address, int Age)
		{
			name = Name;
			address = Address;
			age = Age;
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}

		}
		public string Address
		{
			get
			{
				return address;
			}
			set
			{
				address = value;
			}

		}
		public int Age
		{
			get
			{
				return age;
			}
			set
			{
				age = value;
			}
		}
	}
}
