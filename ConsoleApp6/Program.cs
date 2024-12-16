class Program
{
    static void Main()
    {
        float[] A = new float[5];
        float[,] B = new float[3, 4];
        Random rand = new Random();
        float max = float.MinValue, min = float.MaxValue, sumA = 0, sumB = 0, productA = 1;
        int evenSumA = 0, oddColSumB = 0;

        for (int i = 0; i < 5; i++)
        {
            A[i] = float.Parse(Console.ReadLine());
            sumA += A[i];
            if (A[i] > max) max = A[i];
            if (A[i] < min) min = A[i];
            if (A[i] % 2 == 0) evenSumA += (int)A[i];
        }

        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 4; j++)
            {
                B[i, j] = (float)(rand.NextDouble() * 200 - 100);
                sumB += B[i, j];
                productA *= A[i % 5];
                if (j % 2 != 0) oddColSumB += (int)B[i, j];
            }

        Console.WriteLine(string.Join(" ", A));
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
                Console.Write(B[i, j] + " ");
            Console.WriteLine();
        }

        Console.WriteLine($"Max: {max}, Min: {min}, Sum: {sumA + sumB}, Product: {productA}, Even Sum A: {evenSumA}, Odd Col Sum B: {oddColSumB}");
    }
}
class Program
{
    static void Main()
    {
        int[,] array = new int[5, 5];
        Random rand = new Random();
        int min = int.MaxValue, max = int.MinValue, sum = 0;

        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = rand.Next(-100, 101);
                if (array[i, j] < min) min = array[i, j];
                if (array[i, j] > max) max = array[i, j];
            }

        bool between = false;
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] == min) between = true;
                if (between) sum += array[i, j];
                if (array[i, j] == max) between = false;
            }

        Console.WriteLine($"Sum between min and max: {sum}");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();
        Console.WriteLine("Зашифрований: " + CaesarCipher(input, 3));
        Console.WriteLine("Розшифрований: " + CaesarCipher(input, -3));
    }

    static string CaesarCipher(string text, int shift)
    {
        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            letter = (char)(letter + shift);
            if (letter > 'z') letter = (char)(letter - 26);
            else if (letter < 'a') letter = (char)(letter + 26);
            buffer[i] = letter;
        }
        return new string(buffer);
    }
}
class Program
{
    static void Main()
    {
        int[,] A = { { 1, 2 }, { 3, 4 } };
        int[,] B = { { 5, 6 }, { 7, 8 } };
        int scalar = 2;

        int[,] C = MultiplyMatrixByScalar(A, scalar);
        int[,] D = AddMatrices(A, B);
        int[,] E = MultiplyMatrices(A, B);
    }

    static int[,] MultiplyMatrixByScalar(int[,] matrix, int scalar) 
    static int[,] AddMatrices(int[,] A, int[,]
class Program
    {
        static void Main()
        {
            Console.WriteLine("Int ur number:");
            string input = Console.ReadLine();
            string[] parts = input.Split(new char[] { '+', '-' });
            int result = 0;
            char lastOp = '+';

            foreach (var part in parts)
            {
                int number = int.Parse(part);
                if (lastOp == '+') result += number;
                else result -= number;
                lastOp = input[input.IndexOf(part) + part.Length];
            }

            Console.WriteLine($"Result: {result}");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Text:");
            string inputText = Console.ReadLine();
            string[] sentences = inputText.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
                if (sentences[i].Length > 0)
                    sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
            }

            string resultText = string.Join(". ", sentences).Trim() + ".";
            Console.WriteLine(resultText);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string inputText = Console.ReadLine();
            string forbiddenWord = "die";
            string replacement = new string('*', forbiddenWord.Length);
            int replacementCount = 0;

            string[] lines = inputText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(forbiddenWord))
                {
                    int countInLine = CountOccurrences(lines[i], forbiddenWord);
                    replacementCount += countInLine;
                    lines[i] = lines[i].Replace(forbiddenWord, replacement);
                }
            }

            string resultText = string.Join("\n", lines);
            Console.WriteLine(resultText);
            Console.WriteLine($"Status: {replacementCount} change words {forbiddenWord}.");
        }

        static int CountOccurrences(string line, string word)
        {
            int count = 0, index = 0;
            while ((index = line.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += word.Length;
            }
            return count;
        }
    }