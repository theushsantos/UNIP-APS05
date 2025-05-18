# Documentação da Classe Servidor - Projeto Chat em C#

Esta documentação descreve detalhadamente o funcionamento da classe `Servidor`, responsável por gerenciar as conexões e mensagens em um servidor de chat TCP escrito em C#.

## Namespaces Importados

O código importa diversos namespaces do .NET Framework. Nem todos são utilizados, mas estão listados abaixo:

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

## Delegate e Eventos

O delegate `StatusChangedEventHandler` define o tipo de método que será chamado quando houver uma mudança de status. O evento `StatusChanged` é disparado sempre que um usuário entra, sai ou envia uma mensagem.

## Construtor da Classe Servidor

O construtor recebe o IP e porta onde o servidor escutará novas conexões e armazena esses valores para uso posterior.

## Estruturas de Dados

- `htUsuarios`: mapeia nomes de usuário para conexões `TcpClient`.
- `htConexoes`: mapeia conexões `TcpClient` para nomes de usuário.

Essas `Hashtable`s permitem fácil consulta em ambas as direções.

## Método IncluiUsuario

Adiciona um novo usuário e sua conexão nas hash tables e envia uma mensagem administrativa notificando todos os usuários.

## Método RemoveUsuario

Remove o usuário das hash tables e envia uma mensagem administrativa informando sua saída.

## Método OnStatusChanged

Dispara o evento `StatusChanged`, utilizado para atualizar a interface gráfica ou logs do servidor.

## Método EnviaMensagemAdmin

Envia uma mensagem administrativa (vinda do servidor) para todos os usuários conectados. Se falhar ao enviar, remove o usuário.

## Método EnviaMensagem

Envia uma mensagem de um usuário para todos os outros. Também exibe a mensagem no servidor.

## Método IniciaAtendimento

Inicializa o servidor, instanciando o `TcpListener`, iniciando a escuta de conexões e iniciando a thread de atendimento.

## Método MantemAtendimento

Loop contínuo que aceita novas conexões e instancia a classe `Conexao` para lidar com cada cliente individualmente.

## Pontos de Melhoria

- Remover namespaces não utilizados para limpar o código.
- Adicionar tratamento de exceção no método `IniciaAtendimento`, que atualmente está vazio.
- Considerar limitar o número de conexões ou tratar picos de uso.
