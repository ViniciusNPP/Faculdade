using Roteiro.Roteiro4.Roteiro4._1;

string[] metodoPagamento = { "pix", "cartao", "boleto" };

foreach (var i in metodoPagamento)
{
    if (i == "pix")
    {
        Pix pix = new Pix();
        pix.ProcessarPagamento();
    }
    else if (i == "cartao")
    {
        CartaoCredito cartao = new CartaoCredito();
        cartao.ProcessarPagamento();
    }
    else
    {
        BoletoBancario boleto = new BoletoBancario();
        boleto.ProcessarPagamento();
    }
}