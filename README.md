# Introduction
- C# Interview Practice.

## :ledger: Topics

- [String Manipulation](#star-string)
  - [Char Reverse](#string-char-reverse)
  - [Word Reverse](#string-word-reverse)
  - [Palindrome Check](#palindrome-check)
  - [Duplicate Char Remove](#duplicate-char-remove)
  - [Char Occurance Count](#char-occurance-count)
  - [Sub String](#sub-string)

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


### Palindrome Check
```
// input: madam, output: palindrome. input: book, output: not palindrome,  
public static string IsPalindrome(string str)
{
    str = str.Trim().ToLower();
    var isPalindrome = true;

    for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
    {
        if (str[i] != str[j])
        {
            isPalindrome = false;
            break;
        }
    }
    return isPalindrome ? "palindrome" : "not palindrome";
}
```


### Duplicate Char Remove 
```
// input: hello world, output: helo wrd
public static string RemoveDuplicate(string str)
{
    var stringBuilder = new StringBuilder();

    for (int i = 0; i < str.Length; i++)
    {
        if (!stringBuilder.ToString().Contains(str[i]))
        {
            stringBuilder.Append(str[i]);
        }

    }
    return stringBuilder.ToString();
}
```


### Char Occurance Count
```
// input: Hello World, output: H: 1, e: 1, l: 3, o: 2, W: 1, r: 1, d: 1
public static Dictionary<char, int> CountOccurance(string str)
{
    Dictionary<char, int> occuranceDict = new Dictionary<char, int>();

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ' ')
        {
            if (!occuranceDict.ContainsKey(str[i]))
            {
                occuranceDict[str[i]] = 1;
            }
            else
            {
                occuranceDict[str[i]]++;
            }
        }
    }
    return occuranceDict;
}
```

### Sub String
```
// input: abcd, output: a ab abc abcd b bc bcd c cd d
public static string GenerateSubString(string str)
{
    var newString = new StringBuilder();
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            for (int k = j; k <= i; k++)
            {
                newString.Append(str[k]);
            }
            newString.Append(" ");
        }
    }
    return newString.ToString();

}
```






