//Vowels letters are: A, a, E, e, I, i, O, o, U, u

char letter = char.Parse(Console.ReadLine());

if (letter == 'a' || letter == 'A' || letter == 'E' || letter == 'e' || letter == 'I' || letter == 'i' || letter == 'O'
    || letter == 'o' || letter == 'U' || letter == 'u') {Console.WriteLine("Vowel");}
else { Console.WriteLine("Consonant");}

// Вариант със switch

switch (letter)
{
    case 'A':
    case 'a':
    case 'E':
    case 'e':
    case 'I':
    case 'i':
    case 'O':
    case 'o':
    case 'U':
    case 'u':
        Console.WriteLine("Vowel"); break;
    default:
        Console.WriteLine("Consonant");
        break;
}