using Xunit;

namespace MinhaApi.Tests;

public class UnitTest1
{
    [Fact]
    public void TesteSimples()
    {
        Assert.True(true);
    }

    [Fact]
    public void Soma_DeveFuncionar()
    {
        int resultado = 2 + 2;
        Assert.Equal(4, resultado);
    }

    [Fact]
    public void Produto_NaoPodeSerNulo()
    {
        var produto = new object();
        Assert.NotNull(produto);
    }
}