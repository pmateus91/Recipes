using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepies.Model.Model
{
    public class Recepie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instruction { get; set; }
        public ArrayList Ingredients { get; set; }
        public ArrayList Categories { get; set; }
        public int TotalTime { get; set; }
        public enum Dificult { get; set; }
        public enum Classification { get; set; }
        public ArrayList Comentary { get; set; }
    }
}
