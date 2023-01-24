using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_spotify.src.Interfaces
{
    public interface ISearchable
    {
        public string name{ get; set; }
        public void share();
        public Boolean Equal(ISearchable searchable);
    }
}
