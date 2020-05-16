# Projeto 2 Linguagens de Progrmação I 2019/2020 - Felli

## Autoria

Nelson salvador n21901530 | Pedro Coutinho n21905323 | Miguel Martinho n21901530

Nelson Salvador:
- Classes Game, Positions e Output   
- Sistema de criação do tabuleiro
- Sistema de criação das peças
- Sistema de movimento das peças simples
- Sistema de prints e estética do programa na consola
- Sistema de input mais avançado

Pedro Coutinho:
- Classe CheckMove
- Sistema de movimento das peças melhorado e funcional
- Sistema de verficação do movimento das peças entre si
- Correção de bugs

Miguel Martinho:
- Relatório
- Sistema de turnos
- Sistema inical de verificação do movimento das peças
- Sistema incial de input
- Sistema para comer peças/remover do board

## Arquitetura de Solução

Classe Program instância as peças no tabuleiro. Dá essa
informação ao método gameloop da classe Game, dentro deste método é onde
o programa passa a maior parte do tempo, graças ao ciclo *do while* que apenas
termina quando um dos jogadores ganhar ou se os jogadores terminarem o jogo. 

O método gameloop começa por dar print das instruções e do tabuleiro (vindas da
classe output onde está tudo o que é escrito na consola) depois a partir de um 
*if* verifica se um jogo está a decorrer, se nenhum jogo estiver a decorrer os 
jogadores decidem quem irá começar o jogo.

De seguida outro *if* irá verficar se algum dos jogadores não cumprem condições
para continuar a jogar, se ambos cumprirem, o programa irá entrar noutro ciclo
*while* onde é recebido o input. Verificamos se o input recebido é válido, 
se sim, pegamos na peça dada, na direção e passamos essa informação para o 
método setpeace da instância positions.

Dentro da classe Positions é onde as peças são movidas para a posição pedida, 
o método setpiece, irá interpretar a direção e dar informação á classe
checkmove e os diferentes métodos checkmove irão dizer se estes movimentos são
Dentro da classe CheckMove temos métodos checkmove(...) que recebem os *arrays*
*bw* e *wb* que variam de acordo com o turno; o *int* *i*, que indica onde está
a peça selecionada; o *int* *move*, que varia de acordo com a direção pedida, 
para estar ajustado á quantidade de casas necessárias para a peça cair na casa
certa, e recebe o *array* *boardpos*. Se a função checkmove(...) devolver 0 
informa o setpieces que a peça não se pode mexer nessa direção pois irá sobrepor
se a outra peça. Se a função checkmove devolver 1, a peça irá mexer-se 
normalmente. Se retornar 2 irá dar informação ao método setpieces que irá comer
uma peça nessa direção. Enquanto o checkmove faz essas validações vai chamando 
pelo método validation na mesma classe que guarda a validação do turno na
posição 1 do *validationArray*. Após ter feito isto o game chama o método 
validation que retorna o valor previamente guardado. Se a *validation* for 0,
a peça não se poderá mexer, se for 1 o movimento é permitido. 

Depois o resto do jogo será essencialmente repetir este ciclo até um dos
jogadores ganhar.

### Diagrama UML

## Referências

remover as peças do tabuleiro:
https://stackoverflow.com/questions/496896/how-to-delete-an-element-from-an-array-in-c-sharp

sair do programa:
https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/

verficar se o input é um int:
https://stackoverflow.com/questions/5395630/how-to-validate-user-input-for-whether-its-an-integer