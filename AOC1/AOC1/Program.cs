namespace AOC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "data.txt";
            string line;
            string currentNum = "";
            string[] lineArr = new string[1000];
            string[] combinedNums = new string[1000];
            int i = 0;
            int sum = 0;

            Console.WriteLine("Hello, World!");

            using (StreamReader sr = new StreamReader(filename))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lineArr[i] = line;
                    i++;
                }
            }


            for(i = 0; i < lineArr.Length; i++)
            {
                line = lineArr[i];
                for(int j = 0; j < line.Length; j++)
                {
                    if (line[j] >= 48 && line[j] <= 57)
                    {
                        currentNum = currentNum + line[j];
                        break;
                    }
                }

                for(int j = line.Length - 1; j >= 0; j--)
                {
                    if (line[j] >= 48 && line[j] <= 57)
                    {
                        currentNum = currentNum + line[j];
                        break;
                    }
                }
                combinedNums[i] = currentNum;
                currentNum = "";
            }

            for(i = 0; i < combinedNums.Length; i++)
            {
                Console.WriteLine(combinedNums[i]);
                sum = sum + (int.Parse(combinedNums[i]));
            }
            Console.WriteLine("Answer is {0}", sum);
        }
    }
}