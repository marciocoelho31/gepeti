using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gpti.Context;
using gpti.Models;

namespace gpti.Controllers
{
    public class ClientesController : Controller
    {
        private readonly AppDbContext _context;

        public ClientesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Razao,Endereco,Cep,Bairro,Cidade,Estado,Valor,Vencimento,Multa,CGC,Inscricao,Telefone,Contato,Cobranca,Dolar,VendaAlugu,Salario,IniContrat,IniManut,Mensagem,CodMem,UltBol,Obs,FormaPg,E_mail,Homepage,Corresp,Sistema,Versao,Parcelas,ValPar,DtInicio,Receita,Custo,Tempo,ValorTotal,DescFat,Login,Senha,Autorizado,Mensagem_No_Site,PastaServer,PastaClient,PercSobreSalario,DataTravaSistema,DiasARenovar,BancoCobr,Opcao_NO,mysql_ip,mysql_nomebd,mysql_user,mysql_pwd,QtMaq,QtMaqDesktop,QtMaqMovel,DtRescisao,DtAudVal,DtUltAcesso,DtEmiBol,NumBoleto,CorrecaoDiariaAtraso,HrEmiBol,LoginEmiBol,NomeEmissorBol,QtMaquinasReg,PercSalAdMaq,CritMensalid,MesAtraso,ValorAnterior,ValMensMob,QtUsuariosMob,ValMensSiteOnl,DiaSemanaBkp,DataUltBkp,HoraUltBkp,E_mail2,E_mail3,MostraAnuncios,Senha_A,PercDesconto")] Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientes);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes.FindAsync(id);
            if (clientes == null)
            {
                return NotFound();
            }
            return View(clientes);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Razao,Endereco,Cep,Bairro,Cidade,Estado,Valor,Vencimento,Multa,CGC,Inscricao,Telefone,Contato,Cobranca,Dolar,VendaAlugu,Salario,IniContrat,IniManut,Mensagem,CodMem,UltBol,Obs,FormaPg,E_mail,Homepage,Corresp,Sistema,Versao,Parcelas,ValPar,DtInicio,Receita,Custo,Tempo,ValorTotal,DescFat,Login,Senha,Autorizado,Mensagem_No_Site,PastaServer,PastaClient,PercSobreSalario,DataTravaSistema,DiasARenovar,BancoCobr,Opcao_NO,mysql_ip,mysql_nomebd,mysql_user,mysql_pwd,QtMaq,QtMaqDesktop,QtMaqMovel,DtRescisao,DtAudVal,DtUltAcesso,DtEmiBol,NumBoleto,CorrecaoDiariaAtraso,HrEmiBol,LoginEmiBol,NomeEmissorBol,QtMaquinasReg,PercSalAdMaq,CritMensalid,MesAtraso,ValorAnterior,ValMensMob,QtUsuariosMob,ValMensSiteOnl,DiaSemanaBkp,DataUltBkp,HoraUltBkp,E_mail2,E_mail3,MostraAnuncios,Senha_A,PercDesconto")] Clientes clientes)
        {
            if (id != clientes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientesExists(clientes.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(clientes);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientes == null)
            {
                return NotFound();
            }

            return View(clientes);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientes = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(clientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientesExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
