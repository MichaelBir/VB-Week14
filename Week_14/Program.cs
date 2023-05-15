Console.WriteLine("Name your dog:");
string myDogname = Console.ReadLine();
Dog mydog = new Dog(myDogname);
// mydog._name = "Good Dog";

Dog neighboursDog = new Dog("Good Gril");
// neighboursDog = "Good Girl";

Console.WriteLine($"My Dog name is {mydog}");
Console.WriteLine($"My neighbourd Dog name is {neighboursDog.Name}");

mydog.Rename("Bad Boy");

while (mydog.LevelOfHappiness != 5)
{
    mydog.Bark();
}

mydog.WagTail();



// Console.WriteLine($"Level of happiness {mydog.LevelOfHappiness}");

// mydog.Bark();
// Console.WriteLine($"Level of happiness: {mydog.LevelOfHappiness}");

class Dog
{
    public string _name = "Koer";
    public int _levelOfHappiness = 0;

    //constructor

    public Dog(string name) //name- lets the user name this dog
    {
        _name = name;
        _levelOfHappiness = 0;

    }

    //getter

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }
    public void Bark()
    {
        Console.WriteLine("Wolf-Wolf");
        _levelOfHappiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }
        
}
