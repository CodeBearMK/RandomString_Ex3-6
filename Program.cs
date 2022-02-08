namespace RandomString_Ex3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] person = { "郭靖", "張無忌", "令狐沖", "段譽" };
            string[] location = { "在桃花島", "在明教", "在華山", "在中原" };
            string[] DoWhat = { "學九陽神功。", "當教主。", "練孤獨九劍。", "到處留情。" };
            Random rnd = new Random();

            Console.Write("\t某某人\t\t");
            Console.Write("\t在哪裡\t\t");
            Console.WriteLine("\t做什麼");

            Console.Write("\t============\t");
            Console.Write("\t============\t");
            Console.WriteLine("\t====================");

            Console.Write("\t{0}\t\t",person[rnd.Next(0, person.Length - 1)]);
            Console.Write("\t{0}\t\t\t",location[rnd.Next(0, location.Length - 1)]);
            Console.Write("{0}",DoWhat[rnd.Next(0, DoWhat.Length - 1)]);
            Console.Read();
        }
    }
}