using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_3.Polymorphism
{
	public class Duck : Bird
	{
		public void Voice()
		{
            Console.WriteLine("Quack Quack");
        }
	}
}
