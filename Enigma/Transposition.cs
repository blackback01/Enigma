using System;

public class Transposition
{
    int key;
	public Transposition(int _key)
	{
        key = _key;
	}
    //Encrypt
    public string Encrypt(string inputText)
    {
        int charCounter;
        string outputText = "";
        for (int counter = 0; counter < key; counter++)
        {
            charCounter = 0;
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
    //Decrypt
    public string Decrypt(string inputText)
    {
        int index = 0;
        int block = 0;
        int indexInBlock = 0;
        int posInOutputArr = 0;
        string outputText = new string('_', inputText.Length);
        char[] outputArray = new char[inputText.Length];
        foreach (char c in inputText)
        {
            int i = index * key;
            if (i >= inputText.Length * (1 + block))
            {
                block++;
                indexInBlock = 0;
            }
            posInOutputArr = block + key * indexInBlock;
            outputArray[posInOutputArr] = c;
            index++;
            indexInBlock++;
        }
        return new string(outputArray);
    }
}
