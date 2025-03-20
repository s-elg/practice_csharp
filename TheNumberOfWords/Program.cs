Console.Write("Lütfen bir cümle giriniz: ");
string sentence = Console.ReadLine();

string[] words = sentence.Split();
int numberOfWords = words.Length;

Console.WriteLine("girdiğiniz cümledeki kelime sayısı: " + numberOfWords);
