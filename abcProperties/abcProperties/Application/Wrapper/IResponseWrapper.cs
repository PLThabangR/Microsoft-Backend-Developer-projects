using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrapper
{
    /// <summary>
    /// Non Generic response wrapper
    /// </summary>
    public interface IResponseWrapper
    {
        public List<string> Messages { get; set; } 
        public bool isSuccessful { get; set; }



    }

    /// <summary>
    /// Generic response wrapper
    /// </summary>
    /// This inherit the non generic response wrapper
    public interface IResponseWrapper<out T>: IResponseWrapper
    {
        //this returns the data of type T, which can be any type, and is read-only
        public T Data { get; }
       



    }


}
