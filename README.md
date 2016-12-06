# Nibo DevOps Challenge

Bem vindo, recruta. Precisamos saber se você está apto a trabalhar conosco. São dois os objetivos deste desafio:

Vamos testar o quanto você conhece dos assuntos básicos que faz parte do dia-a-dia de um DevOps. Precisamos de alguém com cohecimentos gerais em C# .NET, GIT, CD, CI e Infra. A palavra "automatização" é a chave para seu sucesso.

Também vamos testar o seu potencial de aprendizado. Provavelmente você precisará pesquisar bastante para chegar a um bom resultado. 

### Você irá precisar de:

+ Máquina Windows
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

## Fourth step: CD

O último passo é colocar o WebApp configurado para o deploy contínuo. Na prática o que deverá ocorrer é o seguinte: ao realizar um commit no seu repositório do Github, o Azure deverá pegar as alterações e publicar automaticamente no WebApp.  Moleza ;)

## Finally

Ao finalizar o desafio, você deverá enviar para o email dev@nibo.com.br as seguintes informações:

+ A URL do repositório no Github
+ O script de deploy criado no passo 3
+ A URL do projeto publicado no Azure

Se você possuir qualquer dúvida em alguma parte do processo, mande um email para dev@nibo.com.br que iremos te responder. Ou entre em contato conosco via chat acessando: www.nibo.com.br

**Boa sorte.**
