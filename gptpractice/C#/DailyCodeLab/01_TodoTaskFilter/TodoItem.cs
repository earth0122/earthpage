using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TodoTaskFilter
{
    internal class TodoItem
    {
        //public string Title { get; set; } = string.Empty; 防止Nullable Reference Types 可能會出現未初始化警告
        public string Title { get; set; }
       public  bool IsCompleted { get; set; }
    }
}
