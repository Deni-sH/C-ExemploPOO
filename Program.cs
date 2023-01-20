using ExemploPOO.Models;
using ExemploPOO.Interfaces;


/* Ex:

Qual a função de uma classe selada?
r: É uma classe que não pode possuir classes filhas, ou seja, ninguém pode derivar dela.

"A classe System.Object é a mãe de todas as classes no C#, e ela tem como objetivo:
r: Prover serviços de baixo nível para suas classes filhas, como métodos de referências, 
comparação, finalização e representação de objetos.

Qual a função de uma classe abstrata?
r: Uma classe que serve apenas como modelo e que não pode ser instanciada;

Uma interface tem como por objetivo:
r: Estabelescer uma espécie de contrato,que ao ser usado por uma classe, é necessário a implementação de seus métodos previstos na interface.















/* Ex. Métodos que não tem corpo é obrigatório a implementação, já métodos com corpo não é.


namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
       
            public int Dividir(int num1, int num2)
        {
            return num1 / num2;                         <<<---- na interface
        
        }
    }
}

Na classe >

public class Calculadora : ICalculadora  //OBS: Clica na classe que da erro, ou quer implementar a interface. ou "CRTL + ."
    {
                                                                    <---------Método Dividir pôde ser deletado sem dar quebra de código.
        public int Multiplicar(int num1, int num2)                                  Se tornando opcional a impementação 
        {
        return num1 * num2;        }

        public int Subtrair(int num1, int num2)
        {
        return num1 - num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
        return num1 + num2 + num3;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
    }





/*
//já implementando interface ele funciona:

ICalculadora calc = new Calculadora();

Console.WriteLine(calc.Multiplicar(3, 9));




/*
ICalculadora calc = new ICalculadora(); //erro pois interface nao é instanciada

//interface nao é instanciada


/* Interfaces: 
É um contrato que pode ser implementado por uma classe.
É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementador.

Assim como ma classe abstrata, uma interface não pode ser instanciada.

Ex. Interface ICalculadora 
com métodos calcular e subtrair

filhas -

Calculadora comum                                            Calculadora cientifica

Ambas tem que implementar a interface calculadora -> e implementar os métodos calcular e subtrair <-----


Quando se fala de Classes se diz implementar e não herdar.


//OBS: Clica na classe que da erro, ou quer implementar a interface. ou "CRTL + ."

//Calculadora usa a interface da ICalculadora, portanto não herda ela implementa.

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);
    }
}

Calculadora implementa ICalculadora. Ao implementar ele implementa todos os métodos presentes em ICalculadora 

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora  //OBS: Clica na classe que da erro, ou quer implementar a interface. ou "CRTL + ."
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
        return num1 * num2;        }

        public int Subtrair(int num1, int num2)
        {
        return num1 - num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
        return num1 + num2 + num3;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}







//Object = Computador.cs

/* Classe System.Object é como se fosse o topo da hierarquia de todas as suas classes e objetos presentes na linguagem c sharp
Todas as classes derivam, direta e indiretamente da classe Object e ela tem como objetivo prover serviços de baixo nível para 
suas classes filhas.

Quando se cria uma classe ela ja herda automaticamente sem implementar a classe Object. acesso automático a todos esses métodos.

*/
/*

Computador c = new Computador();
Console.WriteLine(c.ToString());





/* método selado 
ou seja: então em resumo: vc usa a palavra sealed pra quando vc quer colocar um ponto final.
Se vc usar na classe significa que Professor não pode ter nenhuma classe filha e
se voce colocar no método significa que as classes filhas não podem sobrescrever esse método
vai ter que usar esse mesmo fornecido pela classe pai.






 public class Professor : Pessoa

public sealed override void Apresentar()    <--- selado, ou seja a classe diretor não pode usa-lá
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade}. Sou professor e ganho {Salario}.");
        }


namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine("Diretor");
        }
    }
}




/* Classe selada: = Classe Professor Sealed
Ao contrário de uma classe abstrata, vc diz para ela que nenhuma classe pode sofrer uma herança dessa classe 

ou seja: Classes seladas não podem ter classes filhas e métodos selados não podem ser sobre-escritos

namespace ExemploPOO.Models 

abaixo classe selada.
{
    public sealed class Professor : Pessoa
    {

        classe final, não pode ter filhos.








/*
herança abstrata = Pessoa.cs public Pessoa(string nome)
        {
            Nome = nome;
        }

e colocar nas classes filhas: Aluno e Professor o seguinte:


namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)   <------------------------
        {
            
        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos. Sou um bon aluno ");
        }
    }
}

--------------------> fazer o mesmo no código quebrado da classe Professor:

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade}. Sou professor e ganho {Salario}.");
        }
    }
}

--------------------------------------------------------------




Corrente c = new Corrente();

c.Creditar(500);
c.ExibirSaldo();






/* Abstract = Conta.cs 
modelo pra se herdar
Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada.
voce pode implementar métodos ou deixa-los a cargo de quem herdar.






/*
Em POO, herança tem o objetivo de:
r: Reutilizar atributos, métodos e comprotamento de uma classe em outras classes.

Temos dois tipos de polimorfismo: o polimorfismo em tempo de execução e de compilação. O tipo de 
polimorfismo que usa herança e sobrescreve um método da classe pai, é conhecido como:
r: polimorfismo de execução.

Temos dois tipos de polimorfismo: o polimorfismo em tempo de execução e de compilação. 
O tipo de polimorfismo que NÃO usa herança e usa métodos com o mesmo nome, 
porém com parâmetros diferentes, é conhecido como:
r: Polimorfismo em tempo de compilação.

Em POO, polimorfismo tem o objetivo de:
r:Sobreescrever os métodos de sua classe derivada, permitindo implementarmos classes especializadas.






/*Polimorfismo Overload/Early Binding = polimorfismo de compilação 

Obs: Se passar 2 numeros cai no método 1 e se colocar 3 números cai na situação número2
public Class Calculadora
{
    public int Somar(int num1, int num2)                 =1
    {
        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)       =2
    {
        return num1 + num2 + num3;
    }
}





/*
polimorfismo: muitas formas, vai se comportar d euma maneira diferente dependendo da classe que ele estiver.
classe pessoa colocar "virtual" significa que esse método pode ser sobreescrito se assim a classe filha desejar.
public override void Apresentar() 





//polimorfismo override/late binding = polimorfismo de execução.
 Aluno a1 = new Aluno();

 a1.Nome = "Pietro";
 a1.Idade = 20;
 a1.Nota = 10;
 a1.Email = "text@text.com";

a1.Apresentar();

Professor p1 = new Professor();

p1.Nome = "jeferson";
p1.Idade = 27;
p1.Salario = 835;
p1.Email = "jef@hotmail.com";

p1.Apresentar();













//Herança Models.Aluno  - Aluno : Pessoa
// No c# uma herança de cada vez, existem outras linguagens que permitem mais de um.
// Aluno a1 = new Aluno();

// a1.Nome = "Pietro";
// a1.Idade = 20;
// a1.Nota = 10;
// a1.Email = "text@text.com";


// a1.Apresentar();









/*
EX:

Em POO, o encapsulamento tem o objetivo de:
r: Proteger a implementação de uma classe, prevenindo acesso indevido e expondo somente o necessário.

O que é um paradigma de programação?
r: É um modelo de técnicas, estruturas e formas de solucionar um problema.

Em POO, abstração tem o objetivo de:
r: Abstrair conceitos do mundo real, considerando seus atributos mais relevantes ao contexto.

Quais são os quatro pilares da programação orientada a objetos?
r: Abstração, encapsulamento, herança e polimorfismo












//private mantém oculto; bloqueado para alterações externas ex:conta corrente

ContaCorrente c1 = new ContaCorrente(123, 200);

c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();





/* Encapsulamento:

Serve para proteger uma classe e definir limites para alteração de suas propriedades.
Serve para ocultar seu comportamento e expor somente o necessário.


/*

// criando um objeto p1. chamando uma classe p1 do tipo Pessoa
//p1 um objeto do tipo Pessoa
Pessoa p1 = new Pessoa();

p1.Nome = "Carlinhos";
p1.Idade = 18;
p1.Apresentar();

/*Ou seja: Classe é um molde do que vc deseja representar e o objeto em si
é a concretização do que vc quer representar, com todas as suas características.

*/