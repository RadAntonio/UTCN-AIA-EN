#include <stdio.h>
#include <stdlib.h>

int main()
{
    unsigned int n = 0;
    int i;
    int m;

    printf ("citeste o valoare pentru n: ");

    scanf ("%u", &n);

    for (i = 31; i >= 0; i--) {

        m = 1 << i;

        if ((n & m) == 0) {

            printf ("0");

        } else {

            printf ("1");

        }
    }
    return 0;
}
