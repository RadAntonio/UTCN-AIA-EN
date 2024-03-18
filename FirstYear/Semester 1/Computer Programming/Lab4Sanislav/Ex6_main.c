#include <stdio.h>
#include <stdlib.h>

int max(int array[], int size) {
    int max = array[0];
    int i = 0;
    for(i = 0; i < 10; i++)
            if(array[i] > max)
            max = array[i];
        return max;
}
int min(int array[], int size) {
    int min = array[0];
    int i = 0;
    for(i = 0; i < 10; i++)
            if(array[i] < min)
            min = array[i];
        return min;
}

int main()
{
    int vector[10];
    int i = 0;
    int size = 10;
    for(i = 0; i < size;  i++)
        scanf("%d", &vector[i]);
    printf("the maximum value is: %d\n", max(vector, size));
    printf("the minimum value is: %d\n", min(vector, size));

    return 0;
}
