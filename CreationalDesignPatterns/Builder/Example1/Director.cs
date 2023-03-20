namespace CreationalDesignPatterns.Builder.Example1;

public class Director
{
	public AircraftBuilder? aircraftBuilder;

    public Director()
    {

    }

    public void SetBuilder(AircraftBuilder? aircraftBuilder)
    {
        this.aircraftBuilder = aircraftBuilder;
    }

    public void BuildAircraft(bool isPassenger)
    {
        if (this.aircraftBuilder != null)
        {
            this.aircraftBuilder.BuildCockpit();
            this.aircraftBuilder.BuildEngine();
            this.aircraftBuilder.BuildWings();

            if (isPassenger)
            {
                this.aircraftBuilder.BuildWashroom();
            }

            this.aircraftBuilder.Assemble();
        }
    }
}

