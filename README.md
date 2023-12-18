# 🚀 Decola Tech 4 - Dominando a Linguagem C#
www.dio.me

## 🌟 Desafio de projeto
Este é o meu primeiro desafio de projeto do Bootcamp Decola Tech 4, do módulo II, Dominando a Linguagem C#. Para este projeto, desenvolvi os requisitos solicitados e obrigatórios para o desafio, deixando em aberto aqui, por ser a versão 1.0. Pretendo, conforme avanço no conhecimento da linguagem, aprimorá-lo no futuro próximo.

## 💡 Contexto
Para esse primeiro desafio de projeto, foi preciso construir um sistema de estacionamento em linguagem C#.

## 📌 Proposta
A construção de uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

➡️ A classe contém sete variáveis, sendo:

1) **precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

2) **precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

3) **veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

4) **veiculo**: Tipo string. É o valor contendo o dado do veículo adicionado na lista de string 'veiculos'. Contém apenas a placa do veículo.

5) **placa**: Tipo string. É o valor contendo o dado do veículo a ser calculado o preço e o que indica qual veículo será removido do estacionamento.

6) **horas**: Tipo int. Armazena a quantidade de horas em que o veículo ficou estacionado.

7) **valorTotal**: Tipo decimal. É o valor a ser pago pelo usuário, ao remover o carro.

➡️ A classe contém três métodos, sendo:

1) **AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

2) **RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

3) **ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar programa
