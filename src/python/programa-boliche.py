
# PROGRAMA BOLICHE #
# const #
qtd_frames = 10
qtd_pinos_por_frame = 10
qtd_arremessos_por_frame = 2
qtd_maxima_jogadores = 4
pontuacao_minima_jogo = 120
pontuacao_maxima_jogo = 170

#  variaveis #
fim_partida = 0

qtd_jogadores = input("Quantidade de Jogadores: ")

while fim_partida == 0:
    jogador = 1

    while jogador <= qtd_jogadores:
        # inicio da partida
        frame = 1
        soma_pontos_jogo = 0
        total_pontos_frame = 0

        while frame <= qtd_frames:
            # inicio do frame
            strike_primeiro_frame = 0
            spare_segundo_frame = 0
            arremesso = 1

            while arremesso <= qtd_arremessos_por_frame:
                # inicio do arremeço
                qtd_pinos_derrubados = input("Quantidade de Pinos Derrubados (Jogador "+jogador+"/Frame "+frame+"/Arremeço "+arremeco+"): ")
                total_pontos_frame = total_pontos_frame + qtd_pinos_derrubados

                arremesso += 1
            frame += 1
        jogador += 1

    fim_partida = 1

