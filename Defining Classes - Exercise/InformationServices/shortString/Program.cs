using System.Text;
namespace shortString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for(int k = 0; k <= 9; k++)
                    {
                        for (int o = 0; o <= 9; o++)
                        {
                            //Console.Write($"{i}{j}{k}{o}");
                            char firstDigith= (char)(i + 48); ;
                            char secondDigith= (char)(j+48);
                            char thirdDigith= (char)(k+48);
                            char fourthDigith= (char)(o+48);
                            char[]currentCombination= new char[4];
                            {
                                currentCombination[0]=firstDigith;
                                currentCombination[1]=secondDigith;
                                currentCombination[2]=thirdDigith;
                                currentCombination[3]=fourthDigith;
                            }
                            string combination = new string(currentCombination);
                          
                            stringBuilder.Append(combination+" ");
                            
                           
                        }
                    }
                }
            }
            string strBuilder= stringBuilder.ToString();
            Console.WriteLine(strBuilder);
        }
    }
}