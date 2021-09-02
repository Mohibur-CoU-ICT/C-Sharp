using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatingPractice1
{
    class LeftAlign
    {
        public const int LEFT = 1;
        public const int RIGHT = 2;
        public const int CENTER = 3;
        public const int JUSTIFY = 4;

        static void Main(string[] args)
        {
            string input = "My name is Mohibur Rahman. I study in Comi\nlla University in ICT department. ThisIsALargeText.ThisTextWillNotOccupiedInASingleLine.HowDoYouHandleIt?";

            string ans = DoAlignment(input, 30, LEFT);
            Console.WriteLine("\nLeft Alignment");
            Console.WriteLine("1---5---10---15---20---25---30---35---40---45---50");
            Console.WriteLine(ans);

            ans = DoAlignment(input, 30, RIGHT);
            Console.WriteLine("\nRight Alignment");
            Console.WriteLine("1---5---10---15---20---25---30---35---40---45---50");
            Console.WriteLine(ans);

            ans = DoAlignment(input, 30, CENTER);
            Console.WriteLine("\nCenter Alignment");
            Console.WriteLine("1---5---10---15---20---25---30---35---40---45---50");
            Console.WriteLine(ans);

            ans = DoAlignment(input, 30, JUSTIFY);
            Console.WriteLine("\nJustify Alignment");
            Console.WriteLine("1---5---10---15---20---25---30---35---40---45---50");
            Console.WriteLine(ans);

            Console.ReadKey();
        }

        static string DoAlignment(string input, int maxCharacterPerLine, int kindOfAlignment)
        {
            string ans = "";
            string cur = "";
            bool lastWordStart = false;
            bool lastChar;
            int lastWordLength = 0;
            int charCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // checking if last word start or not
                if ((i == 0 && input[i] != ' ') || (i > 0 && input[i - 1] == ' ' && input[i] != ' '))
                {
                    lastWordStart = true;
                }
                // if current char is a newline char then immediately add current string and a newline to answer
                if (input[i] == '\n')
                {
                    //Console.WriteLine("\'{0}\'", cur);
                    if (kindOfAlignment == LEFT)
                    {
                        
                    }
                    else if (kindOfAlignment == RIGHT)
                    {
                        for (int j = 0; j < maxCharacterPerLine - cur.Length; j++)
                        {
                            ans += ' ';
                        }
                    }
                    else if (kindOfAlignment == CENTER)
                    {
                        cur = cur.Trim();
                        for (int j = 0; j < (maxCharacterPerLine - cur.Length) / 2; j++)
                        {
                            ans += ' ';
                        }
                    }
                    else if (kindOfAlignment == JUSTIFY)
                    {

                    }
                    //common for all category
                    ans += cur + '\n';
                    cur = "";
                    charCount = 0;
                    lastWordLength = 0;
                }
                else
                {
                    cur += input[i];
                    charCount++;
                    if (input[i] == ' ')
                    {
                        lastWordStart = false;
                        lastWordLength = 0;
                    }
                    else
                    {
                        if (lastWordStart)
                        {
                            lastWordLength++;
                        }
                    }
                }

                //debugging
                //Console.WriteLine("i={0}, charCount={1}, lastWordLength={2}, cur={3}", i, charCount, lastWordLength, cur);

                // check if ith char is end of a word
                lastChar = (i == input.Length - 1 || (i + 1 < input.Length && input[i + 1] == ' '));

                if (charCount >= maxCharacterPerLine)
                {
                    //Console.WriteLine("Maximum char reach");
                    if (kindOfAlignment == LEFT)
                    {
                        DoLeftAlignment(lastChar, ref ans, ref cur, lastWordStart, ref charCount, ref lastWordLength, maxCharacterPerLine);
                    }
                    else if (kindOfAlignment == RIGHT)
                    {
                        DoRightAlignment(lastChar, ref ans, ref cur, lastWordStart, ref charCount, ref lastWordLength, maxCharacterPerLine);
                    }
                    else if (kindOfAlignment == CENTER)
                    {
                        DoCenterAlignment(lastChar, ref ans, ref cur, lastWordStart, ref charCount, ref lastWordLength, maxCharacterPerLine);
                    }
                    else if (kindOfAlignment == JUSTIFY)
                    {
                        DoJustifyAlignment(lastChar, ref ans, ref cur, lastWordStart, ref charCount, ref lastWordLength, maxCharacterPerLine);
                    }
                }
            }

            if (string.IsNullOrEmpty(cur) == false)
            {
                //Console.WriteLine("\'{0}\'", cur);
                if (kindOfAlignment == LEFT)
                {

                }
                else if (kindOfAlignment == RIGHT)
                {
                    for (int j = 0; j < maxCharacterPerLine - cur.Length; j++)
                    {
                        ans += ' ';
                    }
                }
                else if (kindOfAlignment == CENTER)
                {
                    cur = cur.Trim();
                    for (int j = 0; j < (maxCharacterPerLine - cur.Length) / 2; j++)
                    {
                        ans += ' ';
                    }
                }
                else if (kindOfAlignment == JUSTIFY)
                {

                }
                ans += cur;
            }

            return ans;
        }

        static void DoLeftAlignment(bool lastChar, ref string ans, ref string cur, bool lastWordStart, ref int charCount, ref int lastWordLength, int maxCharacterPerLine)
        {
            //Console.WriteLine("lastChar = " + lastChar + ", lastWordStart = " + lastWordStart);
            string remain = "";
            // if a word length is greater than maxCharacterPerLine
            if (lastWordStart)
            {
                if (lastWordLength < maxCharacterPerLine && !lastChar)
                {
                    //Console.WriteLine("IFIF");
                    remain = cur.Substring(cur.Length - lastWordLength);
                    cur = cur.Remove(cur.Length - lastWordLength, lastWordLength);
                }
            }
            //Console.WriteLine("\'{0}\'", cur);
            ans += cur + '\n';
            cur = remain;
            charCount = cur.Length;
            lastWordLength = cur.Length;
        }

        static void DoRightAlignment(bool lastChar, ref string ans, ref string cur, bool lastWordStart, ref int charCount, ref int lastWordLength, int maxCharacterPerLine)
        {
            //Console.WriteLine("lastChar = " + lastChar + ", lastWordStart = " + lastWordStart);
            string remain = "";
            // if a word length is greater than maxCharacterPerLine
            if (lastWordStart)
            {
                if (lastWordLength < maxCharacterPerLine && !lastChar)
                {
                    //Console.WriteLine("IFIF");
                    remain = cur.Substring(cur.Length - lastWordLength);
                    cur = cur.Remove(cur.Length - lastWordLength, lastWordLength);
                }
            }
            //Console.WriteLine("\'{0}\'", cur);
            for (int j = 0; j < maxCharacterPerLine - cur.Length; j++)
            {
                ans += ' ';
            }
            ans += cur + '\n';
            cur = remain;
            charCount = cur.Length;
            lastWordLength = cur.Length;
        }

        static void DoCenterAlignment(bool lastChar, ref string ans, ref string cur, bool lastWordStart, ref int charCount, ref int lastWordLength, int maxCharacterPerLine)
        {
            //Console.WriteLine("lastChar = " + lastChar + ", lastWordStart = " + lastWordStart);
            string remain = "";
            // if a word length is greater than maxCharacterPerLine
            if (lastWordStart)
            {
                if (lastWordLength < maxCharacterPerLine && !lastChar)
                {
                    //Console.WriteLine("IFIF");
                    remain = cur.Substring(cur.Length - lastWordLength);
                    cur = cur.Remove(cur.Length - lastWordLength, lastWordLength);
                }
            }
            //Console.WriteLine("\'{0}\'", cur);
            cur = cur.Trim();
            for (int j = 0; j < (maxCharacterPerLine - cur.Length) / 2; j++)
            {
                ans += ' ';
            }
            ans += cur + '\n';
            cur = remain;
            charCount = cur.Length;
            lastWordLength = cur.Length;
        }

        static void DoJustifyAlignment(bool lastChar, ref string ans, ref string cur, bool lastWordStart, ref int charCount, ref int lastWordLength, int maxCharacterPerLine)
        {
            //Console.WriteLine("lastChar = " + lastChar + ", lastWordStart = " + lastWordStart);
            string remain = "";
            // if a word length is greater than maxCharacterPerLine
            if (lastWordStart)
            {
                if (lastWordLength < maxCharacterPerLine && !lastChar)
                {
                    //Console.WriteLine("IFIF");
                    remain = cur.Substring(cur.Length - lastWordLength);
                    cur = cur.Remove(cur.Length - lastWordLength, lastWordLength);
                }
            }
            //Console.WriteLine("\'{0}\'", cur);
            //cur = cur.Trim();
            int extraSpace = maxCharacterPerLine - cur.Length;
            int word = CountWordInAString(ref cur);
            int spaceBetweenWord = 0;
            if (word > 1)
            {
                spaceBetweenWord = extraSpace / (word - 1);
            }
            int rem = extraSpace - spaceBetweenWord * (word - 1);
            if(rem > 0)
            {
                spaceBetweenWord++;
            }
            
            //Console.WriteLine(extraSpace + " " + word + " " + spaceBetweenWord + " " + rem);
            
            string cur2 = "";
            int cWord = 0;
            for (int j = 0; j<cur.Length; )
            {
                while (j < cur.Length && cur[j] == ' ')
                {
                    cur2 += ' ';
                    j++;
                }
                if (j < cur.Length)
                {
                    cWord++;
                }
                while (j < cur.Length && cur[j] != ' ')
                {
                    cur2 += cur[j];
                    j++;
                }
                if (cWord < word)
                {
                    for (int k = 0; k < spaceBetweenWord; k++)
                    {
                        cur2 += ' ';
                    }
                }
                if (cWord >= rem)
                {
                    spaceBetweenWord--;
                }
            }
            //Console.WriteLine("\'{0}\'", cur2);
            ans += cur2 + '\n';
            cur = remain;
            charCount = cur.Length;
            lastWordLength = cur.Length;
        }

        static int CountWordInAString(ref string s)
        {
            int word = 0;
            int i = 0;
            while (i < s.Length)
            {
                while (i < s.Length && s[i] == ' ')
                {
                    i++;
                }
                if (i < s.Length)
                {
                    word++;
                }
                while (i < s.Length && s[i] != ' ')
                {
                    i++;
                }
            }
            return word;
        }
    }
}
