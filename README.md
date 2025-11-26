# 📦 HelpBox - Sistema de Gerenciamento de Chamados (Desktop)

![Status do Projeto](https://img.shields.io/badge/Status-Finalizado-green) ![.NET](https://img.shields.io/badge/.NET-8.0-purple) ![C#](https://img.shields.io/badge/Language-C%23-blue)

Bem-vindo ao repositório Desktop do **HelpBox** 
Este aplicativo foi desenvolvido para atender às necessidades dos técnicos de suporte, oferecendo uma interface robusta e ágil para o gerenciamento e solução de chamados de TI.

---

## 📋 Sobre o Projeto

O **HelpBox Desktop** é a interface administrativa utilizada pela equipe técnica para visualizar, assumir e solucionar problemas relatados pelos clientes. O sistema foi projetado com foco em segurança, escalabilidade e uma experiência de usuário fluida.

O projeto segue a arquitetura em **3 Camadas (Negócios, Dados e Modelo)**, garantindo organização e facilidade de manutenção.

---

## 🚀 Funcionalidades Principais

### 🔐 Autenticação e Segurança
* **Login Seguro:** Validação de credenciais com verificação de hash **BCrypt** (compatível com a versão Web).
* **Controle de Acesso:** O sistema verifica se o usuário possui permissões de técnico antes de liberar o acesso.
* **Mascaramento de Senha:** Proteção visual dos campos de senha.

### 💻 Dashboard e Navegação
* **Menu Lateral Retrátil:** Navegação intuitiva com animação suave para maximizar a área de trabalho.
* **Perfil do Técnico:** Exibição dinâmica do nome e e-mail do usuário logado.

### 🎫 Gerenciamento de Chamados
* **Listagem Inteligente:** Visualização clara dos chamados "Em andamento".
* **Atribuição de Responsabilidade:** Técnicos podem assumir chamados livres com um clique.
* **Resolução:** Interface dedicada para leitura do problema, análise da IA e registro da solução técnica.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (Windows Forms)
* **Framework:** .NET 8.0 (Windows Desktop)
* **Banco de Dados:** SQL Server (Local / Azure)
* **Acesso a Dados:** SqlClient
* **Segurança:** BCrypt.Net-Next
* **Testes Unitários:** xUnit

---

## 🏗️ Arquitetura do Projeto

O sistema é dividido em três camadas lógicas para garantir a separação de responsabilidades:

1.  **Model:** Representação dos objetos como Usuario e Chamado.
2.  **DAL (Data Access Layer):** Responsável por toda a comunicação com o SQL Server, execução de queries e mapeamento de dados.
3.  **BLL (Business Logic Layer):** O "cérebro" do sistema. Contém as regras de negócio, validações e orquestra o fluxo entre a UI e a DAL.

---

## ✅ Testes Unitários

A qualidade do código é garantida através de uma suíte de testes unitários automatizados localizada no projeto ''HelpBox.Tests''.

---

## ⚙️ Configuração e Instalação

1.  **Clone o repositório:**
    ```bash
    https://github.com/helpbox2025/Desktop.git
    ```
2.  **Configure o Banco de Dados:**
    * Certifique-se de ter o SQL Server instalado.
    * Ajuste a connectionString no arquivo `App.config` para apontar para o seu servidor.
      
3.  **Execute o Projeto:**
    * Abra o HelpBox.sln no Visual Studio 2022.
    * Compile a solução (Build).
    * Pressione F5 para iniciar.

---


---

<div align="center">
  <sub>Desenvolvido por <b>HelpBox tecnologia</b>. 💡</sub>
</div>
