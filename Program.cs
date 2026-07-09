using ConsoleAppTutorial;



while (true)
{
    Console.Write("Brand: ");
    string brand = Console.ReadLine();

    Console.Write("Model: ");
    string model = Console.ReadLine();

    int year;
    while (true)
    {
        Console.Write("Year: ");

        if (int.TryParse(Console.ReadLine(), out year))
            break;

        Console.WriteLine("Please enter a valid year.");
    }


    Console.Write("Owner: ");
    string owner = Console.ReadLine();


    Console.Write("VIN: ");
    string vin = Console.ReadLine();

    Console.Write("Engine Volume: ");
    double volume = double.Parse(Console.ReadLine());

    Console.Write("Horse Power: ");
    int horsePower = int.Parse(Console.ReadLine());

    Engine engine = new Engine(volume, horsePower);

    Car car = new Car(
        brand,
        model,
        year,
        owner,
        vin,
        engine
        );

    List<Car> cars = new List<Car>();
    cars.Add(car);


    Console.WriteLine("\n===== CAR INFO =====");

    Console.WriteLine($"Brand: {car.Brand}");
    Console.WriteLine($"Model: {car.Model}");
    Console.WriteLine($"Year: {car.Year}");
    Console.WriteLine($"Owner: {car.Owner}");
    Console.WriteLine($"Engine: {car.Engine.Volume}L");
    Console.WriteLine($"HP: {car.Engine.HorsePower}");


    Console.Write("\nAdd another car? (y/n): ");
    string answer = Console.ReadLine();


    if (answer.ToLower() != "y")
    {
        break;
    }


}








//Car car01 = new Car();
//Car car02 = new Car();

//car01.Brand = "BMW";
//car01.Color = "Red";
//car01.Driver = "John";
//car01.Drive();


//car02.Brand = "Pegout";
//car02.Color = "Silver";
//car02.Driver = "Michael";
//car02.Drive();

//Car car03 = new Car();

//car03.Brand = "Toyoto Prado";
//car03.Color = "White";
//car03.Driver = "Ramila";
//car03.Drive();

//Student student = new Student();
//Student student2 = new Student();

//student.FirstName = "Aflatun";
//student.LaststName = "Isayev";
//student.Age = 40;
//student.Course = 3;
//student.Skills = "Programming";
//student.Learning();



//student2.LaststName = "Isayev";
//student2.Age = 40;
//student2.Course = 3;
//student2.Skills = "Programming";
//student2.Learning();
//student2.FirstName = "Aflatun";

//Calculator cal = new Calculator();
//Calculator cal2 = new Calculator();
//Calculator cal3 = new Calculator();

//cal.Topla(5, 7);
//cal3.Topla(1, 425);
//cal2.Topla(5, 5);


//University student01 = new University("John", 18, "Çayxana dərsləri",100.5 );
//University student02 = new University("Smith", 21, "Komputer mühəndisliyi", 65.8);


//student01.ShowStudentInfo();
//Console.WriteLine();

//student02.ShowStudentInfo();
//Console.WriteLine();


//University.ShowUniversityInfo();


//Market market01 = new Market("Əhmədli Bravo", "Əhmədli metrosu tərəf");
//Market market02 = new Market("Koroğlu Bravo", "Korolu metrosu tərəf");



//market01.ShowBranchInfo();
//Console.WriteLine();

//market02.ShowBranchInfo();
//Console.WriteLine();


//Market.ShowMarketInfo();


//CarDealer car = new CarDealer("BMW", "320", "M-Sport", new DateTime(2025, 1, 1), 35000);
//CarDealer car1 = new CarDealer("Hyundai", "Elantra", "Limited", new DateTime(2025,1, 1 ), 30000);

//car.CarInfo();
//Console.WriteLine();

//car1.CarInfo();
//Console.WriteLine();

//CarDealer.DealerInfo();