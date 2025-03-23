using Matrix2dLibr;
// Tworzenie macierzy jednostkowej
var identity = Matrix2d.Id;
Console.WriteLine("Macierz jednostkowa:");
Console.WriteLine(identity);
// Tworzenie macierzy zerowej
var zero = Matrix2d.Zero;
Console.WriteLine("\nMacierz zerowa:");
Console.WriteLine(zero);
// Tworzenie macierzy z podanymi wartosciami
var m1 = new Matrix2d(1, 2, 3, 4);
var m2 = new Matrix2d(5, 6, 7, 8);
Console.WriteLine("\nMacierz m1:");
Console.WriteLine(m1);
Console.WriteLine("\nMacierz m2:");
Console.WriteLine(m2);
// Dodawanie macierzy
var sum = m1 + m2;
Console.WriteLine("\nDodawanie m1 + m2:");
Console.WriteLine(sum);
// Odejmowanie macierzy
var diff = m1 - m2;
Console.WriteLine("\nOdejmowanie m1 - m2:");
Console.WriteLine(diff);
// Mnożenie macierzy
var product = m1 * m2;
Console.WriteLine("\nMnozenie m1 * m2:");
Console.WriteLine(product);
// Mnożenie macierzy przez skalar
var scalarProduct = 2 * m1;
Console.WriteLine("\nMnozenie m1 przez skalar 2:");
Console.WriteLine(scalarProduct);
// Transpozycja macierzy
var transpose = Matrix2d.Transpose(m1);
Console.WriteLine("\nTranspozycja m1:");
Console.WriteLine(transpose);
// Wyznacznik macierzy
var determinant = m1.Determinant();
Console.WriteLine("\nWyznacznik m1:");
Console.WriteLine(determinant);
// Parsowanie macierzy z ciągu znakow
var parsedMatrix = Matrix2d.Parse("[[1, 2], [3, 4]]");
Console.WriteLine("\nParsowanie macierzy z ciagu znakow:");
Console.WriteLine(parsedMatrix);
// Jawna konwersja macierzy na tablice
var array = (int[,])m1;
Console.WriteLine("\nJawna konwersja m1 na tablice:");
Console.WriteLine($"[{array[0, 0]}, {array[0, 1]}]");
Console.WriteLine($"[{array[1, 0]}, {array[1, 1]}]");