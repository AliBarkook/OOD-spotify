using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_spotify.src.Interfaces
{
    public interface ISearchable
    {
        public string Name{ get; set; }
        public void Share();
    }
}
