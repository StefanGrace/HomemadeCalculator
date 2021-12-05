namespace HomemadeCalculator
{
    class Calculator
    {
        /**
         * Homemade calculator using only subtraction. 
         * Can perform addition, subtraction, multiplication, division (rounds up), power.
         * Multiplication, division and power only work on non-negative integers.
         */

        public int minus(int a, int b)
        {
            return a - b;
        }

        public int add(int a, int b)
        {
            return minus(a, (minus(0, b)));
        }

        public int multiply(int a, int b)
        {
            int c = 0;
            for (int i = 0; i < b; i = add(i, 1))
            {
                c = add(c, a);
            }
            return c;
        }

        public int divide(int a, int b)
        {
            int c = a;
            int i = 0;
            while (c > 0)
            {
                c = minus(c, b);
                i = add(i, 1);
            }
            return i;
        }

        public int power(int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i = add(i, 1))
            {
                c = multiply(c, a);
            }
            return c;
        }
    }
}
