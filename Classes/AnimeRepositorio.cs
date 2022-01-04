using System;
using System.Collections.Generic;
using DIO.Animes.Interfaces;

namespace DIO.Animes
{
    public class AnimeRepositorio : IRepositorio<Animes>
    {

        private List<Animes> listaAnimes = new List<Animes>();
        public void Atualiza(int id, Animes objeto)
        {
            listaAnimes[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaAnimes[id].Excluir();
        }

        public void Insere(Animes objeto)
        {
            listaAnimes.Add(objeto);
        }

        public List<Animes> Lista()
        {
            return listaAnimes;
        }

        public int ProximoId()
        {
            return listaAnimes.Count;
        }

        public Animes RetornaPorId(int id)
        {
            return listaAnimes[id];
        }
    }
}