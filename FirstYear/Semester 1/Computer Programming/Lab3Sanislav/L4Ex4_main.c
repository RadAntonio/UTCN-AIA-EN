#include <stdio.h>
#include <stdlib.h>

int main()
{
        int num = 45, *ptr = NULL, **ptr2ptr = NULL;

        ptr = &num;
        ptr2ptr = &ptr;


        printf("%d", **ptr2ptr);

        return 0;
}
