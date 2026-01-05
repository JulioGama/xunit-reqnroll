#language: pt-br
Funcionalidade: Calculadora
    Simples calculadora para efetuar operações básicas

Esquema do Cenário: Calcular dois números
    Dado que eu entrei o número <num1> na calculadora
    E que eu entrei o número <num2> na calculadora
    Quando eu pressionar o botão de <operacao>
    Então o resultado deve ser <resultado>

Exemplos:
    | num1 | num2 | operacao   | resultado |
    | 50   | 70   | somar      | 120       |
    | 10   | 5    | subtrair   | 5         |
    | 3    | 10   | multiplicar| 30        |