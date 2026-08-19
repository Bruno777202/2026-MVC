using Microsoft.AspNetCore.Mvc;

namespace MVC2026;


public class Produtoscontroller : Controller
{
    private List<Produto> _listaProdutos =new List<Produto>();
    
    public Produtoscontroller()
    {
       _listaProdutos.Add(new Produto{id = Guid.NewGuid(), Nome = "Chave de Fenda", quantidade = 65 });
       _listaProdutos.Add(new Produto{id = Guid.NewGuid(), Nome = "Alicate", quantidade = 99});
       _listaProdutos.Add(new Produto{id = Guid.NewGuid(), Nome = "Martelo", quantidade = 37});
       _listaProdutos.Add(new Produto{id = Guid.NewGuid(), Nome = "Parafuso", quantidade = 56});
       _listaProdutos.Add(new Produto{id = Guid.NewGuid(), Nome = "Fita Isolante", quantidade = 82});
              
    }


    public IActionResult index()
    {
        var produtos = _listaProdutos;
        return View(produtos);
    }











}