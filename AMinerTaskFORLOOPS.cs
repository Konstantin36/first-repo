using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();
// new заделя памет
            for (int i = 1; ; i++)
            {
                string resource = Console.ReadLine();
// това равенство се ползва за стрингове
                if (resource.Equals("stop"))
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

//Тук проверява дали съществува такъв key в myDic директроията и ако не го аддва
                if (!myDict.ContainsKey(resource))
                {
                    myDict.Add(resource, 0);
//insert new type resourse and entrance value for Exception
                }

//увеличаване на стойността с прочетеното количество
                myDict[resource] += quantity;
            }
//за повторно четене на входа (типове and стойности)
// всяко следващо четене запазва стойостта на предходната променлива

            foreach (var item in myDict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}