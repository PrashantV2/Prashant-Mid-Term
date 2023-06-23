public static class PixelCalc
{
    public  static Dictionary<string,double>  PixelCalcFunction(double height,double width,double diagnal)
    {
        double diagnalResult = Math.Sqrt(height*height + width*width);

        double dotPath = diagnal / diagnalResult;

        double ppi = diagnalResult / diagnal;
        var result = new Dictionary<string, double>();
        result["PPI"] = ppi;
        result["Diagonal"] = diagnalResult;
        result["Dot"] = dotPath;
        return result;
         

    }
}