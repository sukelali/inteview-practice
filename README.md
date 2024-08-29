# Introduction
- C# Interview Practice.

## :ledger: Topics

- [String Manipulation](#star-string)
  - [String Char Reverse](#string-char-reverse)
  - [String Word Reverse](#string-word-reverse)

##  :star: String
A string is an object of type String whose value is text.

### String Char Reverse
```
// input: abcd, output: dcba
public static string Reverse(string str)
{
    if(str == null) throw new ArgumentNullException("str");

    StringBuilder newString = new StringBuilder();

    for (int j = str.Length - 1; j >= 0; j--)
    {
        newString.Append(str[j]);
    }

    return newString.ToString();
}
```

### String Word Reverse
```
// input: Welcome to Csharp corner, output: corner Csharp to Welcome
public static string Reverse(string sentence)
{
    string[] sentenceArray = sentence.Split(' ');
    StringBuilder reverseSentence = new StringBuilder();

    for (int j = sentenceArray.Length - 1; j >= 0; j--)
    {
        reverseSentence.Append($"{sentenceArray[j]} ");
    }
    return reverseSentence.ToString();
}
```






