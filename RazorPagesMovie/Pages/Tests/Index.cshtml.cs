using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages.Tests
{
    public class IndexModel : PageModel
    {
        public IList<string> Palavras { get; set; }

        public void OnGet()
        {
            var palavras = new List<string> { "casa", "cachorro", "gato", "carro", "moto", "amarelo", "vermelho", "verde", "roxo", "orelha", "pescoço", "boca", "nariz", "cabelo", "ferramenta", "escada", "grade", "porta", "janela", "trinco", "roupa", "sapato", "calça", "candelabro", "vela", "vidro", "madeira", "ferro", "alumínio", "aço", "borracha", "roda", "vassoura", "pá", "luz", "lâmpada", "rolha", "prateleira", "livro", "estante", "album", "guarda-roupas", "armário", "cabide", "copo", "prato", "talher", "colher", "faca", "xícara" };
            palavras.Sort();
            Palavras = palavras;            
        }
    }
}
