using Chess;

namespace Rules {
    class Position {
        public char column { get; set; }
        public int row { get; set; }

        public Position(char column, int line) {
            this.column = column;
            this.row = line;
        }

        public InternalPosition toPosition() {
            return new InternalPosition(8 - row, column - 'a');
        }

        public override string ToString() {
            return "" + column + row;
        }
    }
}
