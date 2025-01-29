public class Room : IClean
{
    public static int basePrice = 100;
    protected int numOfBeds;
    protected int capacity;

    public Room(int numOfBeds, int capacity)
    {
        this.numOfBeds = numOfBeds;
        this.capacity = capacity;
    }

    public void Clean()
    {

    }

}