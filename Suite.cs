public class Suite : Room
{
    protected int extraCrg;
    protected bool addbed;
    public Suite(int extraCrg, bool addbed,int basePrice, int numOfBeds, int capacity) 
    : base(basePrice,numOfBeds,capacity)
    {
        this.extraCrg = extraCrg;
        this.addbed = addbed;
    }
}