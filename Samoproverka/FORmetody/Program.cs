string text = " Первоночальный текст Валуева имел не точность. И чтобы его заменить потребуются тренировки)))";
string  Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty; //инициализация строки
    int length = text.Length;       //число символов в строке
   for (int i = 0; i <= length; i++)
   {
    if(text[i] == oldValue) 
    result = result + $"{newValue}";
    else result = result + $"{text[i]}";
   }
    return result;
}
string newText = Replace(text, '-', '+');
Console.WriteLine(newText);