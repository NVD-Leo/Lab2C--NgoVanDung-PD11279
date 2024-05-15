using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Bai3
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public List<float> Scores { get; set; }
        public Bai3(string id, string userName, List<float> scores)
        {
            ID = id;
            UserName = userName;
            Scores = scores;
        }
    }
}

