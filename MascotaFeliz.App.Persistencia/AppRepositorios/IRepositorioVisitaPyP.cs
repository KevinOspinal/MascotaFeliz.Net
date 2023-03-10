using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        IEnumerable<VisitaPyP> GetAllVisitasPyP();
        VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP);
        VisitaPyP UpdateVisitasPyP(VisitaPyP visitaPyP);
        void DeleteVisitaPyP(int idVisitaPyP);
        VisitaPyP GetVisitasPyP(int idVisitaPyP);
        // IEnumerable<VisitaPyP> GetVisitaPyPPorFiltro(String filtro);
        
    }
}