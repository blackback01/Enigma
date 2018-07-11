using System;

public class Transposition
{
    int key;
    string alphabet = "abcdefghijklmnopqrstuvwxyz";
	public Transposition(int _key)
	{
        key = _key;
	}

    public string Encrypt(string inputText)
    {
        int charCounter = 0;
        string outputText = "";
        for (int counter = 0; counter <= key; counter++)
        {
            foreach (char c in inputText)
            {
                if (inputText.IndexOf(c, charCounter) % key == counter)
                {
                    outputText = outputText + c.ToString();
                }
                charCounter++;
            }
        }
        return outputText;
    }

    public string Decrypt(string inputText)
    {
        int counter = 0;
        int _counter = 0;
        char[] outputArray = new char[inputText.Length];
        string outputText = "";
        for (int i = 0; i < inputText.Length / key; i++)
        {
            _counter = 0;
            foreach (char c in inputText)
            {
                if (Math.Floor((double)(inputText.IndexOf(c, counter) * key) / inputText.Length) > i)
                {
                    break;
                }
                outputArray[i + _counter * key] = c;
                counter++;
                _counter++;
            }
        }
        return outputText;
    }
}
