namespace Domain;

public class Car
{
    private int _doors;
    public int Doors
    {
        get => _doors;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Doors), "Doors cannot be negative");
            _doors = value;
        }
    }

    public Car(int doors)
    {
        Doors = doors;
    }
    public Car()
    {
        Doors = 0;
    }
}