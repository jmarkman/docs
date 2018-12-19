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
                    public string SupervisorName { get; set; }
                }

                static void Main()
                {
                    // Initializing a new Cat object
                    Cat cat = new Cat { Age = 10, Name = "Fluffy" };
                    
                    // Using nested object initialization with the Person class:
                    // Initializing a new Person class requires initializing a new Cat
                    Person person = new Person
                    {
                        PetCat = new Cat { Age = 2, Name = "Tiger" },
                        Name = "John Smith"
                    };

                    // Multiple nested initialization in action
                    Shelter catShelter = new Shelter
                    {
                        CatMascot = new Cat { Age = 4, Name = "Blacktip"},
                        Cats = new List<Cat>
                        {
                            new Cat { Age = 5, Name = "Tom" },
                            new Cat { Age = 3, Name = "Sakamoto" }
                        },
                        SupervisorName = "Sarah Katz"
                    };

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

                    // Display results.
                    System.Console.WriteLine(cat.Name);

                    foreach (Cat c in cats)
                        System.Console.WriteLine(c.Name);

                    foreach (Cat c in moreCats)
                        if (c != null)
                            System.Console.WriteLine(c.Name);
                        else
                            System.Console.WriteLine("List element has null value.");
                }
                // Output:
                //Fluffy
                //Sylvester
                //Whiskers
                //Sasha
                //Furrytail
                //Peaches
                //List element has null value.
            }