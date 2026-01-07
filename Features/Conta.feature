#language: en-us
Feature: Gestão de Conta

Scenario Outline: Movimentações variadas na conta
    Given que eu tenho uma conta com saldo de <saldo_inicial>
    When eu <operacao> o valor de <valor>
    Then o saldo da conta deve ser <saldo_final>

Examples:
    | saldo_inicial | operacao  | valor  | saldo_final |
    | 100           | depositar | 50     | 150         |
    | 500           | sacar     | 100    | 400         |
    | 200           | sacar     | 250    | 200         |
    | 0             | depositar | 1000   | 1000        |