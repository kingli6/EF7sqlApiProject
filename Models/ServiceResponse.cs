using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrickGODWebApiEF7SQL.Models
{
    public class ServiceResponse<T> //<T> placeholder datatype? Learn this!
    {
        public T? Data { get; set; }    //it's nullable. so you don't need to... 1:14:00  https://www.youtube.com/watch?v=9zJn3a7L1uE
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty; //string.Empty??

    }
}