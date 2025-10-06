# 1. Conceitos fundamentais

## Encapsulamento:
Ele é parte da programação Orientada a Objeto que foca em proteger os dados da classe e permitindo  que so possam ser alterados ou acessados através de métodos controlados.

protected strig nome;

private int saldo;

public int ExibirSaldo(){}


## Herança:
E o noma dado quando uma classe herda as propriedades e métodos de outra classe.

internal calss Carro : Veiculo

## Polimorfismo:
E quando um método, herdado por uma classe filha, pode ter sua forma alterada. Dessa forma falamos que o polimorfismo permite que o metodo possui varias formas.

public override void Acelerar(){}

## Abstração:
Permite simplificar a implementação, ocultando os detalhes e apenas nos mostrando o que é essencial de uma classe.

abstract class Veiculo{}
