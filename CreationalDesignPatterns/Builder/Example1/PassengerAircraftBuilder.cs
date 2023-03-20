using System;
namespace CreationalDesignPatterns.Builder.Example1
{
	public class PassengerAircraftBuilder : AircraftBuilder
	{
        IAircraft? aircraft = new PassengerAircraft();

        public PassengerAircraftBuilder()
        {
        }

        public override void BuildCockpit()
        {
            Console.WriteLine("Build Boeing 757 - cockpit");
        }

        public override void BuildEngine()
        {
            Console.WriteLine("Build Boeing 757 - 2 engines");
        }

        public override void BuildWashroom()
        {
            Console.WriteLine("Build Boeing 757 - 4 washrooms");
        }

        public override void BuildWings()
        {
            Console.WriteLine("Build Boeing 757 - 2 wings");
        }

        public override IAircraft GetAircraft()
        {
            return this.aircraft;
        }

        public override void Assemble()
        {
            this.aircraft = new PassengerAircraft();
        }
    }
}

