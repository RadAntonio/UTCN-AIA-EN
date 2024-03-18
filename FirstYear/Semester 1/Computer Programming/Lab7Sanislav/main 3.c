#include <stdio.h>
#include <stdlib.h>

int main()
{
    enum number {zero, one, two,three, four, five};
    enum number x, y;
    int z = 0, w = 0;

    x = two;
    y = three;
    z = x + y;
    w = x * y;
    printf ("z = %d w = %d\n", z, w);
    return 0;
}
