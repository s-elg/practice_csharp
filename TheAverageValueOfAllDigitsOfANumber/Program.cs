Console.Write("Lütfen basamaklarının ortalaması bulunacak sayıyı giriniz: ");
int number = int.Parse(Console.ReadLine());
int originalNum = number;

double result = 0;
int digit = 0;

while (number > 0) {
    result += number % 10;
    number /= 10;
    digit++;
}

result = result / digit;

Console.WriteLine(originalNum + " sayısının basamaklarının ortalaması: " + result);