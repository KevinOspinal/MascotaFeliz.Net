using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaPyP : IRepositorioVisitaPyP
    {
        /// <summary>
        /// Referencia al contexto de VisitaPyP
        /// </summary>
        //Atributo
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        // Cuando se llame a RepositorioVisitaPyP debe llamar a AppContext
        // Es el constructor
        public RepositorioVisitaPyP(AppContext appContext)
        {
            _appContext = appContext;
        }

        public VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP)
        {
            var visitaPyPAdicionado = _appContext.VisitasPyP.Add(visitaPyP);
            _appContext.SaveChanges();
            return visitaPyPAdicionado.Entity;
        }

        public void DeleteVisitaPyP(int idVisitaPyP)
        {
            var visitaPyPEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
            if (visitaPyPEncontrado == null)
                return;
            _appContext.VisitasPyP.Remove(visitaPyPEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<VisitaPyP> GetAllVisitasPyP()
            {
                return GetAllVisitasPyP_();
            }

        // public IEnumerable<VisitaPyP> GetVisitaPyPPorFiltro(string filtro)
        // {
        //     var visitasPyP = GetAllVisitasPyP(); // Obtiene todos los saludos
        //     if (visitasPyP != null)  //Si se tienen saludos
        //     {
        //         if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
        //         {
        //             visitasPyP = visitasPyP.Where(s => s.Id.Contains(filtro));
        //         }
        //     }
        //     return visitasPyP;
        // }

        public IEnumerable<VisitaPyP> GetAllVisitasPyP_()
        {
            return _appContext.VisitasPyP;
        }

        public VisitaPyP GetVisitasPyP(int idVisitaPyP)
        {
            return _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
        }

        public VisitaPyP UpdateVisitasPyP(VisitaPyP visitaPyP)
        {
            var visitaPyPEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == visitaPyP.Id);
            if (visitaPyPEncontrado != null)
            {
                visitaPyPEncontrado.FechaVisita = visitaPyP.FechaVisita;
                visitaPyPEncontrado.Temperatura = visitaPyP.Temperatura;
                visitaPyPEncontrado.Peso = visitaPyP.Peso;
                visitaPyPEncontrado.FrecuenciaRespiratoria = visitaPyP.FrecuenciaRespiratoria;
                visitaPyPEncontrado.FrecuenciaCardiaca = visitaPyP.FrecuenciaCardiaca;
                visitaPyPEncontrado.EstadoAnimo = visitaPyP.EstadoAnimo;
                visitaPyPEncontrado.CedulaVeterinario = visitaPyP.CedulaVeterinario;
                visitaPyPEncontrado.Recomendaciones = visitaPyP.Recomendaciones;
                _appContext.SaveChanges();
            }
            return visitaPyPEncontrado;
        }  
        
    }
}