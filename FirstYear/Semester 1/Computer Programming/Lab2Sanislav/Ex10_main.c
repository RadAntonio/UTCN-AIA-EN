#include <stdio.h>
#include <stdlib.h>

int main()
{
    int year = 0;

    printf ("Enter a year: ");
    scanf ("%d", &year);
    (year % 4 == 0 && year % 100 != 0 ) ? printf ("leap year") : (year % 400 == 0) ? printf ("leap year") : printf ("not leap year");
    return 0;
}
