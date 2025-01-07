




//Dictionaries
var pets = new List<Pet>
        {
            new Pet(PetType.Dog, 15.5),
            new Pet(PetType.Cat, 4.3),
            new Pet(PetType.Fish, 0.25),
            new Pet(PetType.Fish, 2.8),
            new Pet(PetType.Dog, 0.1)
        };

SecondExercise.FindMaxWeights(pets);
public static class SecondExercise
{
    public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
    {
        Dictionary<int, List<double>> weightsXAnimal = new Dictionary<int, List<double>>();

        foreach (var animal in pets)
        {
            if (!weightsXAnimal.ContainsKey((int)animal.PetType))
            {
                weightsXAnimal[(int)animal.PetType] = new List<double>();
            }
            weightsXAnimal[(int)animal.PetType].Add(animal.Weight);
        }
        var result = new Dictionary<PetType, double>();

        foreach (var animalclass in weightsXAnimal)
        {
            double weight = 0;
            foreach (var item in animalclass.Value)
            {
                if(weight == 0 || weight < item)
                {
                    weight = item;
                }
            }
            result[(PetType)animalclass.Key] = weight;
         }
        Console.WriteLine(result);
        return result;
        

    }
}

public class Pet
{
    public PetType PetType { get; }
    public double Weight { get; }

    public Pet(PetType petType, double weight)
    {
        PetType = petType;
        Weight = weight;
    }

    public override string ToString() => $"{PetType}, {Weight} kilos";
}

public enum PetType { Dog, Cat, Fish }

