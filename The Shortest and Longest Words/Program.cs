Console.Write("Lütfen bir cümle giriniz: ");
string sentence = Console.ReadLine();

string[] words = sentence.Split();

string longestWord = words[0];
string shortestWord = words[0];

for (int i = 1; i < words.Length; i++){
    if (words[i].Length > longestWord.Length){
                longestWord = words[i];
    }

    if (words[i].Length < shortestWord.Length){
        shortestWord = words[i];
    }
}


Console.WriteLine("girdiğiniz cümledeki en uzun kelime: " + longestWord + ", en kısa kelime: " + shortestWord);
