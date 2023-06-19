using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppCoinStore
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Nominal { get; set; }
        public string Country { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public bool Exchenge { get; set; }

        [ForeignKey("UserId")]
        public int Userid { get; set; }
        public User User { get; set; }

        public Coin()
        {

        }
    }
}
