namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            int n = int.Parse(Console.ReadLine());
            Stack<string>textPreviosStates=new Stack<string>();
            textPreviosStates.Push(text);
            for (int i = 1; i <= n; i++)
            {
                string[]commandsSplit=Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int indexAction = int.Parse(commandsSplit[0]);
                switch (indexAction)
                {
                    case 1:
                        string appendText = commandsSplit[1].ToString();
                        text = text + appendText;
                        textPreviosStates.Push(text);
                        break;
                    case 2:
                        int count = int.Parse(commandsSplit[1]);
                        for (int j = 1; j <= count; j++)
                        {
                            text = text.Remove(text.Length - 1);
                        }
                        textPreviosStates.Push(text);
                        break;
                    case 3:
                        int index= int.Parse(commandsSplit[1]);
                        Console.WriteLine(text[index-1]);
                        break;
                    case 4:

                        textPreviosStates.Pop();
                        text=textPreviosStates.Peek();
                        break;

                }
            }
        }
    }
}