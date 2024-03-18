#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct book {

    int book_id;
    char title[50];
    char author[50];
};

void print_struct(struct book);

int main()
{
    struct book book1 = {1, "C How to Program", "Deitel"};

    print_struct(book1);
    book1.book_id = 2;
    strcpy(book1.title, "C Programming");
    strcpy(book1.author, "Smith");
    print_struct(book1);
    return 0;
}

void print_struct(struct book bk) {

    struct book *bk_ptr = &bk;
    printf ("%d; %s; %s\n", bk.book_id, bk.title, bk.author);
    printf("%d; %s; %s\n", bk_ptr->book_id, bk_ptr->title, bk_ptr->author);
    printf("%d; %s; %s\n", (*bk_ptr).book_id, (*bk_ptr).title, (*bk_ptr).author);
}
