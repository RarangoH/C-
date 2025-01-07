public class Exercise
{
    public List<int> GetCountsOfAnimalsLegs()
    {
        var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

        var result = new List<int>();
        foreach (var animal in animals)
        {
            result.Add(animal.NumberOfLegs);
        }
        return result;
    }
    class Animal
    {
        public virtual int NumberOfLegs { get; }
    }
    class Lion: Animal
    {
        public override int NumberOfLegs => 4;
    }
    class Tiger : Animal
    {
        public override int NumberOfLegs => 4;
    }
    class Duck : Animal
    {
        public override int NumberOfLegs => 2;
    }
    class Spider : Animal
    {
        public override int NumberOfLegs => 8;
    }
}