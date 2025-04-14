namespace LiveCoding
{

    public class Complex
    {
        private double _real;
        private double _imaginary;

        public Complex(double real = 0, double imaginary = 0)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public double Modulus() {
            return Math.Sqrt(_real * _real + _imaginary * _imaginary);
        }

        public override string ToString()
        {
            return $"{_real} + {_imaginary}i";
        }

    }

}