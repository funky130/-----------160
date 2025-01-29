public class Suite : Room
{
    protected int extraCrg;
    protected bool addbed;
    public Suite(int extraCrg, int numOfBeds, int capacity, bool addbed)
    : base(numOfBeds,capacity)
    {
        this.extraCrg = extraCrg;
        this.addbed = addbed;
    }
}