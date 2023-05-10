namespace CSharp_PR_3.Abstraction
{
	public class Laptop
	{
		private string brand;
		private string model;

		public void LaptopDetails()
		{
			Console.WriteLine("Brand: " + brand);
			Console.WriteLine("Model: " + model);
		}

		private void MotherBoardInfo()
		{
			Console.WriteLine("MotherBoard Information");
		}

		public void SetBrand(string brand)
		{
			this.brand = brand;
		}

		public void SetModel(string model)
		{
			this.model = model;
		}

		public string GetBrand()
		{
			return this.brand;
		}
		public string GetModel()
		{
			return this.model;
		}

		public static void Main(string[] args)
		{
			Laptop laptop = new Laptop();
			laptop.SetBrand("Dell");
			laptop.SetModel("Inspiration 5570");
			laptop.LaptopDetails();
			laptop.MotherBoardInfo();
		}
	}
}
