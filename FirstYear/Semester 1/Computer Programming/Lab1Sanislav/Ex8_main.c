#include <stdio.h>
#include <stdlib.h>

int main()
{
    char firstLine[14] = "` `";
    char secondLine[14] = " -- ";
    char thirdLine[14] = "(oo)";
    char forthLine[14] = " +========\\/";
    char fifthLine[14] = " / || %%% ||";
    char sixthLine[14] = "*  ||-----||";
    char seventhLine[14] = " ``     ``"; //aici nu am putut folosi ghilimelele normale asa ca am folosit altfel de caractere
    printf("%14s \n", firstLine);
    printf("%14s \n", secondLine);
    printf("%14s \n", thirdLine);
    printf("%14s \n", forthLine);
    printf("%14s \n", fifthLine);
    printf("%14s \n", sixthLine);
    printf("%14s \n", seventhLine);

    //am incercat sa il fac sa arate ca in model
    return 0;
}
