#include <stdio.h>
#include <stdlib.h>

int main()
{
    float a = 0;
    float b = 0;

    printf("introdu 2 numere:");
    scanf("%f %f", &a, &b);
    printf("suma este: %f\n", a + b);
    printf("dif este: %f\n", a - b);
    printf("prod este: %f\n", a * b);
    printf("slash este: %f\n", a / b);
    return 0;
}
