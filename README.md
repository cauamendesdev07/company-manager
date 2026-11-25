# CompanyManager

Sistema de gerenciamento de pessoas, empresas e clientes, desenvolvido em **VB.NET** utilizando a plataforma **.NET**.

O projeto tem como objetivo desenvolver uma aplicação de forma incremental, aplicando conceitos de programação orientada a objetos, organização de código e boas práticas de desenvolvimento.

## Tecnologias

- VB.NET
- .NET
- Visual Studio

## Estrutura do Projeto

```text
CompanyManager/
├── src/
│   └── CompanyManager/
│       ├── Models/
│       │   ├── Pessoa.vb
│       │   ├── Empresa.vb
│       │   └── Cliente.vb
│       │
│       ├── Program.vb
│       └── CompanyManager.vbproj
│
├── .gitignore
└── README.md
```

## Funcionalidades

- [x] Representação de pessoas através da classe `Pessoa`.
- [x] Representação de empresas através da classe `Empresa`.
- [x] Representação de clientes através da classe `Cliente`, utilizando herança de `Pessoa`.
- [x] Instanciação e cadastro de pessoas, empresas e clientes.
- [x] Associação de empresas a seus respectivos clientes (1:N).
- [x] Gerenciamento da lista de clientes pela classe `Empresa`.
- [x] Consulta da lista de clientes através de `IReadOnlyList`, preservando o encapsulamento.
- [x] Geração automática de códigos sequenciais para clientes.
- [x] Controle de data de cadastro e situação (ativo/inativo) dos clientes.
- [x] Consulta de informações através de propriedades e métodos.

## Desenvolvimento

O projeto será desenvolvido gradualmente, incorporando novas funcionalidades e conceitos conforme sua evolução.

As implementações serão organizadas através de branches e issues, mantendo um histórico das funcionalidades desenvolvidas.

## Objetivos de Aprendizado

- Programação Orientada a Objetos (POO).
- Classes, objetos e construtores.
- Encapsulamento, herança e polimorfismo.
- Propriedades e modificadores de acesso.
- Coleções e interfaces de consulta.
- Relacionamentos entre objetos.
- Organização e arquitetura de software.
- Persistência de dados.
- Integração com banco de dados SQL Server.

---

**Status:** Em desenvolvimento.