#include <stdio.h>
#include <stdlib.h>

void circumference(double radius) {

    double circum = 0;
    circum = 2 * 3.14 * radius;
    printf("circumference of teh circle is: %.2lf\n", circum);
}

void area(double radius) {

    double area = 0;
    area = 3.14 * radius * radius;
    printf("area of teh circle is: %.2lf", area);
}

void volume(double radius) {

    double volume = 0;
    volume = (4 * 3.14 * radius * radius * radius) / 3;
    printf("volume of the sphere is: %.2lf", volume);
}

int main()
{
    void (*f_ptr[3])(double) = {circumference, area, volume};
    int choice = 0;
    double rad = 0;
    printf("Radius of the circle/sphere is: ");
    scanf("%lf", &rad);
    printf("Choose between Circumference, Area or Volume: ");
    scanf("%d", &choice);

    while(choice >= 1 && choice < 4) {
        (*f_ptr[choice - 1])(rad);
        printf("Enter a number between 1 and 3, 4 to en: ");
        scanf("%d", &choice);
    }
    printf("Program execution completed.\n");

    return 0;
}

