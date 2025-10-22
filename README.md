# 📦 StockApp – Sistema de Controle de Estoque (C#)

Aplicação de console simples para gerenciamento de produtos em estoque.  
Permite cadastrar, listar, atualizar e remover produtos, com **persistência de dados** em um arquivo `.txt`.

---

## ✅ Funcionalidades

- Produtos com nome, quantidade e preço
- Adicionar novos produtos
- Listar todos os produtos com total por item
- Atualizar a quantidade de um produto
- Remover produtos do estoque
- **Salvar automaticamente** no arquivo `produtos.txt`
- **Carregar os dados** ao iniciar o programa

---

## 💻 Tecnologias

- C# (.NET)
- Programação orientada a objetos
- Manipulação de arquivos (`System.IO`)
- Aplicativo de console

---

## ▶️ Como executar

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/KarinaNicoleti/stockapp.git
   cd stockapp


Compile e execute:

dotnet run


O arquivo produtos.txt será criado automaticamente ao rodar o projeto.

📁 Estrutura do Projeto
/stockapp
│
├── Programa.cs       # Código principal do sistema
├── Produto.cs        # Classe que representa um produto
├── produtos.txt      # Arquivo de dados gerado automaticamente
└── .gitignore        # Arquivos/pastas ignorados pelo Git

🚀 Melhorias futuras

Buscar produtos por nome

Mostrar o valor total do estoque

Adicionar interface gráfica (WinForms ou WPF)

Exportar lista de produtos para CSV

🧑‍💻 Autora

Feito com 💙 por Karina Nicoleti
🔗 github.com/KarinaNicoleti
