#include "SimpleRegex.h"
using namespace std;

int match_star(char *regexp, char* text) {
	if( !regexp || !text )
	throw exception("NullPointerException");

	char c = regexp[0];

	regexp += 2;	//Move to the char behind "*"
    do {
        if(match_here(regexp, text) == 1)	//Move along the text as matched in *, until match succeeded
			return 1;        
    }
    while((*text) != '\0' && (*text++ == c || c == '.'));

    return 0;
}

int match_plus(char *regexp, char* text) {
	if( !regexp || !text )
		throw exception("NullPointerException");
	
	char c = regexp[0];
	if( c != '.' && c != '*' && c != *text++ )
		return 0;

	//Match once succeeded, match for the rest
	regexp += 2;
    do {
        if(match_here(regexp, text) == 1)
			return 1;        
    }
    while((*text) != '\0' && (*text++ == c || c == '.'));

    return 0;
}


int match_questionmark(char *regexp, char* text)
{
	if( !regexp || !text )
		throw exception("NullPointerException");

	char c = regexp[0];

	regexp += 2;	//Move to the char behind "?"
	if(match_here(regexp, text) == 1)	//Match the text without matching "?"
		return 1;

	if( c != '.' && c != '*' && c != *text )
		return 0;
	else return 1;
}

int match_here(char *regexp, char* text)
{
    if(regexp[0] == '\0')
		return 1;	//Match succeeded
    if(regexp[1] == '+')
		return match_plus(regexp, text);
    if(regexp[1] == '*')
		return match_star(regexp, text);
    if(regexp[1] == '?')
		return match_star(regexp, text);
	if(regexp[0] == '^')
		return match_here(regexp + 1, text);
    if(regexp[0] == '$')
		return text[0] == '\0';
    if(regexp[0] == '.' && text[0] != '\0')
		return match_here(regexp + 1, text + 1);
    if(regexp[0] == text[0] && text[0] != '\0')
		return match_here(regexp + 1, text + 1);

    return 0;	//Match failed
}

int main()
{ 
  char *pattern = "^a*b+c?$";
  char *successText1 = "aabc";
  char *failureText1 = "aabcc";
  char *successText2 = "b";
  char *failureText2 = "bac";
  cout<<pattern<<" ON "<<successText1<<": "<<match_here(pattern, successText1)<<endl;
  cout<<pattern<<" ON "<<failureText1<<": "<<match_here(pattern, failureText2)<<endl;
  cout<<pattern<<" ON "<<successText2<<": "<<match_here(pattern, successText1)<<endl;
  cout<<pattern<<" ON "<<failureText2<<": "<<match_here(pattern, failureText2)<<endl;

  getchar();
  return 0; 
} 