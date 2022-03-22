public class Animal
{
    public string theAnimalName;
    public string theAnimalType;
    public string theAnimalCountry;
    public double theAnimalCost;

    public Animal() { }

    public Animal(string animalName, string animalType, string animalCountry)
    {
        this.theAnimalName = animalName;
        this.theAnimalType = animalType;
        this.theAnimalCountry = animalCountry;
      
    }
    public string AnimalName
    {
        get { return theAnimalName; }
    }
    public string AnimalType
    {
        get { return theAnimalType; }
    }
    public string AnimalCountry
    {
        get { return theAnimalCountry; }
    }
    public double AnimalCost
    {
        get { return theAnimalCost; }
    }
    public void Cost(double monthlyCost)
    {
        if(monthlyCost > 60)
        {
            throw new ArgumentOutOfRangeException("Over Bugdet");
        }
        if(monthlyCost < 0)
        {
            throw new ArgumentOutOfRangeException("error");
        }
        this.theAnimalCost = 30 * monthlyCost;
    }
    public static void Main(string[] args)
    {
        Animal myAnimal = new Animal("Dog", " Pet", " Sweden");
        Console.Write(myAnimal.AnimalName);
        Console.Write(myAnimal.AnimalType);
        Console.Write(myAnimal.AnimalCountry);
        myAnimal.Cost(2);
        Console.WriteLine(" Monthly cost is ${0}", myAnimal.theAnimalCost);
        AnimalDetails myAnimalDetails = new AnimalDetails(" Cat", " Pet", "Denmark", " 6KG", " 45Cm");
        Console.Write(myAnimalDetails.AnimalName);
        Console.Write(myAnimalDetails.AnimalType);
        Console.Write(myAnimalDetails.AnimalCountry);
        Console.Write(myAnimalDetails.AnimalWeight);
        Console.Write(myAnimalDetails.AnimalSize);
        myAnimal.Cost(1);
        Console.Write(" Monthly cost is ${0}", myAnimal.theAnimalCost);

    }
}
class AnimalDetails : Animal
{
    public string theAnimalWeight;
    public string theAnimalSize;

    public AnimalDetails(string animalWeight, string animalSize, string animalName, string animalType, string animalCountry): base(animalName, animalType, animalCountry)
    {
        this.theAnimalWeight = animalWeight;
        this.theAnimalSize = animalSize;
    }
    public string AnimalWeight
    {
        get { return theAnimalWeight; }
    }
    public string AnimalSize
    {
        get { return theAnimalSize; }
    }

}

