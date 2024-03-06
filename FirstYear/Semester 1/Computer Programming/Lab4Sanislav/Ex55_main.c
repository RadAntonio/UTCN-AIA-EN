#include <stdio.h>
#include <stdlib.h>

int multiple(int a, int b) {

    if (b % a == 0)
        return 1;
        return 0;
}
int main()
{
    int c = 0, d = 0;
    printf("Introdce 1 pair of numbers (the second value is always bigger than the first one): ");
    scanf("%d %d", &c, &d);
    printf("%d", multiple(c,d));

    return 0;
}
