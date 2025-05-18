
# Documentação da Classe `Form1` (Cliente)

Esta classe representa o formulário principal da aplicação cliente do sistema de chat. Ela lida com a interface gráfica, a conexão com o servidor e a troca de mensagens em tempo real.

---

## Namespaces Importados

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
```

- `System`: funcionalidades básicas (tipos primitivos, exceções).
- `System.Collections`: fornece `Hashtable`, usada para armazenar conexões.
- `System.Collections.Generic`: presente, mas não utilizado.
- `System.IO`: usado para o `StreamWriter`.
- `System.Linq`: presente, mas não utilizado.
- `System.Net`: usado para `IPAddress`.
- `System.Net.Sockets`: necessário para `TcpClient` e `TcpListener`.
- `System.Runtime.CompilerServices`: não utilizado.
- `System.Text`: não utilizado.
- `System.Threading`: usado para criar `Threads`.
- `System.Threading.Tasks`: não utilizado.


Esses namespaces fornecem suporte para:

- **System.Net / System.Net.Sockets**: manipulação de conexões de rede e sockets TCP.
- **System.Threading**: criação e controle de threads (comunicação assíncrona).
- **System.IO**: leitura e escrita de dados via stream (envio/recebimento de mensagens).
- **System.Windows.Forms / Drawing / ComponentModel**: interface gráfica (formulário, botões, labels, etc.).

---

## Campos Principais

- `NomeUsuario`: Nome do usuário conectado.
- `stwEnviador` / `strReceptor`: Streams para envio e recepção de mensagens.
- `tcpServidor`: Conexão TCP com o servidor.
- Delegates para atualizar UI de outra thread (thread-safe).
- `mensagemThread`: Thread que escuta as mensagens do servidor.
- `enderecoIP` / `portaHost`: IP e porta do servidor.
- `Conectado`: flag booleana de estado de conexão.

---

## Construtor

```csharp
public Form1()
```

Inicializa o formulário e associa o evento de fechamento do app à função `OnApplicationExit`.

---

## Botões e Eventos

### `btnConectar_Click`

Conecta ou desconecta do servidor dependendo do estado atual.

### `btnEnviar_Click`

Envia a mensagem digitada.

### `txtMensagem_KeyPress`

Permite enviar a mensagem pressionando ENTER.

---

## Método `InicializaConexao`

1. Lê o IP e porta informados no formulário.
2. Tenta se conectar ao servidor via TCP.
3. Atualiza os componentes da UI.
4. Envia o nome do usuário ao servidor.
5. Cria uma thread (`mensagemThread`) para escutar as mensagens.

---

## Método `RecebeMensagens`

- Recebe a primeira linha do servidor para validar conexão.
- Caso sucesso, começa a escutar mensagens do servidor continuamente.
- Atualiza a interface usando `Invoke` com os delegates apropriados.

---

## Método `AtualizaLog`

Exibe as mensagens no `txtLog`.

---

## Método `EnviaMensagem`

Envia a mensagem digitada no campo de texto para o servidor.

---

## Método `FechaConexao`

Desconecta do servidor, limpa os recursos e atualiza a interface para o estado de desconectado.

---

## Método `OnApplicationExit`

Executado ao fechar a aplicação. Garante que a conexão e os recursos sejam fechados adequadamente.

---

## Considerações Finais

A classe `Form1` é o ponto de entrada e controle da UI do cliente. Ela controla toda a comunicação com o servidor e atualização visual do estado do chat.
