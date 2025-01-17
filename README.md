# 🚀 Decola Tech 2024 - Dominando a linguagem C#
www.dio.me

## 🌟 Desafio de projeto I - Construindo um sistema para estacionamento com C#
Este é o primeiro desafio de projeto do Bootcamp Decola Tech 2024, módulo II - Dominando a Linguagem C#. Para este projeto, desenvolvi os requisitos solicitados e obrigatórios para o desafio, começando aqui pela versão 1.0, pois pretendo, conforme avanço no conhecimento da linguagem, aprimorá-lo.

## ❓ Contexto
Para esse primeiro desafio de projeto, foi preciso construir um sistema de estacionamento em linguagem C#.

## 📌 Proposta
A construção de uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

➡️ A classe contém os atributos abaixo, sendo:

1) **precoInicial**: Inicializado em 0, tipo decimal.
  
2) **precoPorHora**: Inicializado em 0, também de tipo decimal. 

3) **veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.
   
   

➡️ A classe contém três métodos, sendo:

1) **AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

2) **RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

3) **ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".


➡️ O sistema de estacionamento possui as seguintes variáveis:

1) **precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

2) **precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.
   
3) **veiculo**: Tipo string. É o valor contendo o dado do veículo adicionado na lista de string 'veiculos'. Contém apenas a placa do veículo.

4) **placa**: Tipo string. É o valor contendo o dado do veículo a ser calculado o preço e o que indica qual veículo será removido do estacionamento.

5) **horas**: Tipo inteiro. Armazena a quantidade de horas em que o veículo ficou estacionado.

6) **valorTotal**: Tipo decimal. É o valor a ser pago pelo usuário, ao remover o carro.

   
_______________________________________________________________

### 💻 Saída no console:

a. Primeira entrada
 
![image](https://github.com/tainasays/decolaTech4-desafio-projeto1/assets/102188509/5f52c0c1-766a-43ae-816e-fa9f9678b502)

b. Menu interativo
 
![image](https://github.com/tainasays/decolaTech4-desafio-projeto1/assets/102188509/84abbc00-721a-46dc-857e-ebc5c185047e)

c. Cadastro de veículo

![image](https://github.com/tainasays/decolaTech4-desafio-projeto1/assets/102188509/adb19240-42e8-4bbd-b8a1-87fcde6c03a3)

d. Listar veículo

![image](https://github.com/tainasays/decolaTech4-desafio-projeto1/assets/102188509/fe3bc785-ff32-4579-9cef-92fbd2b562e3)

e. Remover veículo + valor a ser pago

![image](https://github.com/tainasays/decolaTech4-desafio-projeto1/assets/102188509/a9f33001-083b-4b33-a767-2a4c9cab2548)
 
f. Encerrar programa

![image](https://github.com/tainasays/decolaTech4-desafio-projeto1/assets/102188509/6d501715-4f99-466e-a3a7-5f4b8df017b3)


### ⚙️ Código

* [Classe Estacionamento.cs](https://github.com/tainasays/decolaTech4-desafio-projeto1/blob/main/DesafioFundamentos/Models/Estacionamento.cs)
  
* [Program.cs](https://github.com/tainasays/decolaTech4-desafio-projeto1/blob/main/DesafioFundamentos/Program.cs)

