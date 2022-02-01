using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccessLayer
{
    public interface IDataAccess
    {
        List<T> ReadData<T>(string storedProcName, Dictionary<string, object> parameters);

    }
}
