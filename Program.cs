namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Serialization and Deserialazation..!");
            Console.WriteLine("\n1. Binary Serialization. \t2. Binary DeSerialization");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //Binary Serialization Operation
                case 1:
                    Serialization Opearion.BinarySerializationFn();
                    break;
                //Binary DeSerialization Operation
                case 2:
                    Serialization Opearion.BinaryDeSerializationFn();
                    break;
                default:
                    Console.WriteLine("Choose from given option Only");
                    break;
            }
            Console.ReadLine();
        }
    }
}
