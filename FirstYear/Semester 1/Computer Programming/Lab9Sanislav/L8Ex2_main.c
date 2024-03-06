#include <stdio.h>
#include <stdlib.h>

int main()
{
    //a
    FILE *file_ptr;
    file_ptr = fopen("file.txt", "r");

    //b
    FILE *file1_ptr;
    file1_ptr = fopen("file1.txt", "r");

    //c
    FILE *file2_ptr;
    file2_ptr = fopen("file2.txt", "w");

    //d
    int account_number;
    char name[20];
    float current_balance;
    fscanf (file_ptr, "%d %s %f", &account_number, name, &current_balance);
    printf ("from file.txt : %d %s %.2f\n", account_number, name, current_balance);

    //e
    float euro_amount;
    fscanf (file1_ptr, "%d %f", &account_number, &euro_amount);
    printf("from file1.txt : %d %.2f\n", account_number, euro_amount);

    //f
    fprintf(file2_ptr, "%d %s %.2f", account_number, name, current_balance);

    fclose(file_ptr);
    fclose(file1_ptr);
    fclose(file2_ptr);




    return 0;
}
