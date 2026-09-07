%{
#include <stdio.h>
%}

%%
[0-9]    { printf("%s is a Digit\n", yytext); }  
\n       ;                                      
.        { printf("%s is Not a Digit\n", yytext); } 
%%

int yywrap() { return 1; }

int main() {
    printf("Enter a character: ");
    yylex();
    return 0;
}