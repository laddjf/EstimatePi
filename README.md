# EstimatePi

Project assignment with following requirements:


1. create struct to hold x,y coordinates as doubles.  provide 2-parameter constructor which takes new set of coordinates and a 1-parameter constructor which takes Random object and uses NextDouble() to initialize X,Y.

2. create function which takes x,y coordinate struct and returns double corresponding to hypotenuse of triangle with sides length x,y.

3. build main method which takes one int parameter from command line and creates array of that length containing randomly initialized coordinates.

4. iterate over array, incrementing a counter for each coordinate which overlaps unit circle.

5. using Length parameter of array, divide number of coordinates overlapping unit circle by number of array elements.  multiply returned value by 4.

6. print value from step 4. along with absolute value of difference between estimate and Math.Pi.

7. run program, passing 10, 100, 1000, and 10000 as the command line parameter.  record output of program.
