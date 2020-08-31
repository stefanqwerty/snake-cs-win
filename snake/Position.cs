using System;
using System.Collections.Generic;

namespace Snake
{
    public class Position : IComparable
    {
        public int column;
        public int row;

        public Position(int sendColumn, int sendRow) => (column, row) = (sendColumn, sendRow);

        public bool IsOutOfGame(int columns, int rows) => row < 0
                                                        || row >= rows
                                                        || column < 0
                                                        || column >= columns;

        #region Implementing IComparable
        public int CompareTo(object obj) => 0;

        public bool Equals(Position other) => column == other.column && row == other.row;
        #endregion
    }

    public class PositionComparer : IEqualityComparer<Position>
    {
        public bool Equals(Position x, Position y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(Position pos)
        {
            int hCode = pos.column * 10000 + pos.row;
            return hCode;
        }
    }
}
