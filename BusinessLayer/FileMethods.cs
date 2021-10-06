using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Milestone2_PRG282.DataAccessLayer;

namespace Project_Milestone2_PRG282.BusinessLayer
{
    class FileMethods
    {

        public List<User> Read()
        {
            return new FileHandler().Read_Users();

        }


    }
}
