#include <stdio.h>
#include <stdlib.h>

int day_year(int year, int month, int day, int *rest_days, const int (*days)[12]){

    int leap = 0, i = 0;
    leap = ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

    for (i = 0; i < month - 1; i++) {
        day += days[leap][i];
    }
    if(leap)
        *rest_days = 366 - day;
    else
        *rest_days = 365 - day;
    return day;
}
int main()
{
    int year = 0, month = 0, day = 0, days = 0, rest_days = 0;
    int days_month[2][12] = {

        {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31},
        {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31},

    };
    printf("Enter the year month and day: ");
    scanf("%d%d%d", &year, &month, &day);
    days = day_year(year, month, day, &rest_days, days_month);
    printf("The number of the day in the year is %d. \n", days);
    printf("The number of the days to the end of the year is: %d.\n", rest_days);
    return 0;
}
