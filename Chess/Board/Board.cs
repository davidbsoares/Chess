namespace Chess {
    class Board {
        public int rows { get; set; }
        public int columns { get; set; }
        private Piece[,] pieces;

        public Board(int rows, int columns) {
            this.rows = rows;
            this.columns = columns;
            pieces = new Piece[rows, columns];
        }

        public Piece piece(int rows, int columns) {
            return pieces[rows, columns];
        }

        public Piece piece(InternalPosition pos) {
            return pieces[pos.row, pos.column];
        }

        public bool pieceExists(InternalPosition pos) {
            validatePos(pos);
            return piece(pos) != null;
        }

        public void Add(Piece p, InternalPosition pos) {
            if (pieceExists(pos)) {
                throw new BoardException("There is already another piece in this position");
            }
            pieces[pos.row, pos.column] = p;
            p.position = pos;
        }

        public bool posValid(InternalPosition pos) {
            if (pos.row < 0 || pos.row >= rows || pos.column < 0 || pos.column >= columns) return false;
            return true;
        }

        public void validatePos(InternalPosition pos) {
            if (!posValid(pos)) {
                throw new BoardException("Invalid Position");
            }
        }
    }
}
