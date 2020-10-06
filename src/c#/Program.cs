using System;

namespace programa_boliche
{
    class Program
    {
        static void Main(string[] args)
        {

            // PROGRAMA BOLICHE 
            // const 
            int qtd_frames = 2; //10
            int qtd_pinos_por_frame = 10;
            int qtd_arremessos_por_frame = 2;
            int qtd_maxima_jogadores = 4;
            int pontuacao_minima_jogo = 120;
            int pontuacao_maxima_jogo = 170;

            //  variaveis 
            bool fim_partida = false;

            // lê Quantidade de Jogadores (de 1 a 4)
            string val;
            int qtd_jogadores = 0;
            do
            {
                Console.Write("Quantidade de Jogadores: ");
                val = Console.ReadLine();
                qtd_jogadores = Convert.ToInt32(val);
            }
            while (qtd_jogadores <= 0 || qtd_jogadores > qtd_maxima_jogadores);

            while (!fim_partida)
            {
                // inicio da partida
                int frame = 1;
                int jogador = 1;
                int total_pontos_frame = 0;

                while (frame <= qtd_frames)
                {
                    while (jogador <= qtd_jogadores)
                    {
                        int soma_pontos_jogo = 0;

                        // inicio do frame
                        int strike_primeiro_frame = 0;
                        int spare_segundo_frame = 0;
                        int arremesso = 1;

                        while (arremesso <= qtd_arremessos_por_frame)
                        {
                            // inicio do arremeço
                            int qtd_pinos_derrubados = 0;
                            do
                            {
                                Console.Write("Quantidade de Pinos Derrubados (Frame " + frame + " | Jogador " + jogador + " | Arremesso " + arremesso + "): ");
                                val = Console.ReadLine();
                                qtd_pinos_derrubados = Convert.ToInt32(val);
                            }
                            while (qtd_pinos_derrubados < 0 || qtd_pinos_derrubados > qtd_pinos_por_frame);

                            total_pontos_frame = total_pontos_frame + qtd_pinos_derrubados;

                            arremesso += 1;
                        }
                        jogador += 1;

                    }
                    frame += 1;

                    Console.WriteLine($"Total de Pontos do Jogador {jogador}: " + total_pontos_frame);
                }

                fim_partida = true;
            }

        }
    }
}
