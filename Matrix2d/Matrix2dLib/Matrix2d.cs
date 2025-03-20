namespace Matrix2dLib
{
    public class Matrix2d : IEquatable<Matrix2d>
    {
        private int[,] matrix;

        public Matrix2d(int a, int b, int c, int d)
        {
            matrix = new int[2, 2] { { a, b }, { c, d } };
        }

        public Matrix2d()
        {
            matrix = new int[2, 2] { { 1, 0 }, { 0, 1 } };
        }

        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }
        public static Matrix2d Id
        {     
            get { return new Matrix2d(); }
        }
            
        public static Matrix2d Zero
        {
            get { return new Matrix2d(0, 0, 0, 0); }
        }  
        public bool Equals(Matrix2d other)
        {
            if (other == null)
                return false;

            return matrix[0, 0] == other.matrix[0, 0] &&
                   matrix[0, 1] == other.matrix[0, 1] &&
                   matrix[1, 0] == other.matrix[1, 0] &&
                   matrix[1, 1] == other.matrix[1, 1];
        }
         
        public override bool Equals(object obj)
        {
            if (obj is Matrix2d other)
                return Equals(other);

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(matrix[0, 0], matrix[0, 1], matrix[1, 0], matrix[1, 1]);
        }

        public static bool operator ==(Matrix2d left, Matrix2d right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(Matrix2d left, Matrix2d right)
        {
            return !(left == right);
        }
    }
    
        
}

