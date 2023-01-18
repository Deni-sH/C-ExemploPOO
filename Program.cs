using ExemploPOO.Models;

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