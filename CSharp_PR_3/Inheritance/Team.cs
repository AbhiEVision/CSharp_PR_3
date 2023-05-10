using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_PR_3.Inheritance
{
	public class Team : Sponsor
	{
		private string teamName = "Gujrat Titans";

		public string PrintInfo()
		{
			return teamName + " " + owner;
		}
	}
}
