#include <stdio.h>
#include <stdlib.h>

int main()
{
    int grade = 0;
    printf ("Enter the number of points obtained at the exam: ");
    scanf ("%d", &grade);
    if ((grade>=0) && (grade<=100)){
        if (grade>=90)
            printf ("Grade passed with A.\n");
        else if (grade>=80)
            printf ("Grade passed with B.\n");
        else if (grade>=70)
            printf ("Grade passed with C.\n");
        else if (grade>=60)
            printf ("Grade passed with D.\n");
        else
            printf ("Failed.");
    }
    else{
        printf ("You entered an invalid grade!");
    }
    return 0;
}
