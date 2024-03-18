#include <stdio.h>
#include <stdlib.h>

int main()
{
    char ch,string[100], file_name[50] = "file.txt";
    int i = 1;
    FILE *fp;

    fp = fopen(file_name, "w");
    printf("Please input a text to store in file \%s\".End with Ctrl+Z.\n",file_name);
    while ((ch = fgetc(stdin)) != EOF){
        fputc(ch, fp);
    }
    fclose(fp);

    fp = fopen(file_name, "r+");
    fseek(fp, 0, SEEK_END);
    printf("\nPlease input the strings to append to the created file. End with Ctrl+Z.\n");
    while(fgets(string, 100, stdin) != NULL){
        fputs(string, fp);
    }

    fclose(fp);

    printf("\nLines of the files (numbered):\n");
    fp=fopen(file_name, "r");
    while(fgets(string, 100, fp) != NULL){
        printf("%d %s",i, string);
        i++;
    }
    fclose(fp);
    return 0;
}
