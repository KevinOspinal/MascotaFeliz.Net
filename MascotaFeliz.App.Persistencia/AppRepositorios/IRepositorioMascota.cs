//Esto es una INTERFAZ

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        //Teoria de interfases, describen la firma de los metodos
        //firma es el nombre del metodo sin el cuerpo para saber como implementarla
        //Funcion CRUD para llamar desde otros archivos
        
        // IEnumerable tipo de estructura de datos que sirve para almacenar elementos de tipo Mascota
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
        IEnumerable<Mascota> GetMascotaPorFiltro(String filtro);
        Dueno AsignarDueno(int idMascota, int idDueno);
        Veterinario AsignarVeterinario(int idMascota, int idVeterinario);
        Historia AsignarHistoria(int idMascota, int idHistoria);
    
    }
}