using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }


    class SqlServerCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql aadded");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }

        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }
    }


    class OracleCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle adeed");
        }

        public void Update()
        {
            Console.WriteLine("oracle updated");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }
    }
    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql adeed");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}


