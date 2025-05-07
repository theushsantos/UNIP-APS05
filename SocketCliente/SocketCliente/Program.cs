using System;
using System.Collections.Generic;
using System.Globalization;
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

            

            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);

                socket.Connect(endpoint);

                Console.WriteLine("Conectado com Exito!");
                Console.WriteLine("Digite a informação a ser enviada: ");
                Console.WriteLine();

                string info = Console.ReadLine();

                byte[] infoEnviar = Encoding.Default.GetBytes(info);

                socket.Send(infoEnviar, 0, infoEnviar.Length, SocketFlags.None);

            }
            catch(Exception)
            {
                Console.WriteLine("Erro ao tentar conectar com o servidor...");
            }
            socket.Close();

            Console.WriteLine("Pressione qualquer teclar para finalizar...");
            Console.ReadKey();

        }
    }
}