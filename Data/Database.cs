using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERPY.Data
{
    public partial class Database
    {
        public static Database Instance { get; private set; } = new Database();

        private Database() 
        {

        }

    }
}
