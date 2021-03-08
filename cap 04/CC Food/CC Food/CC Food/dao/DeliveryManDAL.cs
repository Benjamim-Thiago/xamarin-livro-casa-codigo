using CC_Food.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CC_Food.dao
{
    class DeliveryManDAL
    {
        private ObservableCollection<DeliveryMan> DeliveryMen = new ObservableCollection<DeliveryMan>();
        private static DeliveryManDAL DeliveryManInstance = new DeliveryManDAL();

        private DeliveryManDAL()
        {
            DeliveryMen.Add(new DeliveryMan() { id = 1, name = "Januario", phoneNumber = "(86) 99875-2222" });
            DeliveryMen.Add(new DeliveryMan() { id = 2, name = "Nonato", phoneNumber = "(86) 98878-2442" });
            DeliveryMen.Add(new DeliveryMan() { id = 3, name = "Fulano", phoneNumber = "(86) 98135-2277" });
            DeliveryMen.Add(new DeliveryMan() { id = 4, name = "Beltrano", phoneNumber = "(86) 98835-2277" });
            DeliveryMen.Add(new DeliveryMan() { id = 5, name = "Mario", phoneNumber = "(86) 98122-2277" });
            DeliveryMen.Add(new DeliveryMan() { id = 6, name = "Luide", phoneNumber = "(86) 98124-2477" });
            DeliveryMen.Add(new DeliveryMan() { id = 7, name = "Kenpachi", phoneNumber = "(86) 98222-2210" });
            DeliveryMen.Add(new DeliveryMan() { id = 8, name = "Godines", phoneNumber = "(86) 98222-1110" });
            DeliveryMen.Add(new DeliveryMan() { id = 9, name = "Lameque", phoneNumber = "(86) 98222-0000" });
            DeliveryMen.Add(new DeliveryMan() { id = 10, name = "Mateus", phoneNumber = "(86) 98442-2210" });
            DeliveryMen.Add(new DeliveryMan() { id = 11, name = "Melque", phoneNumber = "(86) 98222-2210" });
            DeliveryMen.Add(new DeliveryMan() { id = 12, name = "Miqueias", phoneNumber = "(86) 98222-2210" });
            DeliveryMen.Add(new DeliveryMan() { id = 13, name = "Davi", phoneNumber = "(86) 98222-2210" });
            DeliveryMen.Add(new DeliveryMan() { id = 14, name = "Leonardo", phoneNumber = "(86) 98222-2210" });
        }
        public static DeliveryManDAL GetInstance()
        {
            return DeliveryManInstance;
        }
        public ObservableCollection<DeliveryMan> GetAll()
        {
            return DeliveryMen;
        }
        public void Add(DeliveryMan deliveryMan)
        {
            this.DeliveryMen.Add(deliveryMan);
        }
    }
}
