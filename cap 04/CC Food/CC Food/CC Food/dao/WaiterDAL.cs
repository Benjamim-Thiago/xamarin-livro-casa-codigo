using CC_Food.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CC_Food.dao
{
    class WaiterDAL
    {
        private ObservableCollection<Waiter> Waiter = new ObservableCollection<Waiter>();
        private static WaiterDAL WaiterInstance = new WaiterDAL();

        private WaiterDAL()
        {
            Waiter.Add(new Waiter() { id = 1, name = "José"});
            Waiter.Add(new Waiter() { id = 2, name = "Maria"});
            Waiter.Add(new Waiter() { id = 3, name = "Mauricio"});
            Waiter.Add(new Waiter() { id = 4, name = "Marina"});
            Waiter.Add(new Waiter() { id = 5, name = "Mario" });
        
        }
        public static WaiterDAL GetInstance()
        {
            return WaiterInstance;
        }
        public ObservableCollection<Waiter> GetAll()
        {
            return Waiter;
        }
        public void Add(Waiter waiter)
        {
            this.Waiter.Add(waiter);
        }
    }
}
