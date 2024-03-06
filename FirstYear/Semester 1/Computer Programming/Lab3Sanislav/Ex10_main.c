#include <stdio.h>
#include <stdlib.h>

int main()
{
    char theOp;
    float a = 0;
    float b = 0;

    printf ("Alege ce operatie vrei sa faci: + or - or / or * and press q to finish\n");

    while(scanf ("%c", &theOp) && theOp != 'q') {


        printf ("Alege doua numere pentru care sa faci operatia: \n");
        scanf ("%f %f", &a, &b);
        switch (theOp) {
        case '+' :
            printf ("%.2f + %.2f = %.2f\n", a, b, a + b);
            break;
        case '-' :
            printf ("%.2f - %.2f = %.2f\n", a, b, a - b);
            break;
        case '/' :
            printf ("%.2f / %.2f = %.2f\n", a, b, a / b);
            break;
        case '*' :
            printf ("%.2f * %.2f = %.2f\n", a, b, a * b);
            break;
        default :
            printf ("nu recunosc ce ai tastat aacolo te rog sa tastezi iar <3\n");

        }

    }

    return 0;
}
