using System;
namespace CreationalDesignPatterns.Builder.Example1
{
	public class BuilderExample1
	{
		public BuilderExample1()
		{
			
        }

		public static void Demo()
		{
            Director director = new Director();

            AircraftBuilder fighterAircraftbuilder = new FighterAircraftBuilder();
            director.SetBuilder(fighterAircraftbuilder);
            director.BuildAircraft(false);
            IAircraft figherAircraft = fighterAircraftbuilder.GetAircraft();

            AircraftBuilder passengerAircraftBuilder = new PassengerAircraftBuilder();
            director.SetBuilder(passengerAircraftBuilder);
            director.BuildAircraft(true);
            IAircraft passengerAircraft = passengerAircraftBuilder.GetAircraft();
        }
	}
}

