using System;
namespace CreationalDesignPatterns.Builder.Example1
{
    public abstract class AircraftBuilder
	{
	    public AircraftBuilder()
		{
		}

        public abstract void BuildCockpit();

        public abstract void BuildWings();

        public virtual void BuildWashroom() { }

        public abstract void BuildEngine();

        public abstract IAircraft GetAircraft();

        public abstract void Assemble();
    }
}
