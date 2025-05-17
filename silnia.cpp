#include <iostream>
using namespace std;

int main() {
    int n;
    cout << "Podaj liczbę: ";
    cin >> n;

    long long wynik = 1;
    for (int i = 1; i <= n; i++) {
        wynik *= i;
    }

    cout << "Silnia z " << n << " = " << wynik << endl;
    return 0;
}
