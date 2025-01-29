public class BabyRoom : Room , IchecIn
{
    protected bool babycot;

    public BabyRoom(int numOfBeds, int capacity, bool babycot) 
    : base(numOfBeds,capacity)
    {
        this.babycot = babycot;
    }

    public void Checkin()
    {

    }
}