using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{

    CalculadoraImp calc = new CalculadoraImp();

    [Fact]
    public void TestandoSomar()
    {
        // Arrange
        int num1 = 2;
        int num2 = 2;
        int resultadoEsperado = 4;

        // Act
        int resp = calc.Somar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resp);

    }

    [Theory]
    [InlineData (5, 2, 3)]
    [InlineData (10, 7, 3)]
    [InlineData (200, 100, 100)]
    [InlineData (15, 15, 0)]
    public void TestandoSubtrair(int num1, int num2, int resultadoEsperado)
    {
       int resp = calc.Subtrair(num1, num2);

       Assert.Equal(resultadoEsperado, resp);
        
    }

    [Theory]
    [InlineData (2, 5, 10)]
    [InlineData (5, 5, 25)]
    [InlineData (1, 7, 7)]
    [InlineData (4, 3, 12)]
    public void TestandoMultiplicar(int num1, int num2, int resultadoEsperado)
    {
        int resp = calc.Multiplicar(num1, num2);

        Assert.Equal(resultadoEsperado, resp);
    }

    [Theory]
    [InlineData (10, 2, 5)]
    [InlineData (16, 2, 8)]
    [InlineData (15, 3, 5)]
    [InlineData (21, 3, 7)]
    public void TestandoDividir(int num1, int num2, int resultadoEsperado)
    {
        int resp = calc.Dividir(num1, num2);

        Assert.Equal(resultadoEsperado, resp);
    }

}