Console.Write("Lütfen basamaklarının toplamı bulunacak sayıyı giriniz: ");
int number = int.Parse(Console.ReadLine());
int originalNum = number;

int result = 0;

while (number > 0) {
    result += number % 10;
    number /= 10;
}

Console.WriteLine(originalNum + " sayısının basamaklarının toplamı: " + result);
