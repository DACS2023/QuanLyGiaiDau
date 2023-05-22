using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using QuanLyGiaiDau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyGiaiDau.Controllers
{
    public class TiSoController : Controller
    {
        private readonly QuanLyGiaiDauContext _context;
        public TiSoController(QuanLyGiaiDauContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("api/danh-sach-bang-dau")]
        public async Task<ActionResult<IEnumerable<TiSoModel>>> GetTiSo()
        {
            List<CT_TranDau> a = await _context.CT_TranDaus.ToListAsync();

            
            List<TiSoModel> TiSos = new List<TiSoModel>();
            TiSoModel tiSoModel = new TiSoModel();
            

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i+1; j < a.Count; j++)
                {
                    if (a[i] == a[j])
                    {
                        continue;
                    }
                    
                    if (a[i].IdGiaiDau == a[j].IdGiaiDau && a[i].SanDau == a[j].SanDau && a[i].ThoiGianBatDau == a[j].ThoiGianBatDau && a[i].VongDau == a[j].VongDau)
                    {
                        tiSoModel = new TiSoModel();
                        tiSoModel.Doi1 = _context.DoiDaus.Where(x => x.IdDoiDau == a[i].IdDoiDau).FirstOrDefault();
                        tiSoModel.Doi2 = _context.DoiDaus.Where(x => x.IdDoiDau == a[j].IdDoiDau).FirstOrDefault();
                        tiSoModel.TiSoDoi1 = a[i].TiSo;
                        tiSoModel.TiSoDoi2 = a[j].TiSo;
                        tiSoModel.ThoiGianBatDau = a[i].ThoiGianBatDau;
                        tiSoModel.GiaiDau = _context.GiaiDaus.Where(x=>x.IdGiaiDau == a[i].IdGiaiDau).FirstOrDefault();
                        tiSoModel.SanDau = a[i].SanDau;
                        tiSoModel.GiaiDau.LoaiGiaiDau = _context.LoaiGiaiDau.Where(x => x.IdloaiGiaiDau == a[i].GiaiDau.IdloaiGiaiDau).FirstOrDefault();
                        tiSoModel.GiaiDau.LoaiGiaiDau.MonTheThao = _context.MonTheThaos.Where(x => x.IdMonTheThao == a[i].GiaiDau.LoaiGiaiDau.IdMonTheThao).FirstOrDefault();
                        TiSos.Add(tiSoModel);
                        
                        break;

                    }
                }
            }
            return TiSos;
        }
        //[HttpPut]
        //[Route("api/update-ti-so")]
        //public async Task<IActionResult> UpdateTiSo(TiSoModel TiSo)
        //{
        //    //var UpdateDoi1 = await _context.CT_TranDaus.Where(x => x.IdGiaiDau.Equals(TiSo.GiaiDau.IdGiaiDau)  && x.IdDoiDau.Equals(TiSo.Doi1.IdDoiDau)  && x.SanDau.Equals(TiSo.SanDau)
        //    //&& x.ThoiGianBatDau.Equals(TiSo.ThoiGianBatDau)).FirstAsync();
        //    //var UpdateDoi2 = await _context.CT_TranDaus.Where(x => x.IdGiaiDau.Equals(TiSo.GiaiDau.IdGiaiDau) && x.IdDoiDau.Equals(TiSo.Doi2.IdDoiDau) && x.SanDau.Equals(TiSo.SanDau)
        //    //&& x.ThoiGianBatDau.Equals(TiSo.ThoiGianBatDau)).FirstAsync();
        //    //CT_TranDau updateD1 = new CT_TranDau();
        //    //CT_TranDau updateD2 = new CT_TranDau();

        //    //var UpdateDoi1 = await _context.CT_TranDaus.Where(x => x.IdDoiDau.Equals(TiSo.Doi1.IdDoiDau.Trim())).FirstAsync();
        //    //var UpdateDoi2 = await _context.CT_TranDaus.Where(x => x.IdDoiDau.Equals(TiSo.Doi2.IdDoiDau.Trim())).FirstAsync();
        //    //UpdateDoi1.TiSo = TiSo.TiSoDoi1;
        //    //UpdateDoi2.TiSo = TiSo.TiSoDoi2;
        //    //if (TiSo.DoiThang.Equals(1))
        //    //{
        //    //    UpdateDoi1.KetQua = "Thắng";
        //    //    UpdateDoi2.KetQua = "Thua";
        //    //}
        //    //if (TiSo.DoiThang.Equals(2))
        //    //{
        //    //    UpdateDoi1.KetQua = "Thua";
        //    //    UpdateDoi2.KetQua = "Thắng";
        //    //}
        //    //if (TiSo.DoiThang.Equals(0))
        //    //{
        //    //    UpdateDoi1.KetQua = null;
        //    //    UpdateDoi2.KetQua = null;
        //    //}

        //    //_context.Entry(UpdateDoi1).State = EntityState.Modified;
        //    //_context.Entry(UpdateDoi2).State = EntityState.Modified;
        //    //await _context.SaveChangesAsync();
        //    return (IActionResult)TiSo;

        //    return NoContent();
        //}
    }
    
}
