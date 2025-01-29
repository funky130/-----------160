public class BabyRoom : Room , IchecIn
{
    protected bool babycot;

    public BabyRoom(bool babycot,int basePrice, int numOfBeds, int capacity) 
    : base(basePrice,numOfBeds,capacity)
    {
        this.babycot = babycot;
    }

    public void Checkin()
    {

    }
}