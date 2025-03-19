Console.Write("Lütfen basamak sayısı bulunacak sayıyı giriniz: ");
int number = int.Parse(Console.ReadLine());
int originalNum = number;

int digit = 0; 

while (number > 0) {
    digit++;
    number /= 10;
}

Console.WriteLine(originalNum + " sayısının basamaklarının sayısı: " + digit);
