#include <stdio.h>
#include <stdlib.h>
#define MAX_SIZE 30

int main()
{
    char initial_string[MAX_SIZE] = {'\0'};
    char reverse_string[MAX_SIZE] = {'\0'};
    char *initial_string_ptr = initial_string;
    char *reverse_string_ptr = reverse_string;
    int lenght = 0;

    printf("Enter any string with a maximum lenght of %d: ", MAX_SIZE);
    gets(initial_string);

    //Find lenght of string
    while(*initial_string_ptr != '\0') {

        lenght++;
        initial_string_ptr++;

    }

    //Store each character from end of original string to reverse srting
    while(lenght > 0) {

        initial_string_ptr--;
        *reverse_string_ptr = *initial_string_ptr;
        reverse_string_ptr++;
        lenght--;

    }

    *reverse_string_ptr = '\0';
    printf("\nOriginal string = %s\n", initial_string);
    printf("reverse string = %s\n", reverse_string);


    return 0;
}
