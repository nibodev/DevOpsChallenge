<p align="center"><img src="https://www.nibo.com.br/logo-nibo.png" width="150" /></p>
<h1 align="center">Nibo Full-Stack DevOps Challenge - Level 1</h1>


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

Vamos testar o quanto você conhece dos assuntos básicos que faz parte do dia-a-dia de um DevOps. Precisamos de alguém com cohecimentos gerais em C# .NET, GIT, CD, CI e Ambiente Cloud. A palavra "automatização" é a chave para seu sucesso.

Também vamos testar o seu potencial de aprendizado. Provavelmente você precisará pesquisar bastante para chegar a um bom resultado. 

### Você irá precisar de:

+ Visual Studio [download](https://www.visualstudio.com/pt-br/downloads/)
+ Conta no Azure [crie aqui](https://azure.microsoft.com/pt-br/free/)
+ Conta no Github [crie aqui](https://github.com/join?source=header-home)
+ Git CLI [download](https://git-scm.com/downloads)
+ Azure CLI (opcional) [download](https://docs.microsoft.com/en-us/azure/xplat-cli-install)

Todas as contas podem ser criadas e os pacotes baixados gratuitamente.

Você também poderá instalar o Git CLI e Azure CLI via NPM:

`npm install -g git-cli` `npm install -g azure-cli`

## First step: build the project

A sua primeira missão é muito simples: fazer o projeto rodar. Para isso você precisará seguir os seguintes passos:

1. Clone este projeto do Github em sua máquina
2. Abra no Visual Studio, tente "buildar"

Vish... Deu algum problema? Então... faça funcionar.

## Second step: Versioning and manual deployment

A sua segunda missão é versionar o projeto corrigido e colocá-lo no ar.

1. Versione o projeto com a sua correção em um repositório novo em sua conta Github
2. Crie um WebApp no Azure com um nome qualquer
3. Faça o deploy do projeto neste novo WebApp.
4. Verifique se o projeto está no ar

Não se esqueça de versionar tudo, incluindo este Readme.md e o .gitignore.
Você poderá fazer o deploy da maneira que mais achar conveniente. Porém dê preferência ao deploy via linha de comando utilizando o Powershell ou o Azure CLI. Isto facilitará o próximo passo.

## Third step: Deployment script

Nesta missão você deverá criar um script para automatizar todo o processo da segunda etapa. Este script poderá ser um `.bat`, contendo as instruções usando `git-cli` e `azure-cli` ou um `.ps1`, com todas as instruções a serem executadas no Powershell.

O seu supervisor irá executar este script de uma máquina Windows (já com git ou outras dependências instaladas). Então não há problema caso o seu script exija a digitação de informações como login ou outros dados que achar necessário. 

Resumindo, o seu script deverá se encarregar de:

1. Pedir autenticação no Azure
2. Criar um novo WebApp no Azure, com um nome qualquer
3. Publicar o projeto que está versionado no Github neste novo WebApp

## Deploy contínuo

Nesta simples e última etapa você deverá configurar o Deploy Contínuo para este seu fork. Desta forma, qualquer alteração realizada neste projeto, um processo de build e de deploy deverá ser iniciado, possibilitando assim a visualização das alterações no Web App do Azure criado por você.

## Envio da solução
Você deverá criar um fork deste repositório, incluir o seu script na pasta ``SCRIPTS``,  preencher o formulário "_about/Profile.md" e enviar para recruta.tech@nibo.com.br o link do seu fork.

Tenha capricho com o resultado final. Essa é a sua chance de entrar para o melhor time, na startup que mais cresce no Brasil.

**NIBO - Desenvolvimento de alta performance para geeks inquietos**

Boa sorte :D

