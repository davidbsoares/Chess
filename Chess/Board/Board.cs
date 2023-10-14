namespace Chess.Board {
    class Board {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int lines, int columns) {
            this.rows = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }
    }
}
