# 4. Sobrecarga e sobrescrita 


## Sobrecarga:
Quando usamos o mesmo nome para um método porém mudamos os argumentos passados para ele, assim fazendo com que ele seja capaz de realizar vários tipos de função sem termos que chamar vários métodos

### Exemplo:
internal class calculadora
{
	public int soma(int x, int y)
	{
		return x + y;
	}

	public double soma(double x, double y)
	{
		return x + y
	}
}


## Sobrescrita:
Quando dentro de uma classe filha chamamos um método com o mesmo nome da classe mãe porém redefinimos seu retorno para que ele nos entregue algo mais especifico para nossas necessidades

### Exemplo:
abstract class Veiculo
{
	public virtual void Acelerar()
        {
            Console.WriteLine($"O veículo {this.GetType().Name} está acelerando.");
        }
}

internal class Carro : Veiculo
{
	public override void Acelerar()
        {
            Console.WriteLine($"O carro de marca: {marca} e de modelo: {modelo} está acelerando.");
        }
}
