﻿using System.Collections.Generic;

namespace SnakeGame
{
    public class Position
    {
        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column) 
        {
            Row = row;
            Column = column;
        }

        public Position Translate(Directions direction)
        {
            return new Position(Row + direction.RowOffset, Column + direction.ColumnOffset);
        }

        public override bool Equals(object? obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public static bool operator ==(Position? left, Position? right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position? left, Position? right)
        {
            return !(left == right);
        }
    }
}