namespace TCFQ.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ArgumentError();
                return;
            }
            if (!ushort.TryParse(args[0], out ushort examId))
            {
                ArgumentError();
                return;
            }

            Head();
            new MyExam(examId).Start();

            Console.ReadKey();
        }

        static void Head()
        {
            Console.Clear();
            Console.WriteLine("TCFQ - Oral Comprehension");
            Console.WriteLine(new string('*', 30));
        }

        static void ArgumentError()
        {
            Head();
            Console.WriteLine("Error executing the program: exam number is expected.");
            Console.WriteLine($"Example: {ThisExe()} 3");
            Console.WriteLine("To run the program considering the answers from exam 3");
            Console.ReadKey();
        }

        static string ThisExe()
        {
            return Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule!.FileName);
        }
    }
}
