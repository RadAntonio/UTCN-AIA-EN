#include <stdio.h>
#include <stdlib.h>

typedef struct {

   int part_number;
   char part_name[25];

} Part;



int main()
{
    Part a;
    Part b[10];
    Part *ptr;

    scanf ("%d %s", &a.part_number, a.part_name);
    b[2] = a;
    ptr = b;

    printf ("%d %s", (ptr + 2) -> part_number, (ptr + 2) -> part_name);
    return 0;
}
