using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            /*
             AddressFamily.InterNetwork - Define a familia do endereço - IPV4
             SocketType.Stream - tipo de socket - tipo responsavel pela comunicação de dados (envio e recebimento)  
             ProtocolType - tipo de protocolo - tipo TCP
             */
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),1234);
            socket.Bind(endpoint);

            socket.Listen(5);

            Console.WriteLine("Escutando...");

            Socket escutar = socket.Accept();
            byte[] bytes = new byte[255];

            int tamanho = escutar.Receive(bytes, 0,bytes.Length, SocketFlags.None);

            Array.Resize(ref bytes, tamanho);

            Console.WriteLine("Cliente Falou: ");
            Console.WriteLine(Encoding.Default.GetString(bytes));

            socket.Close();

            Console.WriteLine("Sevidor Finalizado!\nPrecione qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}