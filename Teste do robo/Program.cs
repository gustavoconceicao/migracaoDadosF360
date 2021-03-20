using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMiracle.Docotic.Pdf;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Net;
using System.IO.Compression;
using System.IO;

namespace Teste_do_robo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        static void salvarBanco(Empresa empresa)
        {
            var client = new MongoClient("mongodb://root:example@192.168.0.32:27017");
            var database = client.GetDatabase("dadosEmpresas");
            var collec = database.GetCollection<Empresa>("data");
            try
            {
                collec.InsertOne(empresa);
            }
            catch (MongoWriteException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static void baixarArquivos()
        {
            WebClient webClient = new WebClient();
            string[] numeros = {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09"};
            for (int i =0; i<numeros.Length; i++)
            {
                Console.WriteLine("http://200.152.38.155/CNPJ/DADOS_ABERTOS_CNPJ_" + numeros[i] + ".zip");
                try
                {
                    webClient.DownloadFile("http://200.152.38.155/CNPJ/DADOS_ABERTOS_CNPJ_" + numeros[i] + ".zip", @"C:\Users\gusta\Downloads\zipi." + i + ".zip");
                }
                catch
                {
                    Console.WriteLine("Arquivo não encontrado");
                }

                descompactarArquivos(@"http://200.152.38.155/CNPJ/DADOS_ABERTOS_CNPJ_" + numeros[i] + ".zip");
            }
            

        }

        static void descompactarArquivos(string path)
        {
            ZipFile.ExtractToDirectory(path, @"C: \Users\gusta\Downloads\destino");
        }
    }
}
