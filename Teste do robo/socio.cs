using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitMiracle.Docotic.Pdf;

namespace Teste_do_robo
{
    public class Socio
    {
       public string identificadoSocio;
       public string nomeSocio;
       public string cnpjSocio;

        public Socio(string path)
        {
            this.identificadoSocio = getidentificadoSocio(path);
            this.nomeSocio = getnomeSocio(path);
            this.cnpjSocio = getcnpjSocio(path);
        }

        static string getidentificadoSocio(string path)
        {
            string identificadoSocio = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[4];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(212.20, 552.23, 5.56, 13.61),
                    WithFormatting = false
                };
                identificadoSocio = page.GetText(options);
                Console.WriteLine(identificadoSocio);

            }
            return identificadoSocio;
        }

        static string getnomeSocio(string path)
        {
            string nomeSocio = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[4];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(212.20, 613.23, 16.65, 13.61),
                    WithFormatting = false
                };
                nomeSocio = page.GetText(options);
                Console.WriteLine(nomeSocio);

            }
            return nomeSocio;
        }

        static string getcnpjSocio(string path)
        {
            string cnpjSocio = "";
            using (var pdf = new PdfDocument(path))
            {
                var page = pdf.Pages[4];

                //CNPJ
                var options = new PdfTextExtractionOptions
                {
                    Rectangle = new PdfRectangle(212.20, 686.23, 11.15, 13.61),
                    WithFormatting = false
                };
                cnpjSocio = page.GetText(options);
                Console.WriteLine(cnpjSocio);

            }
            return cnpjSocio;
        }

    }
}
