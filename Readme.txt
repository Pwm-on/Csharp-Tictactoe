English:
Tictactoe is a game where the objective is to score 3 signs in one of this positions: 
1) Horizontal;
2) Vertical; 
3) Diagonal. 

First player to score 3 signs (a 'X' or an 'O'), wins.
This project was made in C# using netcoreapp 3.1 and consists with two classes:
1) 'Program'; 
2) 'Board'. 

'Board' controls both games (Player vs Player or Player vs CPU).
'Board' has all the necessary methods to make work this game, so when class 'Program' begins, 
the player has two options:
1) Player vs Player;
2) Player vs CPU.

'Board' control all methods and the main difference between options 1 and 2, is that option 2 implements
ComputerPlaying() method. So choosing to play Player vs Player:
    1) Game begins with 'X' choosing a place. After that, it's 'O'. All even turns are 'X', odds 'O' (to decide which turn is it, it's necessery to make turn mod 2).
    2) In case players choose a place have already been marked, a do-while loop will prevent players to to do this.
    3) And finally, a method ("EndingCondition())
    verifys if one of the players have won.

And choosing Player vs CPU (option 2), the difference is ComputerPlaying() method. This method randomly chooses a place that has not been picked yet.

Português:

Tictactoe é um jogo onde o objetivo é marcar 3 sinais em uma das seguintes posições: 
1) Horizontal;
2) Vertical; 
3) Diagonal. 

O primeiro jogador a marcar 3 sinais (um 'X' ou um 'O'), vence.
Este projeto foi feito em C# usando netcoreapp 3.1 e consiste em duas classes:
1) 'Program'; 
2) 'Board'. 


'Board' controla ambos os jogos (Jogador vs Jogador ou Jogador vs CPU).
'Board' tem todos os métodos necessários para fazer o trabalho deste jogo, então quando a classe 'Program' começa, 
o jogador tem duas opções:
1) Jogador vs Jogador;
2) Jogador vs CPU.

'Board' controla todos os métodos e a principal diferença entre as opções 1 e 2, é que a opção 2 implementa
Método ComputerPlaying(). Então, optando por jogar Player vs Player:
    1) O jogo começa com 'X' escolhendo um lugar. Depois disso, é "O". Todas as voltas são 'X', odds 'O' (para decidir qual é a vez, é necessário fazer a curva mod 2).
    2) Caso os jogadores escolham um lugar já marcado, um loop de fazer enquanto impedirá que os jogadores façam isso.
    3) E, finalmente, um método ("EndCondition())
    verifica se um dos jogadores ganhou.

E escolhendo Player vs CPU (opção 2), a diferença é o método ComputerPlaying(). Este método escolhe aleatoriamente um lugar que ainda não foi escolhido.
