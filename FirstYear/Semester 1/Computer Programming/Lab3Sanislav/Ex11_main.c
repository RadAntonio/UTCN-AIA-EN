#include <stdio.h>
#include <stdlib.h>

int main()
{
    int v[101] = {0};
    int n;
    int aux;
    int i;
    int j;

    scanf ("%d", &n);
    printf ("citeste niste valori pentru vector: ");

    for(i = 0; i < n; i++)
        scanf ("%d", &v[i]);

    for(i = 0; i < n - 1; i++)
        for(j = i + 1; j <= n - 1; j++)
            if (v[i] > v[j]) {

                aux = v[i];
                v[i] = v[j];
                v[j] = aux;

            }

    for (i = 0; i < n; i++)
        printf("%d ", v[i]);


    return 0;
}
