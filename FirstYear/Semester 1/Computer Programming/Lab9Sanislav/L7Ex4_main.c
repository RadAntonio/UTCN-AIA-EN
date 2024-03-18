#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct toni {

    char firstname[20];
    char lastname[20];
    int nrTotalLitereFirstAndLast;

};

void get_info(struct toni *ptr) {

    scanf ("%s %s", ptr -> firstname, ptr -> lastname);
}

void make_info(struct toni *ptr1) {

    ptr1 -> nrTotalLitereFirstAndLast = strlen(ptr1 -> firstname) + strlen(ptr1 ->lastname);
}

void show_info(struct toni *ptr2) {

    printf ("%d", ptr2 -> nrTotalLitereFirstAndLast);

}

int main()
{
    struct toni var;
    get_info(&var);
    make_info(&var);
    show_info(&var);
    return 0;
}
