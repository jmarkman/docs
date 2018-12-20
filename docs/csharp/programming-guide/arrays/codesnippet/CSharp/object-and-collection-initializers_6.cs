            // The following code consolidates examples from the topic.
            class ObjInitializers
            {
                class Cat
                {
                    // Auto-implemented properties.
                    public int Age { get; set; }
                    public string Name { get; set; }
                }

                class Person
                {
                    // Auto-implemented properties.
                    public Cat PetCat { get; set; }
                    public string Name { get; set; }
                }

                class Shelter
                {
                    // Auto-implemented properties.
                    public Cat CatMascot { get; set; }
                    public List<Cat> Cats { get; set; }
                    public Person Supervisor { get; set; }

                    public override string ToString()
                    {
                        StringBuilder strBuilder = new StringBuilder();
                        strBuilder.Append($"The shelter's mascot is {CatMascot.Name}, who is {CatMascot.Age} years old.");
                        strBuilder.Append(Environment.NewLine);
                        strBuilder.Append($"There are {Cats.Count} cats in this shelter. They are:");
                        foreach (var cat in Cats)
                        {
                            strBuilder.Append($"{cat.Name}, who is {cat.Age} years old.");
                            strBuilder.Append(Environment.NewLine);
                        }
                        strBuilder.Append($"The supervisor of the shelter is {Supervisor.Name} and they own a cat named {Supervisor.PetCat.Name} who is {Supervisor.PetCat.Age} years old.");
                        return strBuilder.ToString();
                    }
                }

                static void Main()
                {
                    // Initializing a new Cat object
                    Cat cat = new Cat { Age = 10, Name = "Fluffy" };
                    
                    List<Cat> cats = new List<Cat>
                    {
                        new Cat(){ Name = "Sylvester", Age=8 },
                        new Cat(){ Name = "Whiskers", Age=2 },
                        new Cat(){ Name = "Sasha", Age=14 }
                    };

                    List<Cat> moreCats = new List<Cat>
                    {
                        new Cat(){ Name = "Furrytail", Age=5 },
                        new Cat(){ Name = "Peaches", Age=4 },
                        null
                    };

                    // Using nested object initialization with the Person class:
                    // Initializing a new Person class requires initializing a new Cat
                    Person person = new Person
                    {
                        PetCat = new Cat { Age = 2, Name = "Tiger" },
                        Name = "John Smith"
                    };

                    // Multiple nested initialization in action. Start by initializing a new Shelter:
                    Shelter catShelter = new Shelter
                    {
                        // Every good shelter needs a mascot, so we can create a new Cat for that:
                        CatMascot = new Cat { Age = 4, Name = "Blacktip"},

                        // What good is a shelter if no cats live in it? We can initialize a new list of cats
                        Cats = 
                        {
                            new Cat { Age = 5, Name = "Tom" },
                            new Cat { Age = 3, Name = "Sakamoto" }
                        },
                        // And someone's gotta lead the employees of the shelter!
                        Supervisor = new Person
                        {
                            PetCat = new Cat { Age = 6, Name = "Bruno" },
                            Name = "Sarah Katz"
                        }
                    };

                    // Display results.
                    System.Console.WriteLine($"{cat.Name} is {cat.Age} years old.");

                    foreach (Cat c in cats)
                        System.Console.WriteLine($"{c.Name} is {c.Age} years old.");

                    foreach (Cat c in moreCats)
                        if (c != null)
                            System.Console.WriteLine($"{c.Name} is {c.Age} years old.");
                        else
                            System.Console.WriteLine("List element has null value.");
                    System.Console.WriteLine($"{person.Name} has a cat named {person.PetCat.Name} who is {person.PetCat.Age} years old.");
                    System.Console.WriteLine(catShelter.ToString());
                }
                // Output:
                //Fluffy is 10 years old.
                //Sylvester is 8 years old.
                //Whiskers is 2 years old.
                //Sasha is 14 years old.
                //Furrytail is 5 years old.
                //Peaches is 4 years old.
                //List element has null value.
                //John Smith has a cat named Tiger who is 2 years old.
                //The shelter's mascot is Blacktip who is 4 years old.
                //There are 2 cats in the shelter. They are:
                //Tom, who is 5 years old.
                //Sakamoto, who is 3 years old.
                //The supervisor of the shelter is Sarah Katz and they own a cat named Bruno who is 6 years old.
            }