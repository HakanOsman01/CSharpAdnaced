namespace InformationServices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sum = Console.ReadLine();
            int n = sum.Length;
            HashSet<string>allPosibilities= new HashSet<string>();
            double minSum = double.MaxValue;
            permute(sum, 0, n - 1,allPosibilities);
            //Console.WriteLine(minSum);
            List<string>allRealPosibilites= new List<string>();
           
            foreach(string currentPosibolte in allPosibilities)
            {
                if (currentPosibolte[0]=='.' || currentPosibolte[0]=='0'||
                    currentPosibolte[currentPosibolte.Length-1] == '.')
                {

                    continue;
                }
              
                allRealPosibilites.Add(currentPosibolte);
                
                
            }
            foreach (string currentPosibilte in allRealPosibilites)
            {
                double currentSum=double.Parse(currentPosibilte);
                if(minSum>currentSum)
                {
                    minSum=currentSum;
                }
            }
            int countMonet = 0;
            string strMinSum=minSum.ToString();
            for (int i = 0; i < strMinSum.Length; i++)
            {
                if (strMinSum[i]=='.' 
                    && i+1<strMinSum.Length && strMinSum[i + 1] == '0')
                {
                    strMinSum=strMinSum.Remove(i+1, 1);
                }
            }
            minSum = double.Parse(strMinSum)*100;
            int countMonets = CountConins(minSum);
            Console.WriteLine(countMonets);


        }
        private static void permute(string str,
                               int l, int r,HashSet<string>allPosibiltes)
        {
            if (l == r)
                allPosibiltes.Add(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r,allPosibiltes);
                    str = swap(str, l, i);
                }
            }
        }
        public static string swap(string a,
                           int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        static int CountConins(double minSum)
        {
            int countMonet = 0;
            while (minSum > 0)
            {
                if (minSum >= 1000)
                {
                    minSum -= 1000;
                    countMonet++;
                }
                else if (minSum >= 500)
                {
                    minSum -= 500;
                    countMonet++;
                }
                else if (minSum >= 200)
                {
                    minSum -= 200;
                    countMonet++;
                }
                else if (minSum >= 100)
                {
                    minSum -= 100;
                    countMonet++;
                }
                else if (minSum >= 50)
                {
                    minSum -= 50;
                    countMonet++;
                }
                else if (minSum >= 200)
                {
                    minSum -= 200;
                    countMonet++;
                }

                else if (minSum >= 100)
                {
                    minSum -= 100;
                    countMonet++;
                }
                else if (minSum >= 50)
                {
                    minSum -= 50;
                    countMonet++;
                }
                else if (minSum >= 20)
                {
                    minSum -= 20;
                    countMonet++;
                }
                else if (minSum >= 10)
                {
                    minSum -= 10;
                    countMonet++;
                }
                else if (minSum >= 5)
                {
                    minSum -= 5;
                    countMonet++;
                }
                else if (minSum >= 2)
                {
                    minSum -= 2;
                    countMonet++;
                }
                else if (minSum >= 1)
                {
                    minSum -= 1;
                    countMonet++;
                }

            }
            return countMonet;

        }


      
    }
}