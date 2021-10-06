namespace Calculator_Package
{
    public class Calculator
    {
        //Methods for int
        public int AddInt(int a, int b)
        {
            if(a.GetType() != typeof(int) && b.GetType() != typeof(int))
            {
                return 0;
            }
            return a + b;
        }

        public int AddInt(int a, int b, int c)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int) && c.GetType() != typeof(int))
            {
                return 0;
            }
            return a + b + c;
        }

        public int AddInt(int a, int b, int c, int d)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int) && c.GetType() != typeof(int) && d.GetType() != typeof(int))
            {
                return 0;
            }
            return a + b + c + d;
        }

        //Methods for double
        public double AddDouble(double a, double b)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double))
            {
                return 0;
            }
            return a + b;
        }

        public double AddDouble(double a, double b, double c)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double) && c.GetType() != typeof(double))
            {
                return 0;
            }
            return a + b + c;
        }

        public double AddDouble(double a, double b, double c, double d)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double) && c.GetType() != typeof(double) && d.GetType() != typeof(double))
            {
                return 0;
            }
            return a + b + c + d;
        }

        //Methods for int
        public int MultiplyInt(int a, int b)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int))
            {
                return 0;
            }
            return a * b;
        }

        public int MultiplyInt(int a, int b, int c)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int) && c.GetType() != typeof(int))
            {
                return 0;
            }
            return a * b * c;
        }

        public int MultiplyInt(int a, int b, int c, int d)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int) && c.GetType() != typeof(int) && d.GetType() != typeof(int))
            {
                return 0;
            }
            return a * b * c * d;
        }

        //Methods for double
        public double MultiplyDouble(double a, double b)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double))
            {
                return 0;
            }
            return a * b;
        }

        public double MultiplyDouble(double a, double b, double c)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double) && c.GetType() != typeof(double))
            {
                return 0;
            }
            return a * b * c;
        }

        public double MultiplyDouble(double a, double b, double c, double d)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double) && c.GetType() != typeof(double) && d.GetType() != typeof(double))
            {
                return 0;
            }
            return a * b * c * d;
        }

        //Methods for int
        public int MinusInt(int a, int b)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int))
            {
                return 0;
            }
            return a - b;
        }

        public int MinusInt(int a, int b, int c)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int) && c.GetType() != typeof(int))
            {
                return 0;
            }
            return a - b - c;
        }

        public int MinusInt(int a, int b, int c, int d)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int) && c.GetType() != typeof(int) && d.GetType() != typeof(int))
            {
                return 0;
            }
            return a - b - c - d;
        }

        //Methods for double
        public double MinusDouble(double a, double b)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double))
            {
                return 0;
            }
            return a - b;
        }

        public double MinusDouble(double a, double b, double c)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double) && c.GetType() != typeof(double))
            {
                return 0;
            }
            return a - b - c;
        }

        public double MinusDouble(double a, double b, double c, double d)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double) && c.GetType() != typeof(double) && d.GetType() != typeof(double))
            {
                return 0;
            }
            return a - b - c - d;
        }

        public int DividedInt(int a, int b)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int))
            {
                return 0;
            }
            return a / b;
        }

        public int DividedInt(int a, int b, int c)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int) && c.GetType() != typeof(int))
            {
                return 0;
            }
            return a / b / c;
        }

        public int DividedInt(int a, int b, int c, int d)
        {
            if (a.GetType() != typeof(int) && b.GetType() != typeof(int) && c.GetType() != typeof(int) && d.GetType() != typeof(int))
            {
                return 0;
            }
            return a / b / c / d;
        }

        //Methods for double
        public double DividedDouble(double a, double b)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double))
            {
                return 0;
            }
            return a / b;
        }

        public double DividedDouble(double a, double b, double c)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double) && c.GetType() != typeof(double))
            {
                return 0;
            }
            return a / b / c;
        }

        public double DividedDouble(double a, double b, double c, double d)
        {
            if (a.GetType() != typeof(double) && b.GetType() != typeof(double) && c.GetType() != typeof(double) && d.GetType() != typeof(double))
            {
                return 0;
            }
            return a / b / c / d;
        }
    }
}
