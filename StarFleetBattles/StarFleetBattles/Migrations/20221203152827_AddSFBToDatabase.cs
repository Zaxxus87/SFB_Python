using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarFleetBattles.Migrations
{
    /// <inheritdoc />
    public partial class AddSFBToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnergyAllocationForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarpEnginePower = table.Column<int>(type: "int", nullable: false),
                    ImpulseEnginePower = table.Column<int>(type: "int", nullable: false),
                    ReactorPower = table.Column<int>(type: "int", nullable: false),
                    TotalPowerAvailable = table.Column<int>(type: "int", nullable: false),
                    BatteryPowerAvaiable = table.Column<int>(type: "int", nullable: false),
                    BatteryCapacityDischarged = table.Column<int>(type: "int", nullable: false),
                    LifeSupport = table.Column<int>(type: "int", nullable: false),
                    ActiveFireControl = table.Column<int>(type: "int", nullable: false),
                    ChargePhaserCapacitors = table.Column<int>(type: "int", nullable: false),
                    HeavyWeaponsA = table.Column<int>(type: "int", nullable: false),
                    HeavyWeaponsB = table.Column<int>(type: "int", nullable: false),
                    HeavyWeaponsC = table.Column<int>(type: "int", nullable: false),
                    HeavyWeaponsD = table.Column<int>(type: "int", nullable: false),
                    HeavyWeaponsE = table.Column<int>(type: "int", nullable: false),
                    HeavyWeaponsF = table.Column<int>(type: "int", nullable: false),
                    HeavyWeaponsG = table.Column<int>(type: "int", nullable: false),
                    HeavyWeaponsH = table.Column<int>(type: "int", nullable: false),
                    ActivateShields = table.Column<int>(type: "int", nullable: false),
                    GeneralReinforcement = table.Column<int>(type: "int", nullable: false),
                    SpecificReinforcement1 = table.Column<int>(name: "SpecificReinforcement_1", type: "int", nullable: false),
                    SpecificReinforcement2 = table.Column<int>(name: "SpecificReinforcement_2", type: "int", nullable: false),
                    SpecificReinforcement3 = table.Column<int>(name: "SpecificReinforcement_3", type: "int", nullable: false),
                    SpecificReinforcement4 = table.Column<int>(name: "SpecificReinforcement_4", type: "int", nullable: false),
                    SpecificReinforcement5 = table.Column<int>(name: "SpecificReinforcement_5", type: "int", nullable: false),
                    SpecificReinforcement6 = table.Column<int>(name: "SpecificReinforcement_6", type: "int", nullable: false),
                    EnergyForMovement = table.Column<int>(type: "int", nullable: false),
                    HET = table.Column<int>(type: "int", nullable: false),
                    EMBraking = table.Column<int>(name: "EM_Braking", type: "int", nullable: false),
                    DamageControl = table.Column<int>(type: "int", nullable: false),
                    RechargeBatteriesReserveWarp = table.Column<int>(name: "RechargeBatteries_ReserveWarp", type: "int", nullable: false),
                    TractorNegativeTractor = table.Column<int>(name: "Tractor_NegativeTractor", type: "int", nullable: false),
                    Transporters = table.Column<int>(type: "int", nullable: false),
                    ECM = table.Column<int>(type: "int", nullable: false),
                    ECCM = table.Column<int>(type: "int", nullable: false),
                    Labs = table.Column<int>(type: "int", nullable: false),
                    ChargeWWSS = table.Column<int>(name: "ChargeWW_SS", type: "int", nullable: false),
                    CloakingDevice = table.Column<int>(type: "int", nullable: false),
                    PowerUsed = table.Column<int>(type: "int", nullable: false),
                    BatteryPowerUsed = table.Column<int>(type: "int", nullable: false),
                    PhaserCapacitorsCharged = table.Column<int>(type: "int", nullable: false),
                    PhaserCapacitorsUsed = table.Column<int>(type: "int", nullable: false),
                    MovementPlotNotes = table.Column<string>(name: "MovementPlot_Notes", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyAllocationForms", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyAllocationForms");
        }
    }
}
