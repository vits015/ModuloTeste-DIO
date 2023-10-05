using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp calc = new CalculadoraImp();
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resultado = calc.Somar(num1,num2);

        // Assert
        Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = calc.Somar(num1,num2);

        // Assert
        Assert.Equal(20, resultado);
    }
    [Fact]
    public void DeveSomar5Com5ERetornar10()
    {
        // Arrange
        int num1 = 5;
        int num2 = 5;

        // Act
        int resultado = calc.Somar(num1,num2);

        // Assert
        Assert.Equal(10, resultado);
    }
}