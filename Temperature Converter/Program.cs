Console.WriteLine("###Temperature Converter###");

bool exit = false;

while (!exit) {
    Console.WriteLine("1. Fahrenheit to Celcius");
    Console.WriteLine("2. Celcius to Fahrenheit");
    Console.WriteLine("3. Exit");
    Console.Write("Lütfen seçeceğinizi giriniz: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice) {
        case 1:
            Console.Clear();
            toCelcius();
            break;
        case 2:
        Console.Clear();
            toFahrenheit();
            break;
        case 3:
            exit = true;
            break;
        default:
            Console.WriteLine("girdiğiniz seçenek geçersiz");
            break;
    }
}


void toCelcius() {
    Console.Write("lütfen celicus birimine çevrilecek sıcaklığı giriniz: ");
    double temperature = double.Parse(Console.ReadLine());

    temperature = (temperature - 32) * 5 / 9;

    Console.WriteLine("sonuç: " + temperature + " C");
}

void toFahrenheit() {
    Console.Write("lütfen fahrenheit birimine çevrilecek sıcaklığı giriniz: ");
    double temperature = double.Parse(Console.ReadLine());

    temperature = (temperature * 9 / 5) + 32;

    Console.WriteLine("sonuç: " + temperature + " F");
}
