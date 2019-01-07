var Tabuleiro = function () {

    var posicoes = [[], [], []];
    const dimensao = 3;

    //execucao automatica toda vez que eu iniciar sem precisar ficar chamando
    (function init() {

        for (var i = 0; i < dimensao; i++) {
            for (var i = 0; i < dimensao; i++) {
                this.posicoes[i][j] = null;
            }
        }

    })();

    this.adicionarJogada = function (linha, coluna, jogador) {
        this.posicoes[linha][coluna] = jogador;
    }

    function validarLinha(linha) {
        
    }

}