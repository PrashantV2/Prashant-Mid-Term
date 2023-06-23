using NUnit.Framework;

[TestFixture]

public class Testing
{

    public int width,height,diagnal;
    [Test]
  public void  PPICalculate_inputWidth34andHeight68andDiagnal9_OutputValuePPI(){
        // Arrange
        width = 34;
        height = 68;
        diagnal = 9;
        
        // Act
        Dictionary<string,double> result = PixelCalc.PixelCalcFunction(height,width,diagnal);

        // Assert
        Assert.AreEqual(8.447367914999205, result["PPI"]);
       
  }

    [Test]
    public void PPICalculate_inputWidth543andHeightNegative168andDiagnal49_OutputValuePPI()
    {
        // Arrange
        width = 543;
        height = -168;
        diagnal = 49;

        // Act
        Dictionary<string, double> result = PixelCalc.PixelCalcFunction(height, width, diagnal);

        // Assert
        Assert.AreEqual(11.599900184838189, result["PPI"]);

    }
    [Test]
    public void PPICalculate_inputWidth1920andHeight1080andDiagnal23_OutputValuePPI()
    {
        // Arrange
        width = 1920;
        height = 1080;
        diagnal = 23;

        // Act
        Dictionary<string, double> result = PixelCalc.PixelCalcFunction(height, width, diagnal);

        // Assert
        Assert.AreEqual(95.77857261227383, result["PPI"]);

    }
    [Test]
    public void PPICalculate_inputWidth0andHeight43andDiagnal87_OutputValuePPI()
    {
        // Arrange
        width = 0;
        height = 43;
        diagnal = 87;

        // Act
        Dictionary<string, double> result = PixelCalc.PixelCalcFunction(height, width, diagnal);

        // Assert
        Assert.AreEqual(0.4942528735632184, result["PPI"]);

    }



}
