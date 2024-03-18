#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n = 0;
    float avEven = 0;
    int sumEven = 0;
    int even = 0;
    int odd = 0;
    int sumOdd = 0;
    float avOdd = 0;

    printf ("introdu valori pentru n: ");

    do{

        scanf ("%d", &n);
        if (n % 2 == 0 && n != 0) {

            sumEven = sumEven + n;
            even++;
        } else if (n % 2 != 0 && n != 0) {

            sumOdd = sumOdd + n;
            odd++;
        }

    }while (n != 0);

    avEven = sumEven / even;
    avOdd = sumOdd / odd;

    printf ("there are %d even numbers \n", even);
    printf ("the average of the even numbers is %.2f\n", avEven);
    printf ("there are %d odd numbers \n", odd);
    printf ("the average of the odd numbers is %.2f", avOdd);

    return 0;
}
