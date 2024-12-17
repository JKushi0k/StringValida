using Texto.Services;

namespace TextoTest;


public class TextoCurtoTeste
{
    private TextoCurto _validacoes = new TextoCurto();

    [Fact]
    public void TestQuantidadeCaracteres()
    {
        var texto = "A cada passo, um aprendizado; a cada erro, uma nova chance de recomeçar.";
        var resultadoEsperado = 72;

        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ContemAPalavraQualquerNoTexto()
    {
        var texto = "A cada passo, um aprendizado; a cada erro, uma nova chance de recomeçar.";
        var palavraProcurado = "aprendizado";

        var resultado = _validacoes.ContemAPalavraQualquerNoTexto(texto, palavraProcurado);

        Assert.True(resultado);
    }
}
