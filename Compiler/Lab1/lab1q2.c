//write a c program to test whether a given identifier is valid or not
#include <stdio.h>
#include <string.h>

// Function to check if a word is a C keyword
int isKeyword(char word[])
{
    char *keywords[] = {
        "auto", "break", "case", "char", "const", "continue", "default", "do",
        "double", "else", "enum", "extern", "float", "for", "goto", "if",
        "int", "long", "register", "return", "short", "signed", "sizeof",
        "static", "struct", "switch", "typedef", "union", "unsigned", "void",
        "volatile", "while"};
    int totalKeywords = 32;

    for (int i = 0; i < totalKeywords; i++)
    {
        if (strcmp(word, keywords[i]) == 0)
            return 1; // it's a keyword
    }
    return 0; // not a keyword
}

int main()
{
    char id[100], choice[10];
    int valid, i;
    printf("Lab1 Q2\n");
    do
    {
        printf("Enter an identifier: ");
        scanf("%s", id);

        valid = 1;

        if (!((id[0] >= 'A' && id[0] <= 'Z') ||
              (id[0] >= 'a' && id[0] <= 'z') ||
              id[0] == '_'))
        {
            valid = 0;
        }
        for (i = 1; id[i] != '\0'; i++)
        {
            if (!((id[i] >= 'A' && id[i] <= 'Z') ||
                  (id[i] >= 'a' && id[i] <= 'z') ||
                  (id[i] >= '0' && id[i] <= '9') ||
                  id[i] == '_'))
            {
                valid = 0;
                break;
            }
        }
        if (isKeyword(id))
        {
            valid = 0;
            printf("Invalid identifier (keyword)\n");
        }
        else if (valid)
        {
            printf("Valid identifier\n");
        }
        else
        {
            printf("Invalid identifier\n");
        }

        printf("Do you want to test another identifier? (yes/no): ");
        scanf("%s", choice);

    } while (choice[0] == 'y' || choice[0] == 'Y');

    printf("Thank you!\n");
    return 0;
}
