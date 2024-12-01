Console.Write("Введите строку: ");
string input = Console.ReadLine();
string transformedString = TransformString(input);
Console.WriteLine("Преобразованная строка: " + transformedString);
static string TransformString(string input)
{
    var result = new System.Text.StringBuilder();
    foreach (char c in input)
    {
        result.Append(c);
        result.Append((int)c);
    }
    return result.ToString();
}