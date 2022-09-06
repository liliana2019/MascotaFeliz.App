using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Dueno AddMascota(Mascota mascota);
        Dueno UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Dueno GetMascota(int idMascota);
        IEnumerable<Mascota> GetMascotasPorFiltro(string filtro);
    }
}