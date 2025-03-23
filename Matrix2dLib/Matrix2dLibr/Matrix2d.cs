#nullable disable
namespace Matrix2dLibr
{
    public class Matrix2d : IEquatable<Matrix2d>
    {
        readonly int a, b, c, d;
        public Matrix2d(int a, int b, int c, int d)
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
        }
        public Matrix2d() : this(1, 0, 0, 1) { }

        public static Matrix2d Id
        {
            get { return new Matrix2d(); }
        }
        public static Matrix2d Zero
        {
            get { return new Matrix2d(0, 0, 0, 0); }
        }
        public override string ToString()
        {
            return $"[[{a}, {b}], [{c}, {d}]]";
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Matrix2d);
        }
        public bool Equals(Matrix2d other)
        {
            if (other is null)
                return false;

            return a == other.a &&
                b == other.b &&
                c == other.c &&
                d == other.d;
        }
        public static bool operator ==(Matrix2d left, Matrix2d right)
            => left.Equals(right);
        public static bool operator !=(Matrix2d left, Matrix2d right)
            => !(left == right);
        public override int GetHashCode()
           => HashCode.Combine(a, b, c, d);
        public static Matrix2d operator +(Matrix2d left, Matrix2d right)
            => new Matrix2d(left.a + right.a, left.b + right.b,
                            left.c + right.c, left.d + right.d);
        public static Matrix2d operator -(Matrix2d left, Matrix2d right)
           => new Matrix2d(left.a - right.a, left.b - right.b,
                           left.c - right.c, left.d - right.d);
        public static Matrix2d operator *(Matrix2d left, Matrix2d right)
            => new Matrix2d(
                left.a * right.a + left.b * right.c,
                left.a * right.b + left.b * right.d,
                left.c * right.a + left.d * right.c,
                left.c * right.b + left.d * right.d);
        public static Matrix2d operator *(int k, Matrix2d macierz)
            => new Matrix2d(k * macierz.a, k * macierz.b,
                            k * macierz.c, k * macierz.d);

        public static Matrix2d operator *(Matrix2d macierz, int k) => k * macierz;
        public static Matrix2d operator -(Matrix2d macierz) => new Matrix2d(-macierz.a, -macierz.b, -macierz.c, -macierz.d);
        public static Matrix2d Transpose(Matrix2d m) => new Matrix2d(m.a, m.c, m.b, m.d);
        public int Determinant() => a * d - b * c;
        public int Det() => Determinant();

        public static explicit operator int[,](Matrix2d m) => new int[,] { { m.a, m.b }, { m.c, m.d } }; 
        public static Matrix2d Parse(string s)
        {
            try
            {
                var parts = s.Trim('[', ']').Split(new[] { "], [" }, StringSplitOptions.None);
                var firstRow = parts[0].Split(',');
                var secondRow = parts[1].Split(',');

                return new Matrix2d(
                    int.Parse(firstRow[0].Trim()),
                    int.Parse(firstRow[1].Trim()),
                    int.Parse(secondRow[0].Trim()),
                    int.Parse(secondRow[1].Trim())
                );
            }
            catch
            {
                throw new FormatException("Invalid format for Matrix2d.");
            }
        }
    }
}