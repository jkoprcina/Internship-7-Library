using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipLibrary.Extensions.Interfaces
{
    public interface ICrud
    {
        void Create();
        string Read();
        void Update();
        void Delete();
    }
}
