class Program
{
    static void Main(string[] args)
    {
        String userEnterOption;
        bool whileExit = true;
        int pixelHeight;
        int pixelWidth;
        int pixelDiagonalSize;
        do
        {
            Console.WriteLine("1. Enter Screen dimensions");
            Console.WriteLine("2. Exit");
            userEnterOption = Console.ReadLine();
            if(userEnterOption == "1")
            {
                whileExit = false;
                wrongInputDisplay:
                Console.WriteLine("Enter Screen width in pixels");
                bool heigtCheck = int.TryParse(Console.ReadLine(), out pixelHeight);
                Console.WriteLine("Enter Screen Height in pixels");
                bool widthCheck = int.TryParse(Console.ReadLine(), out pixelWidth);
                Console.WriteLine("Enter Screen diagonal Size in pixels");
                bool diagonalCheck = int.TryParse(Console.ReadLine(), out pixelDiagonalSize);
                if(heigtCheck == true && widthCheck == true && diagonalCheck == true){
                    Dictionary<string, double> result =  PixelCalc.PixelCalcFunction(pixelHeight, pixelWidth, pixelDiagonalSize);
                    Console.WriteLine(result["PPI"]);
                    Console.WriteLine(result["Diagonal"]);
                    Console.WriteLine(result["Dot"]);
                }
                else
                {
                    Console.WriteLine("Enter Correct input ");
                    goto wrongInputDisplay;
                }

            }
            else if(userEnterOption == "2")
            {
                whileExit = false;
            }
            else
            {
                Console.WriteLine("Enter Correct Option");
                whileExit = true;

            }
          
            
        } while (whileExit);
    }
}