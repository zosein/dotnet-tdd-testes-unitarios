using Calculadora.Services;
using Xunit;


namespace MinhaCalculadoraTestes;

public class MinhaCalculadoraTestes
{
    [Fact]
    public void DeveRetornarASomaEntre2Numeros()
    {
        // Arrange
        var calculadora = new CalculadoraImplementacao();

        // Act
        var resultado = calculadora.Somar(2, 3);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveRetornarADiferencaEntre2Numeros()
    {
        // Arrange
        var calculadora = new CalculadoraImplementacao();

        // Act
        var resultado = calculadora.Subtrair(5, 3);

        // Assert
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void DeveRetornarOProdutoEntre2Numeros()
    {
        // Arrange
        var calculadora = new CalculadoraImplementacao();

        // Act
        var resultado = calculadora.Multiplicar(2, 3);

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void DeveRetornarOQuocienteEntre2Numeros()
    {
        // Arrange
        var calculadora = new CalculadoraImplementacao();

        // Act
        var resultado = calculadora.Dividir(6, 3);

        // Assert
        Assert.Equal(2, resultado);
    }
}