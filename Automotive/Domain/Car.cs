namespace Domain;

public class Car
{
    public int Doors{get;set;}
    
    public Car(int doors)
    {
        Doors = doors;
    }
    public Car()
    {
        Doors = 0;
    }
}