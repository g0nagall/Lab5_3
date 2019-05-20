using System;

namespace lab5_3
{
	class Program
	{
		class Ship
		{

			protected string name;

			protected string purpose;

			protected string vodotonage;

			protected double enginePower;

			protected string fuelType;

			public Ship(string name, string purpose, string vodoton, double enginePower, string fuelType)
			{

				this.name = name;

				this.purpose = purpose;

				this.vodotonage = vodoton;

				this.enginePower = enginePower;

				this.fuelType = fuelType;

			}

			public virtual void Output()
			{

				Console.WriteLine("Name: " + name);

				Console.WriteLine("Purpose: " + purpose);

				Console.WriteLine("Vodotonage: " + vodotonage);

				Console.WriteLine("Engine Power: " + enginePower);

				Console.WriteLine("Type of fuel: " + fuelType);

			}

		}
		class Aviator : Ship
		{

			private string typeAvia;

			private int amount;

			public Aviator(string name, string purpose, string vodoton, double enginePower, string fuelType, string typeAvia, int amount) : base(name, purpose, vodoton, enginePower, fuelType)
			{

				this.typeAvia = typeAvia;

				this.amount = amount;

			}

			public override void Output()
			{
				base.Output();

				Console.WriteLine("Type of aviation: " + typeAvia);

				Console.WriteLine("Amount of avia: " + amount);

			}

		}
		class RocketLauncher : Ship
		{

			private string typeRacket;

			private int amount;

			public RocketLauncher(string name, string purpose, string vodoton, double enginePower, string fuelType, string typeRacket, int amount) : base(name, purpose, vodoton, enginePower, fuelType)
			{

				this.typeRacket = typeRacket;
				this.amount = amount;

			}

			public override void Output()
			{

				base.Output();

				Console.WriteLine("Type of rackets: " + typeRacket);

				Console.WriteLine("Amount of rockets: " + amount);

			}

		}
		static void Main(string[] args)
		{
			Ship obj1 = new Aviator("GS-015", "war", "100", 1500, "soliara", "SIG-505", 15);

			Ship obj2 = new RocketLauncher("IL-54", "oborona", "115", 1000, "euro95", "Atom-1", 40);

			obj1.Output();

			Console.WriteLine();

			obj2.Output();

		}
	}
	}

