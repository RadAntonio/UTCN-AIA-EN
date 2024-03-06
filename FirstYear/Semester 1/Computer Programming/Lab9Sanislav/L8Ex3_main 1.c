#include <stdio.h>
#include <stdlib.h>
#define MAX 50

void delete_line(FILE *fp, FILE *fp_temp, int line_no) {

    int i = 0;
    char text[MAX] = {'\0'};

    while (!feof(fp)) {

        fgets(text, MAX, fp);
        if(!feof(fp)) {

            i++;
            if (i != line_no)
                fprintf (fp_temp, "%s", text);
        }
    }
}

void replace_line(FILE *fp, FILE *fp_temp, char *new_text, int line_no) {

    int i = 0;
    char text[MAX] = {'\0'};

    while (!feof(fp)) {

        fgets(text, MAX, fp);
        if(!feof(fp)) {

            i++;
            if (i != line_no)
                fprintf (fp_temp, "%s", text);
            else
                fprintf (fp_temp, "%s", new_text);
        }
    }
}

int main() {

    FILE *fptr1, *fptr2;
    fptr1 = fopen("file.txt", "r");
    fptr2 = fopen("temp.txt", "w");

    //sterg o linie
    int line_no;
    char new_line[MAX] = {'\0'};

    int option = 0;
    printf("Pentru 1 se sterge linia iar pentru 2 se inlocuieste cu altceva iar pentru 3 se inchide programul: ");
    scanf ("%d", &option);

    switch(option) {

    case 1:     printf ("introdu o line ce trebuie stearsa: ");
                scanf ("%d", &line_no);
                delete_line( fptr1, fptr2, line_no);
                break;



     case 2:    printf ("introdu linia pe care sa apara ceva: ");
                scanf("%d", &line_no);
                printf ("introdu ce sa apare pe linia %d: ", line_no);
                fflush(stdin);
                fgets (new_line, MAX, stdin);
                replace_line (fptr1, fptr2, new_line, line_no);
                break;

    case 3:   break;

    }

    fclose(fptr1);
    fclose(fptr2);

    remove("file.txt");
    rename("temp.txt", "file.txt");

    return 0;
}
