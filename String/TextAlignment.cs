using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatingPractice1
{
    class TextAlignment
    {
        static string LeftAlignment(string input, int maxCharPerLine)
        {
            string ans = "";
            string cur = "";
            int lastWordLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                cur += input[i];
                if (input[i] == '\n')
                {
                    ans += cur;
                    cur = "";
                    lastWordLength = 0;
                }
                else
                {
                    if (input[i] == ' ')
                    {
                        lastWordLength = 0;
                    }
                    else
                    {
                        lastWordLength++;
                    }
                }

                //Console.WriteLine(i + " " + lastWordLength + " " + cur);

                //if cur has length of maxCharPerLine
                if (cur.Length >= maxCharPerLine)
                {
                    string rem = "";
                    // if a word start but not end
                    // if there is some other word along with last word
                    if (lastWordLength > 0 && lastWordLength < maxCharPerLine)
                    {
                        rem = cur.Substring(maxCharPerLine - lastWordLength);
                        cur = cur.Remove(maxCharPerLine - lastWordLength);
                        //Console.WriteLine(cur + " " + rem);
                    }
                    ans += cur + '\n';
                    cur = rem;
                    lastWordLength = cur.Length;
                }
            }

            if (string.IsNullOrEmpty(cur) == false)
            {
                ans += cur;
            }

            return ans;
        }

        static string RightAlignment(string input, int maxCharPerLine)
        {
            string ans = "";
            string cur = "";
            int lastWordLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                cur += input[i];
                if (input[i] == '\n')
                {
                    for (int j = 0; j < maxCharPerLine - cur.Length; j++)
                    {
                        ans += ' ';
                    }
                    ans += cur;
                    cur = "";
                    lastWordLength = 0;
                }
                else
                {
                    if (input[i] == ' ')
                    {
                        lastWordLength = 0;
                    }
                    else
                    {
                        lastWordLength++;
                    }
                }

                //Console.WriteLine(i + " " + lastWordLength + " " + cur);

                //if cur has length of maxCharPerLine
                if (cur.Length >= maxCharPerLine)
                {
                    string rem = "";
                    // if a word start but not end
                    // if there is some other word along with last word
                    if (lastWordLength > 0 && lastWordLength < maxCharPerLine)
                    {
                        rem = cur.Substring(maxCharPerLine - lastWordLength);
                        cur = cur.Remove(maxCharPerLine - lastWordLength);
                        //Console.WriteLine(cur + " " + rem);
                    }
                    for (int j = 0; j < maxCharPerLine - cur.Length; j++)
                    {
                        ans += ' ';
                    }
                    ans += cur + '\n';
                    cur = rem;
                    lastWordLength = cur.Length;
                }
            }

            if (string.IsNullOrEmpty(cur) == false)
            {
                for (int j = 0; j < maxCharPerLine - cur.Length; j++)
                {
                    ans += ' ';
                }
                ans += cur;
            }

            return ans;
        }

        static string CenterAlignment(string input, int maxCharPerLine)
        {
            string ans = "";
            string cur = "";
            int lastWordLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                cur += input[i];
                if (input[i] == '\n')
                {
                    for (int j = 0; j < (maxCharPerLine - cur.Length) / 2; j++)
                    {
                        ans += ' ';
                    }
                    ans += cur;
                    cur = "";
                    lastWordLength = 0;
                }
                else
                {
                    if (input[i] == ' ')
                    {
                        lastWordLength = 0;
                    }
                    else
                    {
                        lastWordLength++;
                    }
                }

                //Console.WriteLine(i + " " + lastWordLength + " " + cur);

                //if cur has length of maxCharPerLine
                if (cur.Length >= maxCharPerLine)
                {
                    string rem = "";
                    // if a word start but not end
                    // if there is some other word along with last word
                    if (lastWordLength > 0 && lastWordLength < maxCharPerLine)
                    {
                        rem = cur.Substring(maxCharPerLine - lastWordLength);
                        cur = cur.Remove(maxCharPerLine - lastWordLength);
                        //Console.WriteLine(cur + " " + rem);
                    }
                    for (int j = 0; j < (maxCharPerLine - cur.Length) / 2; j++)
                    {
                        ans += ' ';
                    }
                    ans += cur + '\n';
                    cur = rem;
                    lastWordLength = cur.Length;
                }
            }

            if (string.IsNullOrEmpty(cur) == false)
            {
                for (int j = 0; j < (maxCharPerLine - cur.Length) / 2; j++)
                {
                    ans += ' ';
                }
                ans += cur;
            }

            return ans;
        }

        static string JustifyAlignment(string input, int maxCharPerLine)
        {
            string ans = "";
            string cur = "";
            int lastWordLength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                cur += input[i];
                if (input[i] == '\n')
                {
                    ans += cur;
                    cur = "";
                    lastWordLength = 0;
                }
                else
                {
                    if (input[i] == ' ')
                    {
                        lastWordLength = 0;
                    }
                    else
                    {
                        lastWordLength++;
                    }
                }

                //Console.WriteLine(i + " " + lastWordLength + " " + cur);

                //if cur has length of maxCharPerLine
                if (cur.Length >= maxCharPerLine)
                {
                    string rem = "";
                    // if a word start but not end
                    // if there is some other word along with last word
                    if (lastWordLength > 0 && lastWordLength < maxCharPerLine)
                    {
                        rem = cur.Substring(maxCharPerLine - lastWordLength);
                        cur = cur.Remove(maxCharPerLine - lastWordLength);
                        //Console.WriteLine(cur + " " + rem);
                    }

                    int extraSpace = maxCharPerLine - cur.Length;
                    int totalWord = CountWord(ref cur);
                    int spaceBetweenWords = 0;
                    if (totalWord > 1)
                    {
                        spaceBetweenWords = extraSpace / (totalWord - 1);
                    }
                    int remainSpace = extraSpace - spaceBetweenWords * (totalWord - 1);
                    if (remainSpace > 0)
                    {
                        spaceBetweenWords++;
                    }
                    
                    //Console.WriteLine(extraSpace + " " + totalWord + " " + spaceBetweenWords);
                    
                    int wordNo = 0;
                    string cur2 = "";
                    // copying cur to cur2 with extra spaces between words
                    for (int j = 0; j < cur.Length;)
                    {
                        while (j < cur.Length && cur[j] == ' ')
                        {
                            cur2 += cur[j];
                            j++;
                        }
                        if (j < cur.Length)
                        {
                            wordNo++;
                        }
                        while (j < cur.Length && cur[j] != ' ')
                        {
                            cur2 += cur[j];
                            j++;
                        }
                        // cheking current word is not the lastword because we don't need to add spaces after last word
                        if (wordNo < totalWord)
                        {
                            for (int k = 0; k < spaceBetweenWords; k++)
                            {
                                cur2 += ' ';
                            }
                        }
                        if (wordNo == remainSpace)
                        {
                            spaceBetweenWords--;
                        }
                    }
                    //Console.WriteLine("cur  = \'" + cur + "\'");
                    //Console.WriteLine("cur2 = \'" + cur2 + "\'");
                    ans += cur2 + '\n';
                    cur = rem;
                    lastWordLength = cur.Length;
                }
            }

            if (string.IsNullOrEmpty(cur) == false)
            {
                ans += cur;
            }

            return ans;
        }

        // returns total number of words in a string
        static int CountWord(ref string input)
        {
            int word = 0;
            int j = 0;
            while (j < input.Length)
            {
                while (j < input.Length && input[j] == ' ')
                {
                    j++;
                }
                if (j < input.Length)
                {
                    word++;
                }
                while (j < input.Length && input[j] != ' ')
                {
                    j++;
                }
            }
            return word;
        }

        static void Main(string[] args)
        {
            string input = "My_name_is_Mohibur_Rahman. I study in Com\nilla University in ICT department.";

            Console.WriteLine("Left Alignment");
            Console.WriteLine("1---5---10---15---20---25---30");
            string ans = LeftAlignment(input, 20);
            Console.WriteLine(ans);

            Console.WriteLine("\nRight Alignment");
            Console.WriteLine("1---5---10---15---20---25---30");
            ans = RightAlignment(input, 20);
            Console.WriteLine(ans);

            Console.WriteLine("\nCenter Alignment");
            Console.WriteLine("1---5---10---15---20---25---30");
            ans = CenterAlignment(input, 20);
            Console.WriteLine(ans);

            Console.WriteLine("\nJustify Alignment");
            Console.WriteLine("1---5---10---15---20---25---30");
            ans = JustifyAlignment(input, 20);
            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
