# Projeto ASP.NET

# BR
Aplicação WEB Produzida com ASP.NET. Esta aplicação tem como objetivo abstrair os conhecimentos obtidos durante o curso de ASP Net. A aplicação trata-se de uma agenda para salvar contatos, possuindo o número, nome e status ativo ou inativo do número cadastrado. Ele consegue efetuar todas as quatro operações de CRUD. 

Este projeto utilizou-se de HTML5, CSS3, JavaScript, C# (ASP.NET) e Entity Framework (para gerenciar banco de dados), além de banco de dados SQLServer.

A estrutura dos dados encontra-se da seguinte forma: 

```
Contato:
{
    Id: int,
    Nome: string,
    Numero: string,
    Ativo: bool,
};
```
Na aba Contatos Salvos é possível verificar todos os contatos atualmente disponíveis, assim como adicionar um novo contato se assim desejar. No momento, o programa utiliza uma base de dados local do SQLServer.
