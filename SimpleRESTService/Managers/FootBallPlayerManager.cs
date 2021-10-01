using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave1;

namespace SimpleRESTService.Managers
{
    public class FootBallPlayerManager
    {
        private static int _nextId = 1;
        private static readonly List<FootBallPlayer> Data = new List<FootBallPlayer>
        {
            new FootBallPlayer {Id = _nextId++, Name = "Bobo", ShirtNumber = 42, Price = 1000000},
            new FootBallPlayer {Id=_nextId++, Name = "Lille Lars", ShirtNumber = 89, Price = 6888}
        };

        public List<FootBallPlayer> GetAll()
        {
            return new List<FootBallPlayer>(Data);
        }

        public FootBallPlayer GetById(int id)
        {
            return Data.Find(p => p.Id == id);
        }

        public FootBallPlayer Add(FootBallPlayer newFootBallPlayer)
        {
            newFootBallPlayer.Id = _nextId++;
            Data.Add(newFootBallPlayer);
            return newFootBallPlayer;
        }

        public FootBallPlayer Delete(int id)
        {
            FootBallPlayer footBallPlayer = Data.Find(p1 => p1.Id == id);
            if (footBallPlayer == null) return null;
            Data.Remove(footBallPlayer);
            return footBallPlayer;
        }

        public FootBallPlayer Update(int id, FootBallPlayer updates)
        {
            FootBallPlayer footBallPlayer = Data.Find(p1 => p1.Id == id);
            if (footBallPlayer == null) return null;
            footBallPlayer.Name = updates.Name;
            footBallPlayer.ShirtNumber = updates.ShirtNumber;
            footBallPlayer.Price = updates.Price;
            return footBallPlayer;
        }
    }
}
