#language: pt-br
Funcionalidade: Gestão de Conta

Esquema do Cenário: Movimentações variadas na conta
    Dado que eu tenho uma conta com saldo de <saldo_inicial>
    Quando eu <operacao> o valor de <valor>
    Então o saldo da conta deve ser <saldo_final>

Exemplos:
    | saldo_inicial | operacao  | valor  | saldo_final |
    | 100           | depositar | 50     | 150         |
    | 500           | sacar     | 100    | 400         |
    | 200           | sacar     | 250    | 200         |
    | 0             | depositar | 1000   | 1000        |