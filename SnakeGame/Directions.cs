using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeGame
{
    public class Directions
    {

        // Static Direction instances representing common directions.
        public readonly static Directions Left = new Directions(0, -1);
        public readonly static Directions Right = new Directions(0, 1);
        public readonly static Directions Up = new Directions(-1, 0);
        public readonly static Directions Down = new Directions(1, 0);

        // Row and column offsets for the direction.
        public int RowOffset {  get; }
        public int ColumnOffset { get; }

        // Constructor to initialize the direction with row and column offsets.
        private Directions(int RowOffset, int ColumnOffset) 
        {
            this.RowOffset = RowOffset;
            this.ColumnOffset = ColumnOffset;
        }

        // Get the opposite direction. The '-' negates the values of the Offset variables, creating the opposite direction
        public Directions Opposite()
        {
            return new Directions(-RowOffset, -ColumnOffset);
        }

        // Check for equality between two Directions objects.
        // Override of the Equals method, which is inherited from the System.Object class.
        // Takes an object parameter, allowing it to compare an instance of "Directions" with any other object.
        // Inside, it checks whether the provided object is also an instance of "Directions" and if its RowOffset and ColumnOffset values match the values of the current instance.
        // If these conditions are met, it returns true, indicating that the instances are equal; otherwise, it returns false.
        public override bool Equals(object? obj)
        {
            return obj is Directions directions &&
                   RowOffset == directions.RowOffset &&
                   ColumnOffset == directions.ColumnOffset;
        }

        // Calculate a hash code for a Directions object.
        // Override of the GetHashCode method, which is inherited from the System.Object class.
        // It calculates a hash code for an instance of "Directions" based on its RowOffset and ColumnOffset values.
        // The HashCode.Combine method is used to combine these values into a single hash code.
        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColumnOffset);
        }

        // Custom equality operator for Directions objects.
        // Equality operator that compares two instances of "Directions" for equality.
        // It allows you to use the == operator to compare two "Directions" objects.
        // It uses the EqualityComparer to determine if the instances are equal.
        public static bool operator ==(Directions? left, Directions? right)
        {
            return EqualityComparer<Directions>.Default.Equals(left, right);
        }

        // Custom inequality operator for Directions objects.
        // Inequality operator and is the complement of the equality operator.
        // It simply negates the result of the equality operator (==) to determine if the instances are not equal.
        // It allows you to use the != operator to compare two "Directions" objects.
        public static bool operator !=(Directions? left, Directions? right)
        {
            return !(left == right);
        }
    }
}
