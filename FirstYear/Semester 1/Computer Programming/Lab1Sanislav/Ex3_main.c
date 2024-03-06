#include <stdio.h>
#include <stdlib.h>

int main()
{
    float pi = 3.14159265;
    printf("pi rounded to 2 digits is: %.2f \n", pi);
    printf("pi rounded to 5 digits is: %.5f \n", pi);
    printf("pi in exponential form is: %e \n", pi);
    printf("pi right justified to 10 columns is: %10f \n", pi);
    return 0;
}
