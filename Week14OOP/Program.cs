Console.WriteLine("Name my dog");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Laika");

Console.WriteLine($"My dogs name is {myDog.Name}."); //paha - andmeid peab kaitsma, turvalisus
Console.WriteLine($"My neighbours dogs name {neighboursDog.Name}.");

myDog.Rename("Bad Dog");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTale();

class Dog
{
    private string _name; //field, private - public asemel
    private int _levelOfHapiness; //field, private - public asemel


    //constructor
    public Dog(string name) //lets the users names the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed: {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof");
        _levelOfHapiness++;
    }
    public void WagTale()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}

// Dog anotherDog = new Dog() - ei toimi klassist allpool