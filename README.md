# **Documentação do Projeto DeveloperStore**

Este projeto é uma API para gerenciamento de vendas, desenvolvida seguindo os princípios de **Domain-Driven Design (DDD)**. Ele inclui funcionalidades de CRUD para vendas, aplicação de regras de negócio para descontos e integração com um banco de dados PostgreSQL.

---

## **Funcionalidades Principais**

1. **CRUD de Vendas**:
   - Criação de vendas com número da venda, data, cliente, filial, produtos, quantidades, preços unitários e descontos.
   - Consulta de vendas por ID.
   - Atualização de vendas.
   - Cancelamento de vendas.

2. **Regras de Negócio**:
   - Descontos baseados na quantidade de itens:
     - 4+ itens: 10% de desconto.
     - 10-20 itens: 20% de desconto.
   - Limite máximo de 20 itens por produto.
   - Sem desconto para quantidades abaixo de 4 itens.

3. **Eventos de Domínio**:
   - Log de eventos como `SaleCreated`, `SaleModified`, `SaleCancelled` e `ItemCancelled`.

4. **Banco de Dados**:
   - Utiliza PostgreSQL para persistência de dados.
   - Migrações configuradas para criação automática do esquema do banco de dados.

---

## **Tecnologias Utilizadas**

- **Linguagem**: C#
- **Framework**: .NET 6
- **Banco de Dados**: PostgreSQL
- **ORM**: Entity Framework Core
- **Padrão de Arquitetura**: Domain-Driven Design (DDD)
- **Ferramentas**:
  - Visual Studio ou Visual Studio Code
  - Docker (opcional, para rodar o PostgreSQL)
  - Postman (para testar a API)

---

## **Pré-requisitos**

Antes de executar o projeto, certifique-se de ter instalado:

1. **.NET 6 SDK**: [Download .NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)
2. **PostgreSQL**: [Download PostgreSQL](https://www.postgresql.org/download/) ou use Docker (recomendado).
3. **Visual Studio ou Visual Studio Code**: [Download Visual Studio](https://visualstudio.microsoft.com/) ou [Download VS Code](https://code.visualstudio.com/).
4. **Docker (opcional)**: [Download Docker](https://www.docker.com/get-started).

---

## **Passo a Passo para Executar o Projeto**

### 1. **Clonar o Repositório**

Clone o repositório do projeto para sua máquina local:

```bash
git clone https://github.com/seu-usuario/DeveloperStore.git
cd DeveloperStore
```

### 2. Configurar o Banco de Dados

# Opção 1: Usando Docker (Recomendado)

Crie um container PostgreSQL com Docker:
```bash
docker run --name developerstore-db -e POSTGRES_USER=postgres -e POSTGRES_PASSWORD=senha123 -e POSTGRES_DB=DeveloperStore -p 5432:5432 -d postgres
```

Verifique se o container está rodando:
```bash
docker ps
```

# Opção 2: Usando PostgreSQL Local
Crie um banco de dados chamado DeveloperStore no PostgreSQL.

Anote as credenciais de acesso (usuário, senha, host e porta).

### 3. Configurar a Connection String
No arquivo appsettings.json do projeto Ambev.DeveloperEvaluation.WebApi, atualize a connection string com as credenciais do seu banco de dados:

```json
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Database=DeveloperStore;Username=postgres;Password=senha123"
}
```

### 4. Executar as Migrações

No terminal, navegue até a pasta do projeto Ambev.DeveloperEvaluation.ORM e execute as migrações para criar o esquema do banco de dados:

```bash
dotnet ef database update
```

### 5. Executar o Projeto

No terminal, navegue até a pasta do projeto Ambev.DeveloperEvaluation.WebApi e execute o projeto:

```bash
dotnet run
```

A API estará disponível em: http://localhost:5000 ou https://localhost:5001.

### Testando a API
# Você pode testar a API usando o Postman ou o arquivo Ambev.DeveloperEvaluation.WebApi.http (disponível no projeto).

Exemplo de Requisições
Criar uma Venda
Endpoint: POST /api/sales

Body:

``` json
{
  "saleNumber": "V001",
  "customerId": 1,
  "branchId": 1,
  "items": [
    {
      "productId": 1,
      "quantity": 5,
      "unitPrice": 10.00
    },
    {
      "productId": 2,
      "quantity": 15,
      "unitPrice": 20.00
    }
  ]
}
```

Resposta:

```json
{
  "id": 1,
  "saleNumber": "V001",
  "saleDate": "2023-10-15T12:00:00Z",
  "totalAmount": 320.00,
  "isCancelled": false
}
```
Consultar uma Venda por ID
Endpoint: GET /api/sales/{id}

Resposta:

```json
{
  "id": 1,
  "saleNumber": "V001",
  "saleDate": "2023-10-15T12:00:00Z",
  "customerId": 1,
  "branchId": 1,
  "totalAmount": 320.00,
  "isCancelled": false,
  "items": [
    {
      "productId": 1,
      "quantity": 5,
      "unitPrice": 10.00,
      "discount": 0.10,
      "totalAmount": 45.00
    },
    {
      "productId": 2,
      "quantity": 15,
      "unitPrice": 20.00,
      "discount": 0.20,
      "totalAmount": 240.00
    }
  ]
}
```

Cancelar uma Venda
Endpoint: DELETE /api/sales/{id}

Resposta: Status 204 No Content.

---

### Estrutura do Projeto
# Camadas
Domain:
Contém as entidades, enums, validações e regras de negócio.
Exemplo: Sale, Customer, Product, Branch.

Application:
Implementa os casos de uso (commands e queries).
Exemplo: CreateSaleCommand, GetSaleByIdQuery.

Infrastructure:
Implementa a persistência de dados (repositórios e ORM).
Exemplo: SaleRepository, DefaultContext.

WebApi:
Expõe os endpoints da API.
Configuração do middleware, injeção de dependências e logging.

Repositórios e Interfaces
Repositórios: Implementam a persistência de dados.
Exemplo: SaleRepository, CustomerRepository.

Interfaces: Definidas na camada de domínio para abstrair a persistência.
Exemplo: ISaleRepository, ICustomerRepository.

---

### Considerações Finais
Este projeto foi desenvolvido seguindo boas práticas de arquitetura e design, com foco em:

Escalabilidade: Facilidade para adicionar novas funcionalidades.
Manutenibilidade: Código limpo e bem organizado.
Testabilidade: Separação clara de responsabilidades.
Para qualquer dúvida ou sugestão, sinta-se à vontade para entrar em contato!

---
