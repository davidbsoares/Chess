namespace Chess {
    internal class Screen {
        public static void Print(Board board) {

            for (int r = 0; r < board.rows; r++) {
                for (int c = 0; c < board.columns; c++) {
                    if (board.piece(r, c) == null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(board.piece(r, c) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
