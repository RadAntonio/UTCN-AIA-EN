#include <stdio.h>
#include <stdlib.h>

int main()
{
    int var1 = 5;
    int *int_ptr = &var1;

    printf("Address of var1: %d\n", &var1);
    printf("Value of int_ptr: %d\n", int_ptr);
    printf("Address of int_ptr: %d\n", &int_ptr);
    printf("Value of var1: %d\n", var1);
    printf("Value of *int_ptr: %d\n", *int_ptr);
    printf("Valure of &*int_ptr: %d and of *&int_ptr: %d\n", &*int_ptr, *&int_ptr);

    return 0;
}
