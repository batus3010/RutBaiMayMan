using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutBaiMayMan.Models
{
    internal class GameHistory
    {
        public int GameHistoryId { get; set; }
        public int PlayerOneId { get; set; }
        public int PlayerTwoId { get; set; }
        public GameResult Result { get; set; }
        public DateTime PlayedAt { get; set; }
    }
}
