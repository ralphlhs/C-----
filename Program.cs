using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextUsing();
        }

        static void Initialize(int[] deck)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }
        }

        // 문자열 사용.
        static void TextUsing()
        {
            string name = "이형섭";
            string message = String.Format("{0}님 {1} 안녕하세요", name, "졸라", 2);
            Console.WriteLine(message.Replace("안녕", "고생"));

            string data = "10, 20, 30, 40";
            string [] datas = data.Split(",");
            for (int i = 0; i < datas.Length; i++)
            {
                Console.WriteLine(datas[i].Trim());
            }

            int a = 2;
            float b = 3.4f;
            long c = 0;
            char d = (char)65;

            b = float.Parse(datas[a]);
            int.TryParse(datas[1], out a);
            Console.WriteLine(d);
            Console.WriteLine(((char)97).ToString() + " ");


            static void TrumpPicking()
            {
                uint A = 1103515245;
                uint C = 12345;
                uint M = 2147483648;

                uint seed = 1;
                int randomResult = 0;

                uint rand()
                {
                    seed = (A * seed + C) % M;
                    return seed;
                }

                int[] deck = new int[52];

                //Initialize
                for (int i = 0; i < deck.Length; i++)
                {
                    deck[i] = i + 1;
                }

                //Shuffle 
                Random random = new Random();
                for (int b = 0; b < 8; ++b)
                {
                    for (int i = 0; i < deck.Length * 10; ++i)
                    {
                        int firstCardIndex = random.Next(0, deck.Length);
                        int secondCardIndex = random.Next(0, deck.Length);

                        int temp = deck[firstCardIndex];
                        deck[firstCardIndex] = deck[secondCardIndex];
                        deck[secondCardIndex] = temp;
                        randomResult = temp;
                    }

                    int j = randomResult + 1;
                    string a = "";
                    if (j > 0 && j <= 13)
                    {
                        a = "Heart ";
                        if (j == 1) Console.WriteLine(a + " A");
                        else if (j > 1 && j < 11) Console.WriteLine(a + j);
                        else if (j == 11) Console.WriteLine(a + " J");
                        else if (j == 12) Console.WriteLine(a + " Q");
                        else if (j == 13) Console.WriteLine(a + " K");
                    }
                    else if (j >= 14 && j <= 26)
                    {
                        a = "Diamond ";
                        if (j == 14) Console.WriteLine(a + " A");
                        else if (j > 14 && j < 24) Console.WriteLine(a + (j - 13));
                        else if (j == 24) Console.WriteLine(a + " J");
                        else if (j == 25) Console.WriteLine(a + " Q");
                        else if (j == 26) Console.WriteLine(a + " K");
                    }
                    else if (j <= 27 && j <= 39)
                    {
                        a = "Clover ";
                        if (j == 27) Console.WriteLine(a + " A");
                        else if (j > 27 && j < 37) Console.WriteLine(a + (j - 26));
                        else if (j == 37) Console.WriteLine(a + " J");
                        else if (j == 38) Console.WriteLine(a + " Q");
                        else if (j == 39) Console.WriteLine(a + " K");
                    }
                    else if (j <= 40 && j <= 52)
                    {
                        a = "Spade ";
                        if (j == 40) Console.WriteLine(a + " A");
                        else if (j > 40 && j < 50) Console.WriteLine(a + (j - 39));
                        else if (j == 50) Console.WriteLine(a + " J");
                        else if (j == 51) Console.WriteLine(a + " Q");
                        else if (j == 52) Console.WriteLine(a + " K");
                    }
                    else Console.WriteLine("Joker");
                }
            }

            static void AddingNumber()
            {
                Random randomObj = new Random();

                List<int> list = new List<int>();

                int randomValue;

                for (int i = 0; i < 10; i++)
                {
                    randomValue = randomObj.Next(1, 52);

                    if (!list.Contains(randomValue))
                        list.Add(randomValue);
                }

                for (int i = 0; i < 8; i++)
                {
                    Console.Write(" " + list[i]);
                }
            }
        }
    }
}