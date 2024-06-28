// ConsoleApplication2.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

#include <iostream>
using namespace std;


class Vec2
{
public:
	double v[2];
	Vec2();
	Vec2(double, double);
	friend Vec2& operator + (Vec2&, Vec2&);
	void print();
};

Vec2::Vec2() { v[0] = v[1] = 0.0; }
Vec2::Vec2(double X, double Y) { v[0] = X; v[1] = Y; }
Vec2& operator + (Vec2& a, Vec2& b)
{
	Vec2& aVec2(a.v[0] + b.v[0], a.v[1] + b.v[1]);
	return aVec2;
}
void Vec2::print()
{
	std::cout << "Vec2(" << v[0] << "," << v[1] << ")\n";
}
void main()
{
	Vec2 a(1.1, 2.2), b(0.3, 0.4), c;
	c = a + b;
	std::cout<<"a  =";a.print();
	std::cout<<"b  =";b.print();
	std::cout <<"a+b = ";c.print();
}