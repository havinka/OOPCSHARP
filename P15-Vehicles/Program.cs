namespace P15_Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle v1 = CreateVehicle(Console.ReadLine());
            Vehicle v2 = CreateVehicle(Console.ReadLine());

            Console.WriteLine(v1);
            Console.WriteLine(v2);

            int n = int.Parse(Console.ReadLine());

            Vehicle current = null;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string cmd = input[0];
                string type = input[1];
                double amount =double.Parse(Console.ReadLine());

                current = type == nameof(Car) ? v1 : v2;

                string result = cmd == "Refuel" ? current.Refuel(amount) : current.Drive((int)amount);

                Console.WriteLine(result);
            }

        }

        public static Vehicle CreateVehicle(string input)
        {
            string[] info = input.Split(" ");
            string type = info[0];
            double fuelQuantity = double.Parse(info[1]);
            double fuelConsumption = double.Parse(info[2]);

            switch (type)
            {
                case nameof(Car):
                    return new Car(fuelQuantity, fuelConsumption);
                case nameof(Truck):
                    return new Truck(fuelQuantity, fuelConsumption)
    ;
                default:
                    return null;
            }


        }
    }
}

