#include <stdio.h>
#include <stdlib.h>

int main()
{
    double value1 = 50.0;
    double value2;
    double *double_ptr;

    double_ptr = &value1;
    printf("%lf\n", *double_ptr);

    value2 = *double_ptr;
    printf("%lf\n", value2);

    printf("%p\n", &value1);

    printf("%p\n", double_ptr);



    return 0;
}
