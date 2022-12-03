using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarFleetBattles.Models
{
    public class EnergyAllocationForm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Player { get; set; }

        public int WarpEnginePower { get; set; }
        public int ImpulseEnginePower { get; set; }
        public int ReactorPower { get; set; }
        public int TotalPowerAvailable { get; set; }
        public int BatteryPowerAvaiable { get; set; }
        public int BatteryCapacityDischarged { get; set; }
        public int LifeSupport { get; set; }
        public int ActiveFireControl { get; set; }
        public int ChargePhaserCapacitors { get; set; }
        public int HeavyWeaponsA { get; set; }
        public int HeavyWeaponsB { get; set; }
        public int HeavyWeaponsC { get; set; }
        public int HeavyWeaponsD { get; set; }
        public int HeavyWeaponsE { get; set; }
        public int HeavyWeaponsF { get; set; }
        public int HeavyWeaponsG { get; set; }
        public int HeavyWeaponsH { get; set; }
        public int ActivateShields { get; set; }
        public int GeneralReinforcement { get; set; }
        public int SpecificReinforcement_1 { get; set; }
        public int SpecificReinforcement_2 { get; set; }
        public int SpecificReinforcement_3 { get; set; }
        public int SpecificReinforcement_4 { get; set; }
        public int SpecificReinforcement_5 { get; set; }
        public int SpecificReinforcement_6 { get; set; }
        public int EnergyForMovement { get; set; }
        public int HET { get; set; }
        public int EM_Braking { get; set; }
        public int DamageControl { get; set; }
        public int RechargeBatteries_ReserveWarp { get; set; }
        public int Tractor_NegativeTractor { get; set; }
        public int Transporters { get; set; }
        public int ECM { get; set; }
        public int ECCM { get; set; }
        public int Labs { get; set; }
        public int ChargeWW_SS { get; set; }
        public int CloakingDevice { get; set; }

        public int PowerUsed { get; set; }
        public int BatteryPowerUsed { get; set; }
        public int PhaserCapacitorsCharged { get; set; }
        public int PhaserCapacitorsUsed { get; set; }
        public string MovementPlot_Notes { get; set; }


    }
}
