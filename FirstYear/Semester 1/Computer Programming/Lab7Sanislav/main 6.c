#include <stdio.h>
#include <stdlib.h>


struct stock{
char code[3];
char name[30];
int quantity;
float price;
};

void insert_products(int,struct stock*);
void display_products(int,struct stock*);

int main()
{
    struct stock *ptr;
    int number = 0;

    printf("Enter the number of products: ");
    scanf("%d",&number);

    ptr = (struct stock*) malloc(number * sizeof(struct stock));
    insert_products(number, ptr);

    printf("Displaying the products with quantity > 0:\n");
    display_products(number,ptr);

    free(ptr);
    return 0;
}

void insert_products(int number, struct stock *st){
int i = 0;

for(i = 0; i < number; i++){
    printf("Enter code, name, quantity, price of the %d product:\n",i+1);
        scanf("%s%s%d%f", (st+i)->code, (st+i)->name, &(st+i)->quantity, &(st+i)->price);
}
}

void display_products(int number, struct stock *st){

int i = 0;
for(i = 0;i < number; i++){
    if((st+i)-> quantity >0 )
        printf("%s\t%s\t%d\t%.2f\n",(st+i)->code, (st+i)->name, (st+i)->quantity, (st+i)->price);
}
}
