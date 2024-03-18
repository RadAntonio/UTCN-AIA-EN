#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n = 0;
    int sum = 0;

    printf("citeste o valoare pentru n: ");

    scanf ("%d", &n);

    if (n < -1) {

        sum = n * n + 4 * n + 8;

    } else if (n == -1) {

        sum = 0;

    } else if (n > -1) {

        sum = n * n - 5 * n + 1;

    }
    printf("%d", sum);
    return 0;
}
