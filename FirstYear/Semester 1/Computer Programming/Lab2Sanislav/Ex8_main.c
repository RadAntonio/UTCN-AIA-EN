#include <stdio.h>
#include <stdlib.h>

int main()


{

    float x;
    printf("Write an integer number\n");
    scanf("%f",&x);
    printf("Your angle has: %f radians\n",x);
    int d,m;
    float degrees,s,pi=3.14;
    degrees=180/pi;
    d=(int)degrees;
    m=(int)((degrees-d)*60);
    s=(degrees-(d+m/60))*3600;
    printf("%d %d %f",d,m,s);

    return 0;
}
