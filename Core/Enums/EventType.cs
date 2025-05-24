using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBaseModel.Core.Enums
{
    internal enum EventType
    {
        MoneyChanged,
        BossScreaming,
        DispatcherSayGoGarage,
        DispatcherSayGoRepair,

        WorkerGoToGarage,

        LightCarGoToOrder,
        TowCarGoToOrder,
        WorkerComeBackFromLightOrder,
        WorkerComeBackFromTowOrder,
        TowCarComeBackToGarage,
        WorkerGoToRepairShop,
        WorkerGoBackToHouseFromGarage,
        WorkerGoBackToHouseFromRepair,
        WorkerGoBackToHouse,

        ClientComeToAutoBase,
        CarClientComeToAutoBase,
        CarClientGoToRepair,
        ClientGoToGarage,
        
        ClientRentCar,
        ClientBackCar,
        ClientLeaveWithRepairedCar,
        ClientLeaveFromAutoBase,
        ClientLeaveFromAutoBaseSimple
    }
}
