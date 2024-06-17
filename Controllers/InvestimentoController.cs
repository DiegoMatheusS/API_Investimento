using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investimento.Models.Enuns;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Investimento.Data;
using Investimento.Models;

namespace Investimento.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestimentoController : ControllerBase
    {

        //parte para banco de dados na nuvem

        
       private readonly DataContext _context;

        public InvestimentoController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Moeda m = await _context.TB_MOEDA.
                FirstOrDefaultAsync(mBusca => mBusca.Id == id);

                return Ok(m);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Moeda> lista = await _context.TB_MOEDA.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Moeda novaMoeda)
        {
            try
            {
                await _context.TB_MOEDA.AddAsync(novaMoeda);
                await _context.SaveChangesAsync();
           
                return Ok(novaMoeda.Id);
            }
           catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<IActionResult> Update(Moeda novaMoeda)
        {
            try
            {
                _context.TB_MOEDA.Update(novaMoeda);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
           catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Moeda mRemover = await _context.TB_MOEDA.FirstOrDefaultAsync(m => m.Id == id);

                _context.TB_MOEDA.Remove(mRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);

            }
           catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



      /* private static List<Moeda> TipoInvestimento = new List<Moeda>()
        {
                new Moeda() { Id = 1, Name = "BTC", Valor = 65000, Quantidade = 0.0050, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 250, Prejuizo=0, Imposto = 25.50 },
                new Moeda() { Id = 2, Name = "ETH", Valor = 3500, Quantidade= 0.020, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 125, Prejuizo=0, Imposto = 25.50},
                new Moeda() { Id = 3, Name = "SHIB", Valor = 0.00002437, Quantidade = 1123456.20, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 30, Prejuizo=0, Imposto = 25.50},
                new Moeda() { Id = 4, Name = "DOGE", Valor = 0.16, Quantidade= 124353.556, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 5, Prejuizo=0, Imposto = 25.50},
                new Moeda() { Id = 5, Name = "ADA", Valor = 0.4566, Quantidade = 1202.12, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 0, Prejuizo=50, Imposto = 25.50},
                new Moeda() { Id = 6, Name = "BNB", Valor = 500, Quantidade= 54, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 12, Prejuizo=0, Imposto = 25.50},
                new Moeda() { Id = 7, Name = "FLOKI", Valor = 0.00003565, Quantidade= 456543156.12, DataCompra= DateTime.Now, DataVenda= DateTime.Now, Lucro= 50, Prejuizo=0, Imposto = 25.50}
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(TipoInvestimento);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(TipoInvestimento.FirstOrDefault(inve => inve.Id == id));
        }

        [HttpPost]
        public IActionResult AddMoeda(Moeda novaMoeda)
        {
            TipoInvestimento.Add(novaMoeda);
            return Ok(TipoInvestimento);
        }

        [HttpGet("GetContagem")]
        public IActionResult GetQuantidade()
        {
            return Ok("Total de Tipos de Moedas "+ TipoInvestimento.Count);
        }

        [HttpGet("SomaMoedas")]
        public IActionResult Somamoedas()
        {
            return Ok(TipoInvestimento.Sum(i => i.Quantidade));
        }

        [HttpPut]
        public IActionResult UpdateMoeda(Moeda i)
        {
            Moeda moedaAlterada = TipoInvestimento.Find(inv => inv.Id == i.Id);
            moedaAlterada.Name = i.Name;
            moedaAlterada.Valor = i.Valor;
            moedaAlterada.Quantidade = i.Quantidade;
            moedaAlterada.DataVenda = i.DataVenda;
            moedaAlterada.DataCompra = i.DataCompra;
            moedaAlterada.Lucro = i.Lucro;
            moedaAlterada.Prejuizo = i.Prejuizo;
            moedaAlterada.Imposto=i.Imposto;

            return Ok(TipoInvestimento);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            TipoInvestimento.RemoveAll(inv => inv.Id == id);

            return Ok(TipoInvestimento);
        }*/
    }
}
