using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Schoolboy
{
    public class Schoolboy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double Averagerating { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Middlename { get; set; }

        public int Class { get; set; }

        public int Ranked { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Middlename + " " + ":" + " " + Class.ToString() + " класс";
        }
    }
}
