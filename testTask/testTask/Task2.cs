
namespace testTask
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }

        public override bool Equals(object? obj)
        {
            //не знаю что эфетивнее так сравнить или по хешу
            return obj is Car car &&
                   Model == car.Model &&
                   Color == car.Color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Color);
        }
        public override string ToString()
        {
            return $"model: {Model}\ncolor:{Color}\n{Description}";
        }
    }

    public class Task2 : ITestTask
    {
        private IList<Car> cars;
        public void SolveTask()
        {
            InitCars();
            while (true)
            {
                Console.WriteLine("1. show cars\n2. compare 2 cars\n3. getHashCode of car\n4.exit");
                string? input = Console.ReadLine();
                if(int.TryParse(input,out int myChoice))
                {
                    switch (myChoice)
                    {
                        case 1:
                            {
                                PrintCars();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine($"select cars indexes from [0-{cars.Count - 1}], space btw pls");
                                string inputCars = Console.ReadLine();
                                string[] partsOfInput = inputCars.Split(' ');
                                if(partsOfInput.Length < 2)
                                {
                                    Console.WriteLine("wrong input");
                                    continue;
                                }
                                if (int.TryParse(partsOfInput[0], out int firstIndex) && int.TryParse(partsOfInput[1], out int secondIndex))
                                {
                                    Console.WriteLine($"result={cars[firstIndex].Equals(cars[secondIndex])} car{firstIndex} and car{secondIndex}");
                                }
                                else
                                    Console.WriteLine("wrong input");

                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine($"select car index from 0-{cars.Count - 1}");
                                string inputIndex = Console.ReadLine();
                                if(int.TryParse(inputIndex,out int index))
                                {
                                    Console.WriteLine(cars[index].GetHashCode());
                                }
                                break;
                            }
                        case 4:
                            {
                                return;
                            }
                    }
                }
            }
        }

        private bool CompareCars(Car car1, Car car2)
        {
            return car1.Equals(car2);
        }

        private void PrintCars()
        {
            foreach (var car in cars)
                Console.WriteLine(car.ToString() + "\n");
        }

        private void InitCars()
        {
            cars = new List<Car>
            {
                new Car
                {
                    Model = "nissan juke",
                    Color = "black",
                    Description = "Топовая машина :D"
                },
                new Car
                {
                    Model = "nissan juke",
                    Color = "black",
                    Description = "еще одна Топовая машина xD"
                },
                new Car
                {
                    Model = "toyota camry",
                    Color = "white",
                    Description = "ну это дорога тачка просто"
                }
            };
        }
    }
}
