using System.Collections;
using System.Collections.Generic;
using System;

public class Words
{
    Random rnd = new Random();
    int randomNumber;

    public int rNum(ArrayList arry)
    {
        int num = arry.Count;
        this.randomNumber = rnd.Next(num);
        return this.randomNumber;
    }

    public string word(ArrayList arry)
    {
        string we = arry[randomNumber].ToString();
        return we.ToUpper();

    }

    public string check(string random, string guess)
    {
        char[] rlett = random.ToCharArray();
        char[] glett = guess.ToCharArray();
        char[] result = new char[rlett.Length];

        // First pass: check for correct letters in correct positions
        for (int i = 0; i < rlett.Length; i++)
        {
            if (rlett[i] == glett[i])
            {
                result[i] = rlett[i];
            }
        }

        // Second pass: check for correct letters in incorrect positions and missing letters
        for (int i = 0; i < rlett.Length; i++)
        {
            if (result[i] == 0)
            {
                bool found = false;
                for (int j = 0; j < glett.Length; j++)
                {
                    if (rlett[i] == glett[j] && result[j] == 0)
                    {
                        result[j] = '*';
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    result[i] = '-';
                }
            }
        }

        // Third pass: check for correct letters in incorrect positions
        List<int> usedIndices = new List<int>();
        for (int i = 0; i < rlett.Length; i++)
        {
            if (result[i] == 0)
            {
                for (int j = 0; j < rlett.Length; j++)
                {
                    if (i != j && rlett[j] == glett[i] && !usedIndices.Contains(j))
                    {
                        result[i] = '*';
                        usedIndices.Add(j);
                        break;
                    }
                }
                if (result[i] == 0)
                {
                    result[i] = '-';
                }
            }
        }

        string word = string.Join("", result);
        return word;
    }





}