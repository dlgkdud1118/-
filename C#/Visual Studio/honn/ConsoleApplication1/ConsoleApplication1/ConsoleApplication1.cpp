
#include <iostream>
#include <string>

using namespace std;

class ClassA
{
	string serif;
public:
	ClassA(const string &s);
	void Say();
	void Set(const string &s);
	string& Serif();
	ClassA& operator = (ClassA& A);
};

ClassA::ClassA(const string &s)
{
	Set(s);
}
void ClassA::Set(const string& s)
{
	serif = s;
}
void ClassA::Say()
{
	std::cout << serif << "\n";
}
string& ClassA::Serif()
{
	return serif;
}
ClassA& ClassA::operator = (ClassA& A)
{
	Set(A.Serif());
	return *this;
}
void main()
{
	ClassA a("I am A.");
	ClassA b("I am B.");
	b = a;
	b.Say();
	a.Set("Am I A?");
	b.Say();
}

