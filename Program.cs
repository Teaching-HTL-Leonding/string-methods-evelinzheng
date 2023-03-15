bool Contains(string searchString, char searchChar)
{

    for (int i = 0; i < searchString.Length; i++)
    {
        if (searchString[i] == searchChar)
        {
            return true;
        }
    }
    return false;
}

int IndexOf(string searchString, char searchChar)
{
    
    for (int i = 0; i < searchString.Length; i++)
    {
        if (searchString[i] == searchChar)
        {
            return i;
        }
    }
    return -1;
}

    int LastIndexOf(string searchString, char searchChar)
    {


        for (int i = searchString.Length - 1; i >= 0; i--)
        {
            if (searchChar == searchString[i])
            {
                return i;
            }
        }
        return -1;
    }

    string TrimStart(string a, char b)
    {
        string trimmed = a.TrimStart(b).TrimEnd(b);
        return trimmed;
    }


    string SubString(string s, int start, int maxLength)
    {

        int actualLength = Math.Min(maxLength, s.Length - start);
        string subString = s.Substring(start, actualLength);
        return subString;
    }


    string Remove(string s, int startIndex, int length)
    {
        string firstPart = s.Substring(0, startIndex);
        string secondPart = s.Substring(startIndex + length);
        string newString = firstPart + secondPart;
        return newString;
    }
 