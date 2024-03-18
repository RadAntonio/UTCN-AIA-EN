#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
    double a, b;
    a = 90.0;
    b = cos ( a * 3.14 / 180.0 );
    printf ("The cosine of %f degrees is %f.\n", a, b );

    double c, d;
    c = 90.0;
    d = sin (c*3.14/180);
    printf ("The sine of %f degrees is %f.\n", c, d );

    printf ("7 ^ 3 = %f\n", pow (7.0, 3.0) );
    printf ("4.73 ^ 12 = %f\n", pow (4.73, 12.0) );
    printf ("32.01 ^ 1.54 = %f\n", pow (32.01, 1.54) );

    double e, f;
    e = 1024.0;
    f = sqrt (e);
    printf ("sqrt(%f) = %f\n", e, f );

    double g, h;
    g = 5.5;
    h = log (h);
    printf ("log(%f) = %f\n", g, h );


    double i, j;
    i = 45.0;
    j = tan ( i * 3.14 / 180.0 );
    printf ("The tangent of %f degrees is %f.\n", i, j );

    return 0;
}
