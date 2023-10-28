using Pieces;

namespace Chess {
    class Program {
        static void Main(string[] args) {
            try {
                Board board = new Board(8, 8);

                board.Add(new Tower(board, Color.Black), new InternalPosition(0, 0));
                board.Add(new Tower(board, Color.Black), new InternalPosition(0, 7));
                board.Add(new King(board, Color.Black), new InternalPosition(0, 2));
                board.Add(new King(board, Color.Black), new InternalPosition(0, 4));


                board.Add(new Tower(board, Color.White), new InternalPosition(7, 0));
                board.Add(new Tower(board, Color.White), new InternalPosition(7, 7));



                Screen.Print(board);
            }
            catch (BoardException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}