using System;

namespace PiMonteCarlo
{// namespace

    // struct to hold x,y coordinates as doubles
    struct GridStruct
    {// struct

        public double X { get; set; }
        public double Y { get; set; }

        // constructor holding x,y coordinates
        public GridStruct (double p1, double p2)
        {
            X = p1;
            Y = p2;
        }

        // constructor takes random object and nextDoubles x,y coordinates
        public GridStruct (Random ranObj)
        {
            X = ranObj.NextDouble();
            Y = ranObj.NextDouble();
        }

    }// struct

    class MonteCarlo
    {// class

        static void Main(string[] args)
        {// Main() start

            // receive and initialize array length
            Console.WriteLine("Enter number of points (10, 100, 1000, 10000) : ");
            int size = Convert.ToInt32(Console.ReadLine());

            double piApproximation = 0;
            double numInCircle = 0;

            // initialize multidimensional array
            GridStruct[,] rngCoords = new GridStruct[size, 2];

            // populate array with random x,y
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    rngCoords[i, j] = new GridStruct(rng);
                }
            }

            // iterate over array
            foreach (GridStruct point in rngCoords)
            {
                // determine if point in circle
                if (GetHypotenuse(point) <= 1.0)
                {
                    // increment if in circle
                    ++numInCircle;
                }
            }

            // determine approximate pi
            piApproximation = 4.0 * (numInCircle / rngCoords.Length);

            // calculate absolute value difference
            double absDiff = Math.Abs(piApproximation - Math.PI);

            Console.WriteLine("Pi calculated with {0} random points.", size);
            Console.WriteLine("Approximated Pi = {0}", piApproximation);
            Console.WriteLine("\nDifference calculated between approximate and actual Pi.");
            Console.WriteLine("Absolute difference = {0}", absDiff);

            Console.Read();

        }// Main() stop

        // initialize random number generator
        static public Random rng = new Random();

        // function takes x,y struct and returns hypotenuse
        static double GetHypotenuse(GridStruct coords)
        {// GetHypotenuse() start

            double hypotenuse = Math.Sqrt(coords.X * coords.X + coords.Y * coords.Y);
            return hypotenuse;

        }// GetHypotenuse() stop

    }// class

}// namespace


