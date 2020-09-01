using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages.Tests
{
    public class IndexModel : PageModel
    {
        public IList<string> Palavras { get; set; }

        public void OnGet()
        {
            var palavras = new List<string> { "casa", "cachorro", "gato", "carro", "moto", "amarelo", "vermelho", "verde", "roxo", "orelha", "pesco�o", "boca", "nariz", "cabelo", "ferramenta", "escada", "grade", "porta", "janela", "trinco", "roupa", "sapato", "cal�a", "candelabro", "vela", "vidro", "madeira", "ferro", "alum�nio", "a�o", "borracha", "roda", "vassoura", "p�", "luz", "l�mpada", "rolha", "prateleira", "livro", "estante", "album", "guarda-roupas", "arm�rio", "cabide", "copo", "prato", "talher", "colher", "faca", "x�cara" };
            palavras.Sort();
            Palavras = palavras;            
        }
    }
}
