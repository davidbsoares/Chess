using Rules;

namespace Chess {
    class Program {
        static void Main(string[] args) {

            Position pos = new Position('a', 1);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosition());

            Console.ReadLine();

        }
    }
}