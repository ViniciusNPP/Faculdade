using round_robin;

public class Program
{
    public static void Main(string[] args)
    {
        RoundRobin rr = new([
            "Bom dia, pessoal. Queria avisar que a reunião de alinhamento do projeto foi remarcada para amanhã às 14h na sala 3. Por favor, tragam as métricas atualizadas para discutirmos os próximos passos da sprint e não atrasarmos as entregas do trimestre. Qualquer dúvida, me chamem no privado.",

            "Alguém vai almoçar agora ou vão esperar mais um pouco?",

            "Estou com um problema na minha máquina, ela não quer conectar no Wi-Fi do escritório de jeito nenhum. Já reiniciei o roteador e o computador, mas continua dando erro de DNS. Teria como o pessoal do suporte dar uma olhada nisso logo após o almoço?",

            "Pode deixar, eu pego as crianças na escola hoje.",

            "Gente, acabei de enviar o relatório final do mês passado por e-mail. Deem uma revisada nos números da página quatro, achei que a margem de lucro ficou um pouco abaixo do que tínhamos projetado inicialmente. Talvez a gente precise rever o orçamento daquela campanha de marketing para o próximo trimestre.",

            "Confirmado para hoje à noite! Nos vemos no bar.",

            "Estou presa no trânsito, devo chegar uns 20 minutos atrasada.",

            "Não se esqueçam de preencher a planilha de ponto até o final do dia de hoje. O RH avisou que quem não enviar até as 18h vai ter o desconto no salário no mês que vem, então não deixem para a última hora!",

            "Para a festa surpresa da Ana, estava pensando em encomendar aquele bolo de chocolate com morango que ela adora lá da padaria do centro. Além disso, a gente podia comprar uns salgadinhos variados e uns refrigerantes. O que acham? Quem pode me ajudar a organizar a vaquinha para comprar os presentes e a decoração?",

            "O arquivo PDF que você mandou está corrompido, manda de novo."
        ]);
        rr.IniciarProcessos();
    }
}