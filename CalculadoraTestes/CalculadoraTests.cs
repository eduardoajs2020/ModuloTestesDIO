using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private readonly CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveverificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;
   
        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True( resultado);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]

    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    {
        
        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2 , 4})]
    [InlineData(new int[] { 6, 8, 10})]
    

    public void DeveVerificarSeOsNumerosDoArraySaoParesERetornarVerdadeiro(int[] numeros)
    {

        //Act/ Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }

}