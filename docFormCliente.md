# 🖧 ChatServer - Servidor de Chat TCP em C#

Este é o servidor de um sistema de chat em C#, usando `TCP/IP` para comunicação em rede local. O servidor gerencia conexões de múltiplos clientes, controla a troca de mensagens e mantém uma estrutura simples e eficiente para comunicação em tempo real.

## ⚙️ Funcionalidades

- Gerencia múltiplos usuários conectados.
- Envia mensagens de um cliente para todos os outros (broadcast).
- Envia mensagens administrativas para todos os usuários.
- Notifica o status de entrada/saída de usuários.
- Usa `Hashtable` para mapear conexões e nomes de usuários.
- Usa `Thread` para tratar múltiplas conexões simultaneamente.

## 📁 Estrutura do Projeto

### Classe `Servidor`

- Inicializa o listener (`TcpListener`) e aceita conexões.
- Usa `Thread` para lidar com as conexões em paralelo.
- Mantém um registro de todos os usuários conectados.
- Dispara eventos de status via `StatusChangedEventHandler`.

### Classe `Conexao` (mencionada, mas não incluída aqui)

- Responsável por receber e processar as mensagens de cada cliente.
- Chama os métodos do `Servidor` para enviar mensagens ou remover usuários.

## 📌 Requisitos

- .NET Framework ou .NET Core compatível com `System.Net.Sockets`.
- Ambiente Windows Forms (o projeto cliente usa WinForms para a interface).
- Conhecimento básico de redes e sockets TCP/IP.

## 🚀 Como Usar

1. Compile e execute o projeto do **Servidor**.
2. Ele iniciará e ficará escutando conexões na porta e IP configurados.
3. Clientes poderão se conectar ao servidor para iniciar o chat.

## 🧠 Tecnologias Utilizadas

- C#
- .NET Framework
- TCP/IP com `System.Net.Sockets`
- Threads com `System.Threading`
- WinForms (no projeto cliente)

## 📚 Importações Principais

- `System.Net`, `System.Net.Sockets` — para comunicação via sockets.
- `System.Collections` — para `Hashtable` de conexões e usuários.
- `System.IO` — para leitura e escrita das mensagens.
- `System.Threading` — para lidar com múltiplas conexões em paralelo.

## 💡 Observações

- O número de usuários é limitado a 30 (`Hashtable(30)`).
- A classe `StatusChangedEventArgs` é usada para encapsular mensagens administrativas.
- A responsabilidade de manter o servidor rodando e aceitar conexões está separada da lógica de mensagens por usuário (`Conexao`).

## 🛠️ Extensões Futuras

- Implementar autenticação de usuários.
- Log de mensagens no servidor.
- Adicionar criptografia na comunicação.
- Interface gráfica para o servidor.

---

🧑‍💻 Desenvolvido por: Matheus  
📅 Última atualização: Maio de 2025
