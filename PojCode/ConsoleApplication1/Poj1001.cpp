// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

void BigNumberMultiply( char **result, char *multiplier )
{
	*result = "10.00";
}

void  CalculateBigNumberExponential(char *s, int n, char **result)
{
	if( !s || *s == '\n' || n < 0 )
	{
		cout<<"Invalid input!"<<endl;
	}
	else if( n == 0 )
	{
		*result = "1";
	}
	else
	{
		CalculateBigNumberExponential( s, n / 2, result );
		if( n % 2 == 1 )
		{
			BigNumberMultiply( result, s );
		}
	}
}

void Trim( char **result )
{
	if( !*result || **result == '\n' )
		return;

	char *pFast, *pSlow;
	pFast = pSlow = *result;
	//Trim from begin
	while( *pFast != '.' && *pFast != '\n' )
	{
		if( *pFast == '0' )
		{
			*pFast++;
		}
		else
		{
			break;
		}
	}

	while( *pFast != '\n' )
	{
		*pSlow = *pFast;
		pSlow++;
		pFast++;
	}

	*pSlow = '\n';
	
	char* pEndOfNonZero = pSlow;
	//Trim from end
	while( pEndOfNonZero != *result )
	{
		if( *pEndOfNonZero == '0' )
		{
			pEndOfNonZero--;
		}
		else if ( *pEndOfNonZero == '.' ) //this is a decimal
		{
			pEndOfNonZero--;
			break;
		}
	}

	*(++pEndOfNonZero) = '\n';
}

int _tmain(int argc, _TCHAR* argv[])
{
	char* s = new char[7];
	char* result = new char[100];
	int n;
	while(cin>>s>>n)
	{
		CalculateBigNumberExponential(s, n, &result);
		if( result )
		{
			Trim(&result);
			cout<<result<<endl;
		}
	}

	delete s;
	delete result;
	return 0;
}

