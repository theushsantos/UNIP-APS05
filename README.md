# Chat TCP/IP em C#

## 📌 Descrição
Aplicativo de chat baseado em arquitetura cliente-servidor usando **C# e Windows Forms**, com comunicação via **sockets TCP/IP**. Permite múltiplos usuários trocarem mensagens em tempo real em uma rede local.

## ⚙️ Tecnologias
- C#
- Windows Forms
- TCP/IP (System.Net.Sockets)
- Multithreading
- .NET Framework 4.x

## 🧠 Funcionamento

### Servidor
- Usa `TcpListener` para escutar conexões.
- Cada conexão é tratada por uma thread dedicada (`Conexao.cs`).
- Armazena usuários ativos em uma `Hashtable`.
- Encaminha mensagens entre os usuários conectados.

### Cliente
- Interface gráfica com Windows Forms.
- Usa `TcpClient` para se conectar ao servidor.
- `StreamReader` e `StreamWriter` para troca de mensagens.
- Thread dedicada para escuta assíncrona de mensagens.

## 📡 Comunicação

A comunicação é baseada em TCP (orientada a conexão). Cada cliente se identifica ao servidor com um nome de usuário, que é validado antes da conexão ser aceita.

### Protocolo Simples
- `1`: Conexão aceita
- `0|<mensagem>`: Conexão recusada
- `<mensagem>`: Texto padrão transmitido

## 📦 Como usar

### Servidor
1. Compile o projeto `ChatServer`.
2. Execute o servidor (`Servidor.exe`).
3. Ele começará a escutar em uma porta específica (ex: 9999).

### Cliente
1. Compile o projeto `ChatCliente`.
2. Execute o cliente (`ChatCliente.exe`).
3. Informe o IP do servidor, porta e nome de usuário.
4. Clique em **Conectar**.

## 📝 Licença

Projeto acadêmico open-source, disponível para estudos e modificações.

## ✍️ Autor

Matheus – Estudante de Ciência da Computação  
