namespace Chess {
    class Screen {
        public static void Print(Board board) {

            for (int r = 0; r < board.rows; r++) {
                Console.Write(8 - r + " ");
                for (int c = 0; c < board.columns; c++) {
                    if (board.piece(r, c) == null) {
                        Console.Write("- ");
                    }
                    else {
                        printPiece(board.piece(r, c));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void printPiece(Piece piece) {
            if (piece.color == Color.White) {
                Console.Write(piece);
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
