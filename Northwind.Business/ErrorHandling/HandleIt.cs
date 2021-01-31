using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ErrorHandling
{
    static class HandleIt
    {
        static void HandleError(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
