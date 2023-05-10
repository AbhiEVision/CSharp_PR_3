using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_3.Polymorphism
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Bird myBird = new Bird();

			Bird myDuck = new Duck();

			myBird.Voice();

			myDuck.Voice();
		}
	}
}
