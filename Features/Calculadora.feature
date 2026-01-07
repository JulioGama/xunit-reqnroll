#language: en-us
Feature: Calculadora
    Simples calculadora para efetuar operações básicas

Scenario Outline: Calcular dois números
    Given que eu entrei o número <num1> na calculadora
    And que eu entrei o número <num2> na calculadora
    When eu pressionar o botão de <operacao>
    Then o resultado deve ser <resultado>

Examples:
    | num1 | num2 | operacao   | resultado |
    | 50   | 70   | somar      | 120       |
    | 10   | 5    | subtrair   | 5         |
    | 3    | 10   | multiplicar| 30        |