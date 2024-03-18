#include <stdio.h>
#include <stdlib.h>
#define MAX_DIGIT 10
int main()
{
    int sum=0, digit=0;
    printf("Computes the sum of the digits from 0 to %d.\n",MAX_DIGIT);

    while(1){

        if(digit>MAX_DIGIT)
            break;

        sum=sum+digit;
        digit++;

    }
        printf("The sum of the digits is %d.\n",sum);

    return 0;
}
