using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TodoTaskFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            //改為unfinishedTasks更直覺
            var nofinish = GetUncompletedTasks(list);
            foreach (var item in nofinish)
            {
                Console.WriteLine(item.Title);
            }

        }

        private static List<TodoItem> CreateList() 
        {
            return new List<TodoItem>()
            {
            new TodoItem{Title="學習 C#",IsCompleted= true },
            new TodoItem{Title="練習 HTML",IsCompleted= false },
            new TodoItem{Title="複習 SQL",IsCompleted= false },
            new TodoItem{Title="閱讀程式書",IsCompleted= true }
            };
        }
        private static List<TodoItem> GetUncompletedTasks(List<TodoItem> item)
        {
            //return item.Where(x => !x.IsCompleted).ToList(); 用布林值反轉更常見 簡潔
            return item.Where(x=>x.IsCompleted ==  false).ToList();   
        }


    }
   
}
