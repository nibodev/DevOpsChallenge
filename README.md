<p align="center"><img src="https://www.nibo.com.br/logo-nibo.png" width="150" /></p>
<h1 align="center">Nibo DevOps Challenge - Level 1</h1>


<p align="center">Quer saber o por que vale a pena trabalhar no Nibo? <a href="https://tech.nibo.com.br">tech.nibo.com.br</a></p>

Olá!

Primeiramente, parabéns por ter avançado ao Desafio para DevOps do Nibo! 

## Quem somos
O Nibo nasceu em 2012 com uma missão muito clara: ajudar empresas a gerir suas finanças de forma simples e responsável. Ao longo dos anos, percebemos que a única forma de alcançar esse objetivo seria com a ajuda de uma figura bastante esquecida no imaginário brasileiro - **contador**.

Aqui no Nibo, não enxergamos o contador como o um "mal necessário", mas sim como **cientista da riqueza** - a pessoa com os poderes de ajudar seus clientes a prosperarem e alcançarem o sucesso. 

Traduzimos esse pensamento no nosso manifesto, que nunca deixamos de recitar: 
> Todos os dias, 2000 empresas morrem no Brasil. Empresários precisam de ajuda. Bons contadores são a solução.

Sendo assim, nosso papel é fornecer as ferramentas que aumentem a produtividade e efetividade do contador, de modo que ele tenha tempo para o que realmente importa: ser consultivo e entregar insights valiosos ao seu cliente.

A equipe de Produto e Tecnologia do Nibo é composta por times multifuncionais, com autonomia na tomada de decisão. São as famosas **squads**. Não sabe o que é squad? Assista ao vídeo [Spotify Engineering Culture](https://www.youtube.com/watch?v=hQDblYvY9RY). 


## O desafio

O desafio consiste em criar um ambiente de produção no Azure pronto para receber requisições. Você deverá criar o ambiente e subir a aplicação de acordo com as instruções. Este desafio será usado como base para discutirmos ferramentas, processos e cultura devOps. Não se trata de um teste objetivo, mas sim de um estudo de caso com o propósito de analisar os conhecimentos e experiências. 

Você deverá criar um fork deste repositório e utilizar o projeto contido na pasta `SRC` para completar o desafio.

### Requisitos:
- [ ] Criar uma conta gratuita no [Azure](https://azure.microsoft.com/pt-br/free/)
- [ ] Configurar o Azure para dois ambientes: Teste e Produção
- [ ] Configurar pipeline para integração e deploy contínuo usando o Github Actions ou [Azure DevOps](https://azure.microsoft.com/en-us/services/devops/)
    - Uma das etapas obrigatórias deve rodar os testes unitários
    - O deploy deve ser realizado automaticamente no ambiente de testes e no ambiente de produção, seguindo o [Github Flow](https://guides.github.com/introduction/flow/)
    - O deploy deverá ser feito na sua conta Azure nos ambientes que você criou
- [ ] Criar um arquivo chamado `howto.md` explicando o que e como foi feito, além das URLs e instruções de como verificar o resultado

### Atividades extras:
- [ ] Configurar um endpoint na aplicação para servir como Healthcheck e configurar este endpoint no Azure para geração de estatísticas de disponibilidade
- [ ] Colocar a aplicação em um Docker container


## Envio da solução
Você deverá criar um fork deste repositório, incluir os scripts `.yml` e enviar para recruta.tech@nibo.com.br o link do seu fork. Lembre-se de não versionar qualquer chave de acesso. Se for necessário, envie essas chaves junto com o e-mail.

Tenha capricho com o resultado final. Essa é a sua chance de entrar para o melhor time, na startup que mais cresce no Brasil.

**NIBO - Desenvolvimento de alta performance para geeks inquietos**

Boa sorte :D

