#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a = 0;
    int b = 0;
    int c = 0;
    int d = 0;

    a = sizeof(int);
    b = sizeof(float);
    c = sizeof(double);
    d = sizeof(char);

    printf("%d \n", a);
    printf("%d \n", b);
    printf("%d \n", c);
    printf("%d \n", d);

    return 0;
}
