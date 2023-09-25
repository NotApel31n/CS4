using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS24
{
    public class Note
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsPositive { get; private set; }
        private double _count;
        internal int id;

        public double Count
        {
            get { return _count; }
            set
            {
                _count = value;
                IsPositive = value >= 0;
            }
        }
        public DateTime Date { get; }

        public Note(int id, string name, string type, double count, DateTime date)
        {
            Id = id;
            Name = name;
            Type = type;
            Count = count;
            Date = date;
        }
    }

}
