1. README.md para o projeto StockApp
# 📦 StockApp – Sistema de Controle de Estoque (C#)

Aplicação de console simples para gerenciamento de produtos em estoque. Permite cadastrar, listar, atualizar e remover produtos, com persistência dos dados em um arquivo `.txt`.

## ✅ Funcionalidades

- Adicionar produtos com nome, quantidade e preço
- Listar todos os produtos com total por item
- Atualizar a quantidade de um produto
- Remover produtos do estoque
- Salvar automaticamente em arquivo (`produtos.txt`)
- Carrega os dados ao iniciar o programa

## 💻 Tecnologias

- C# (.NET)
- Programação orientada a objetos
- Manipulação de arquivos (`System.IO`)
- Console Application

## ▶️ Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/KarinaNicoleti/stockapp.git
   cd stockapp


Compile e execute:

dotnet run


O arquivo produtos.txt será criado automaticamente.

📁 Estrutura do Projeto
/stockapp
│
├── Programa.cs       # Código principal
├── Produto.cs        # Classe Produto
├── produtos.txt      # Arquivo de dados (gerado em tempo de execução)
└── .gitignore

🚀 Melhorias futuras

Buscar produto por nome

Mostrar o valor total do estoque

Adicionar interface gráfica (WinForms/WPF)

🧑‍💻 Autora

Feito por Karina Nicoleti ✨
github.com/KarinaNicoleti

