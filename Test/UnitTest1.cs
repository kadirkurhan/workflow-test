namespace Test;
using GitWorkflow.Controllers;

public class UnitTest1
{
    [Fact]
    public void OK_WhenParameterPassEven_ShouldReturnEven_GetEndpoint()
    {
        // Arrange
        var controller = new TestController();

        // Aspect
        var response = controller.IsOddOrEven(10);

        // Assert
        Assert.Equal("even", response);
    }

    [Fact]
    public void OK_WhenParameterPassOdd_ShouldReturnOdd_GetEndpoint()
    {
        // Arrange
        var controller = new TestController();

        // Aspect
        var response = controller.IsOddOrEven(1);

        // Assert
        Assert.Equal("odd", response);
    }

    [Fact]
    public void OK_WhenParameterPassZero_ShouldReturnException_DivideEndpoint()
    {
        // Arrange
        var controller = new TestController();

        // Aspect
        // Assert
        Assert.Throws<DivideByZeroException>(() => controller.DivideByParameter(0));
    }
}
