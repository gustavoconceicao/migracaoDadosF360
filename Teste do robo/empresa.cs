using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMiracle.Docotic.Pdf;
using MongoDB.Bson.Serialization.Attributes;

namespace Teste_do_robo
{
    public class Empresa
    {
        public string cnpj;
        public string identificadoMatrizFilial;
        public string razaoSocial;
        public string nomeFantasia;
        public string capitalSocial;
        public string situacaoCadastral;
        public string dataSitualCadastral;
        public string cep;        
        public Socio socio;
       


        public Empresa(string path)
        {
            this.cnpj = getCNPJ(path);
            this.identificadoMatrizFilial = getIdentificadoMatriz(path);
            this.razaoSocial = getRazaoSocial(path);
            this.nomeFantasia = getNomeFantasia(path);
            this.capitalSocial = getCapitalSocial(path);
            this.situacaoCadastral = getSituacaoCadastral(path);
            this.dataSitualCadastral = getDataSituacao(path);
            this.cep = getCEP(path);            
            this.socio = new Socio(path);
        }

        static string getCNPJ(string path)
        {
            string cnpj = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[1];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(227.50, 162.33, 11.06, 13.61),
                    WithFormatting = false
                };
                cnpj = page.GetText(options);
                Console.WriteLine(cnpj);

            }
            return cnpj;
        }

        static string getIdentificadoMatriz(string path)
        {
            string identificador = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[1];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(227.50, 205.33, 5.56, 13.61),
                    WithFormatting = false
                };
                identificador = page.GetText(options);
                Console.WriteLine(identificador);

            }
            return identificador;
        }

        static string getRazaoSocial(string path)
        {
            string identificador = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[1];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(230.30, 248.33, 16.65, 13.61),
                    WithFormatting = false
                };
                identificador = page.GetText(options);
                Console.WriteLine(identificador);

            }
            return identificador;
        }

        static string getNomeFantasia(string path)
        {
            string identificador = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[1];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(230.30, 285.33, 11.06, 13.61),
                    WithFormatting = false
                };
                identificador = page.GetText(options);
                Console.WriteLine(identificador);

            }
            return identificador;
        }

        static string getCapitalSocial(string path)
        {
            string identificador = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[3];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(227.50, 268.33, 11.06, 13.61),
                    WithFormatting = false
                };
                identificador = page.GetText(options);
                Console.WriteLine(identificador);

            }
            return identificador;
        }

        static string getSituacaoCadastral(string path)
        {
            string identificador = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[1];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(227.50, 322.33, 5.56, 13.61),
                    WithFormatting = false
                };
                identificador = page.GetText(options);
                Console.WriteLine(identificador);

            }
            return identificador;
        }

        static string getDataSituacao(string path)
        {
            string identificador = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[1];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(230.30, 455.33, 5.56, 13.61),
                    WithFormatting = false
                };
                identificador = page.GetText(options);
                Console.WriteLine(identificador);

            }
            return identificador;
        }

        static string getCEP(string path)
        {
            string identificador = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[2];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(227.50, 365.33, 5.56, 13.61),
                    WithFormatting = false
                };
                identificador = page.GetText(options);
                Console.WriteLine(identificador);

            }
            return identificador;
        }
    }
}