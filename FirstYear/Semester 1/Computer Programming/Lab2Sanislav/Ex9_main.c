#include <stdio.h>
#include <stdlib.h>

int main()
{
    unsigned int numar = 0;
    unsigned int numardeshiftat = 0;
    unsigned int x = 0;
    unsigned int aux = 0;

    printf ("introdu un numar cu care sa shiftezi numardeshiftat si un numar: ", numardeshiftat, numar);
    scanf ("%d %d", &numardeshiftat, &numar);

    aux = 1 << numardeshiftat;

    x = numar | aux;

    printf ("numarul shiftat este %d", x);


    return 0;
}
