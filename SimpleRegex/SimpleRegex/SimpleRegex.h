#include <stdio.h> 
#include <iostream>

int match_star(char *regexp, char* text);
int match_plus(char *regexp, char* text);
int match_questionmark(char *regexp, char* text);

int match_here(char *regexp, char* text);