using System.Collections.Generic;

namespace FluentJqGrid
{
    public class JqGridModel<T>
    {
        public JqGridModel()
        {
            var type = typeof(T);
            var properties = type.GetProperties();    
        }
        public JqGridModel(IEnumerable<T> data)
        {

        }
        public IEnumerable<T> Data { get; set; }

    }
    
}