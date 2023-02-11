using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic ;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        //IRepositorioDueño un interfas que define el tipo de repositorio, como decir String o Int 
        //_repoDueno: es una variable es una interfas que implementa los metodos en el Repositorio Dueno
        //RepositorioDueno: Esta llamando al constructor que pide al AppContext de la persistencia
        
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Proceso Finalizado con Exito ;)");

            // AddDueno();
            // AddVeterinario();
            // AddMascota();
            // AddHistoria();
            // AddVisitaPyP();

            // AsignarHistoria();
            // AsignarDueno();
            // AsignarVeterinario();
            // AsignarVisitaPyP(1);

            ListarMascotas();
            // ListarHistorias();

            // DeleteDueno(5);
            // DeleteVeterinario(2);
            // DeleteHistoria(4);
            // DeleteMascota(2);
            // DeleteVisitaPyP(1);

            // BuscarDueno(1);
            // BuscarMascota(1);
            // BuscarVeterinario(3);
            // BuscarHistoria(2);
            // BuscarVisitasPyP(2);
            

            // GetAllDuenos();
            // GetAllVeterinarios();
            // GetAllMascotas();
            // GetAllVisitasPyP();
            
            // GetDuenosPorFiltro();
            // GetVeterinariosPorFiltro();
            // GetMascotaPorFiltro();
            // GetHistoriaPorFiltro();

        }

        //Inicio de metodos de Adicion

        private static void AddDueno()
        {
            var dueno = new Dueno{
                Cedula = "1084227555",
                Nombres = "Wilson",
                Apellidos = "Eraso",
                Direccion ="Pasto",
                Telefono = "31653184662",
                Correo = "wilsoneraso@gmail.com"
            };
            //Llamemos a _repoDueno para asignarle el metodo AddDueno
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario{
                Cedula = "1085325699",
                Nombres = "Sandra",
                Apellidos = "Maya",
                Direccion ="Bogota",
                Telefono = "3003214459",
                TarjetaProfesional = "MP-365426"
            };
            //Llamemos a _repoDueno para asignarle el metodo AddDueno
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota{
                Nombre = "Firulays",
                Color = "Cafe",
                Especie ="Macho",
                Raza = "Ladrador",
 
            };
            //Llamemos a _repoDueno para asignarle el metodo AddDueno
            _repoMascota.AddMascota(mascota);
        }

        public static void AddHistoria()
        {
            var historia = new Historia{
                FechaInicial = new DateTime(2022,09,26)
            };
            _repoHistoria.AddHistoria(historia);
        }


        private static void AddVisitaPyP()
        {
            var visitaPyP = new VisitaPyP{
                FechaVisita = new DateTime(2022,07,30),
                Temperatura = 36.5f,
                Peso = 15f,
                FrecuenciaRespiratoria = 80f,
                FrecuenciaCardiaca = 120f,
                EstadoAnimo = "Activo",
                Recomendaciones = "Reposo por 7 dias"
                
            };
            //Llamemos a _repoDueno para asignarle el metodo AddDueno
            _repoVisitaPyP.AddVisitaPyP(visitaPyP);
        }

        private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", CedulaVeterinario = "123", Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2030, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", CedulaVeterinario = "123", Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }

        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(2, 4);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void AsignarHistoria()
        {
            var historia = _repoMascota.AsignarHistoria(2, 5);
            Console.WriteLine(historia.FechaInicial);
        }

        private static void AsignarDueno()
        {
            var dueno = _repoMascota.AsignarDueno(2, 2);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }

        //LISTADO Metodo
        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach(Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres+ " " + d.Apellidos);
            }
        }
        
        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach(Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre+ " " + m.Raza +" mascota de "+ m.Dueno.Nombres+ " "+m.Dueno.Apellidos+" y lo atiende el veterinario "+m.Veterinario.Nombres+" su historia es "+m.Historia.FechaInicial );
            }
        }

        private static void ListarHistorias()
        {
            var historias = _repoHistoria.GetAllHistorias();
            foreach(Historia h in historias)
            {
                Console.WriteLine(h.Id+ " Este es el Id de la historia");
            }
        }



        // Metodos de Borrado

        

        private static void DeleteDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine("Se a borro a "+dueno.Nombres+" "+dueno.Apellidos);
            _repoDueno.DeleteDueno(idDueno);
        }

        private static void DeleteVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine("Se a borro a "+veterinario.Nombres+" "+veterinario.Apellidos);
            _repoVeterinario.DeleteVeterinario(idVeterinario);
        }

        private static void DeleteHistoria(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            Console.WriteLine("Se a borro al Id "+historia.Id);
            _repoHistoria.DeleteHistoria(idHistoria);
        }

        private static void DeleteMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine("Se a borro al Id "+mascota.Id + mascota.Nombre);
            _repoMascota.DeleteMascota(idMascota);
        }

        private static void DeleteVisitaPyP(int idVisitaPyP)
        {
            var visitaPyP = _repoVisitaPyP.GetVisitasPyP(idVisitaPyP);
            Console.WriteLine("Se a borro a "+visitaPyP.Id+" "+visitaPyP.FechaVisita);
            _repoVisitaPyP.DeleteVisitaPyP(idVisitaPyP);
        }

        
        //Metodos de Busqueda

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres+" "+dueno.Apellidos);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres+" "+veterinario.Apellidos);
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre+" " + mascota.Color+" "+mascota.Raza);
        }

        private static void BuscarHistoria(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            Console.WriteLine("El Id es " + historia.Id+" y la fecha es Inicial " + historia.FechaInicial);
        }

        private static void BuscarVisitasPyP(int idVisitaPyP)
        {
            var visitaPyP = _repoVisitaPyP.GetVisitasPyP(idVisitaPyP);
            Console.WriteLine("El Id es " + visitaPyP.Id+" y la fecha Inicial es " + visitaPyP.FechaVisita);
        }

        //Metodos de Busqueda completa

        public static void GetAllDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos); 
            }
        }

        public static void GetAllVeterinarios()
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario v in veterinarios)
            {
                Console.WriteLine(v.Nombres + " " + v.TarjetaProfesional); 
            }
        }

        public static void GetAllMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine(m.Nombre+" " + m.Color+" "+m.Raza); 
            }
        }

        public static void GetAllHistorias()
        {
            var historias = _repoHistoria.GetAllHistorias();
            foreach (Historia h in historias)
            {
                Console.WriteLine("El Id es " + h.Id+" y la fecha inicial es " + h.FechaInicial); 
            }
        }

        public static void GetAllVisitasPyP()
        {
            var visitasPyP = _repoVisitaPyP.GetAllVisitasPyP();
            foreach (VisitaPyP v in visitasPyP)
            {
                Console.WriteLine("El Id es " + v.Id+" y la fecha inicial es " + v.FechaVisita); 
            }
        }

        //Metodo de filtrar

        private static void GetDuenosPorFiltro()
        {
            var duenoFiltro = _repoDueno.GetDuenosPorFiltro("N");
            foreach (Dueno d in duenoFiltro)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void GetVeterinariosPorFiltro()
        {
            var veterinariosFiltro = _repoVeterinario.GetVeterinariosPorFiltro("C");
            foreach (Veterinario v in veterinariosFiltro)
            {
                Console.WriteLine(v.Nombres + " " + v.Apellidos);
            }
        }

        private static void GetMascotaPorFiltro()
        {
            var mascotaFiltro = _repoMascota.GetMascotaPorFiltro("C");
            foreach (Mascota m in mascotaFiltro)
            {
                Console.WriteLine(m.Nombre + " " + m.Especie);
            }
        }

        // private static void GetHistoriaPorFiltro()
        // {
        //     var historiaFiltro = _repoHistoria.GetHistoriaPorFiltro("2");
        //     foreach (Historia h in historiaFiltro)
        //     {
        //         Console.WriteLine(h.Id + " " + h.FechaInicial);
        //     }
        // }

        // private static void GetVisitaPyPPorFiltro()
        // {
        //     var visitasPyPFiltro = _repoVisitaPyP.GetVisitaPyPPorFiltro("C");
        //     foreach (VisitaPyP v in visitasPyPFiltro)
        //     {
        //         Console.WriteLine("La Id es " + v.Id + "La fecha de visita es " +v.FechaVisita);
        //     }
        // }

        
    }
}
