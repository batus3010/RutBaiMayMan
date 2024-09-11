using RutBaiMayMan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutBaiMayMan
{
    internal class PlayerManager
    {
        private List<Player> _players = new List<Player>();

        public Player RegisterPlayer(string username, string password)
        {
            var player = new Player
            {
                Username = username,
                Password = password,  // Hash the password in a real app
                Status = PlayerStatus.Online
            };

            _players.Add(player);
            return player;
        }

        public Player LoginPlayer(string username, string password)
        {
            var player = _players.FirstOrDefault(p => p.Username == username && p.Password == password);

            if (player != null)
            {
                player.Status = PlayerStatus.Online;
            }

            return player;
        }

        public List<Player> GetOnlinePlayers()
        {
            return _players.Where(p => p.Status == PlayerStatus.Online).ToList();
        }
    }
}
