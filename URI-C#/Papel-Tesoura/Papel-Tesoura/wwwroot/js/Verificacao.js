


$('#JogoSpock').submit(function () {

    var opcoes = ['Tesoura','tesoura','papel','Papel','pedra','Pedra','lagarto','Lagarto','Spock','spock'];
  
    var campo01 = $('#Spock01').val();
    var campo02 = $('#Spock02').val();


    if (opcoes.indexOf(campo01) == -1 || opcoes.indexOf(campo02) == -1) {
        alert("Nao obedece a regra do jogo!!");
        window.location.reload(true);
    }


});