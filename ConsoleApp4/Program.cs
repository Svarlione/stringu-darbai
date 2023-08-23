string word = "Pasaulis grazus";
string word1 = "PASAULIS";
string substringWord = word.Substring(3, 5);
string repalceWord = word.Replace('s', 'g');
int indexOfWord = word.IndexOf("grazus");
string trimWord = word.Trim();
string upWord = word.ToUpper();
string lowWord = word1.ToLower();
Console.WriteLine($" {substringWord}; {repalceWord}; {indexOfWord}; {trimWord}; {upWord}; {lowWord}");
