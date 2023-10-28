namespace Chess {
    class InternalPosition {
        public int row { get; set; }
        public int column { get; set; }

        public InternalPosition(int row, int column) {
            this.row = row;
            this.column = column;
        }

        public override string ToString() {
            return row + ", " + column;
        }
    }
}
