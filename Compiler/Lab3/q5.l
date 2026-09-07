%{
#include <stdio.h>
%}

%%
[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}   { 
    printf("%s is a Valid Email\n", yytext); 
}
\n                                                  ; 
.                                                   { 
    printf("%s is Not a Valid Email\n", yytext); 
}
%%

int yywrap() { return 1; }

int main() {
    printf("Enter an email: ");
    yylex();
    return 0;
}