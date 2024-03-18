#include <stdio.h>
#include <stdlib.h>
#define PERIOD '.'

int main()
{
    int character = 0, no_character = 0;

    printf ("Computes how many times the characters other than single or double quotes appear in an input sequence. \n");
    printf ("Type . to end the sequence. \n");
    printf ("Input sequence: ");
    do {
        if ((character != '"') && (character != '\''))
            no_character++;
    }while((character = getchar()!=PERIOD));
    printf ("There are %d non quote characters.\n", no_character - 1);

    return 0;
}
