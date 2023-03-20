using System;
namespace CreationalDesignPatterns.Builder.Example1
{
    public class FighterAircraftBuilder : AircraftBuilder
	{
        IAircraft? aircraft;

        public FighterAircraftBuilder()
        {

        }

        public override void BuildCockpit()
        {
            Console.WriteLine("Build F-16 cockpit");
        }

        public override void BuildEngine()
        {
            Console.WriteLine("Build F-16 - 25 engines");
        }

        public override void BuildWings()
        {
            Console.WriteLine("Build F-16 4 wings");
        }

        public override IAircraft GetAircraft()
        {
            return this.aircraft;
        }

        public override void Assemble()
        {
            this.aircraft = new FighterAircraft();
        }
    }
}

