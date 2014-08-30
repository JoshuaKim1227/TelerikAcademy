using System;
using System.Text;
using System.Text.RegularExpressions;

class FakeTextMarkupLanguage
{
    static void Main(string[] args)
    {
        string text = GetInput();
        string result = null;

        do
        {
            if (result == null)
            {
                result = ExtractText(text);
            }
            else
            {
                result = ExtractText(result);
            }

        } while (result.Contains("<") || result.Contains(">"));

        // string result = ExtractText(text);
        Console.WriteLine(result);
    }

    static string GetInput()
    {
        // Initializing data types
        StringBuilder input = new StringBuilder();

        // Getting the number of lines
        int numberOfLines = int.Parse(Console.ReadLine());

        // Getting each line and append it on a single string
        for (int line = 0; line < numberOfLines; line++)
        {
            if (line + 1 == numberOfLines)
            {
                input.Append(Console.ReadLine());

            }
            else
            {
                input.Append(Console.ReadLine() + "\n");
            }
        }

        return input.ToString();
    }

    static string ExtractText(string text)
    {
        // Initializing data types
        string processedText;
        string tagText;

        // Matching regions in text with tags
        string pattern = @"<\w*>[^\<\>]*</\w*>";
        MatchCollection matches = Regex.Matches(text, pattern);

        // Iterating through each match
        foreach (Match item in matches)
        {
            tagText = item.ToString();

            // Processing text and removing tags
            processedText = ProcessText(tagText.ToString());

            // Replacing tag regions with the processed text
            text = text.Replace(tagText, processedText);

            // Recursive call only if there are more tags to process
            //if (text.Contains("<") || text.Contains(">"))
            //{
            //    text = ExtractText(text);
            //}
        }

        return text;
    }

    static string ProcessText(string input)
    {
        // Initializing data types
        string pattern;
        string tag;
        string text;

        // Matching and extracting the tag
        pattern = @"<\w*>";
        Match tagMatch = Regex.Match(input, pattern);

        // Matching and extraxting the text between the tags
        pattern = @"(?<=\>).*(?=\<)";
        Match betweenTagsMatch = Regex.Match(input, pattern);

        // Convert to string
        tag = tagMatch.ToString();
        text = betweenTagsMatch.ToString();

        // Checking the tag and processing the text appropriately
        if (tag.ToString() == "<upper>")
        {
            text = text.ToUpper();
            return text;
        }

        // Checking the tag and processing the text appropriately
        else if (tag.ToString() == "<lower>")
        {
            return text.ToLower();
        }

        // Checking the tag and processing the text appropriately
        else if (tag.ToString() == "<del>")
        {
            return "";
        }

        // Checking the tag and processing the text appropriately
        else if (tag.ToString() == "<rev>")
        {
            // Initializing String builder
            StringBuilder builder = new StringBuilder();

            // Converting the text to char to reverse it
            char[] textChars = text.ToCharArray();
            Array.Reverse(textChars);

            // Append the result in the String builder
            foreach (char ch in textChars)
            {
                builder.Append(ch);
            }

            return builder.ToString();
        }

        // Checking the tag and processing the text appropriately
        else if (tag.ToString() == "<toggle>")
        {
            // Initializing String builder
            StringBuilder builder = new StringBuilder();

            // Converting the text to char
            char[] textChars = text.ToCharArray();

            // Checking each letter
            for (int letter = 0; letter < textChars.Length; letter++)
            {
                // If it's in Uppercase - make it lower
                if (char.IsUpper(textChars[letter]))
                {
                    textChars[letter] = char.ToLower(textChars[letter]);
                }

                // If it's in Lowercase - make it upper
                else if (char.IsLower(textChars[letter]))
                {
                    textChars[letter] = char.ToUpper(textChars[letter]);
                }
            }

            // Append the result in the String builder
            foreach (char ch in textChars)
            {
                builder.Append(ch);
            }

            return builder.ToString();
        }

        return null;
    }
}

