Console.Write("Lütfen bir sayı giriniz: ");
int number = int.Parse(Console.ReadLine());
int originalNum = number;

int i = 0;
int maxNum = 0;
int minNum = int.MaxValue;

while (number > 0) {
    i = number % 10;
    
    if (i > maxNum) {
        maxNum = i;
    } else if (i < minNum) {
        minNum = i;
    }

    number /= 10;
}

Console.WriteLine(originalNum + " sayısının en küçük basamağı: " + minNum + ", en büyük basamağı: " + maxNum);
