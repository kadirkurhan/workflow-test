namespace Test;
using GitWorkflow.Controllers;

public class UnitTest1
{
    [Fact]
    public void OK_WhenReturnOdd_GetEndpoint()
    {
        // Arrange
        var controller = new TestController();

        // Aspect
        var response = controller.Get(1);

        // Assert
        Assert.Equal("even", response);
    }
}
