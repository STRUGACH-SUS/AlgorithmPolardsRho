using AlgorithmPolardsRho;

namespace TestAlgorithmPolardsRho;

public class UnitTest1
{
    [Theory]
    [InlineData(25,5,5)]
    [InlineData(49,7,7)]
    [InlineData(91,7,13)]
    [InlineData(143,11,13)]
    [InlineData(8051,83,97)]
    [InlineData(10403,101,103)]
    [InlineData(100160063,10007,10009)]
    [InlineData(16843009,257,65537)]
    public void Test1(int testNum, int answer1, int answer2)
    {
        var result = PolardsRho.Algorithm(testNum);
        if (result != answer1 && result != answer2)
        {
            Assert.Fail();
        }
        else
        {
            Assert.True(true);
        }
    }
}