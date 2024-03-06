#include <stdio.h>
#include <stdlib.h>

typedef struct{
    int student_id;
    char first_name[30];
    char last_name[30];
    float grade;
}Student;

void insert_students(FILE *, int, Student *);
void display_students(FILE *, int, Student *);
float average_students_grades(FILE *, int, Student *);
void students_passed_exam(FILE *, int, Student *);
void students_alphabetical_order(FILE *, int, Student *);
int enter_choice();

int main()
{
    Student *st;
    int no=0, choice=0;

    printf("Enter the number of students: ");
    scanf("%d", &no);

    st = (Student *)malloc(no * sizeof(Student));

    FILE *fp = fopen("ex84.bin", "wb");
    if (fp ==NULL){
        printf("\nError opening file!\n");
        exit(1);
    }
    insert_students(fp, no, st);
    fclose(fp);

    FILE *fp1= fopen("ex84.bin", "rb");
    if (fp1 ==NULL){
        printf("\nError opening file!\n");
        exit(1);
    }
    while((choice=enter_choice())!=5){
        switch(choice){
        case 1:
            display_students(fp1, no, st);
            break;
        case 2:
            printf("Average of grades: %.2f\n", average_students_grades(fp1, no, st));
            break;
        case 3:
            students_passed_exam(fp1, no, st);
            break;
        case 4:
            students_alphabetical_order(fp1, no, st);
            break;
        default: printf("Enter a valid choice!\n");
        break;
        }
    }
    printf("Done!\n");
    fclose(fp1);

    free(st);

    return 0;
}

void insert_students(FILE *fp, int number, Student *st){
    char buffer[30];
    for (int i=0; i<number; i++){
        fflush(stdin);
        st->student_id = i+1;
        printf("Enter the first name of student %d: ", i+1);
        fgets(buffer, sizeof(buffer), stdin);
        strcpy(st->first_name, buffer);
        st->first_name[strlen(buffer)-1]='\0';
        printf("Enter the last name of student %d: ", i+1);
        fgets(buffer, sizeof(buffer), stdin);
        strcpy(st->last_name, buffer);
        st->last_name[strlen(buffer)-1]='\0';
        printf("Enter the grade of student %d: ", i+1);
        scanf("%f", &st->grade);
        fwrite(st, sizeof(Student), 1, fp);

    }
}

void display_students(FILE *fp, int number, Student *st){
    fread(st, sizeof(Student), number, fp);
    for (int i=0; i<number; i++){
        printf("Student no %d: %d %s %s %.2f\n", i+1, (st+i)->student_id, (st+i)->first_name, (st+i)->last_name, (st+i)->grade);
    }
}

float average_students_grades(FILE *fp, int number, Student *st){
    float average = 0.0;
    fread (st, sizeof(Student), number, fp);
    for(int i=0; i<number; i++){
        average= average +(st+i)->grade;
    }
    return average/number;
}

void students_passed_exam(FILE *fp, int number, Student *st){
    fread(st, sizeof(Student), number, fp);
    for (int i=0; i<number; i++){
        if ((st+i)->grade>=5.00)
            printf("Student no %d: %d %s %s %.2f\n", i+1, (st+i)->student_id, (st+i)->first_name, (st+i)->last_name, (st+i)->grade);
    }
}

void students_alphabetical_order(FILE *fp, int number, Student *st){
    Student temp;
    for(int i=0; i<number; i++){
        for(int j=i+1; j<number; j++){
            if(strcmp(st[i].first_name, st[j].first_name) >0){
                temp=st[i];
                st[i]=st[j];
                st[j]=temp;
            }
        }
    }
    for (int i=0; i<number; i++)
        printf("Student no %d: %d %d %s %s %.2f\n", i+1, (st+i)->student_id, (st+i)->first_name, (st+i)->last_name, (st+i)->grade);
}

int enter_choice(){
    int menu_choice =0;
    printf("\nEnter your choice: \n"
           "1-Display students information\n"
           "2-Display average of the students grades\n"
           "3-Display students who passed the exam\n"
           "4-Display students in alphabetical order after their first name\n"
           "5-Exit\n"
           );
     scanf("%d", &menu_choice);
     return menu_choice;
}
