using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faa.Contracts
{
	public enum ObstacleType
	{
		///<summary>agricultural equipment</summary>
AGEquipment,
///<summary></summary>
Arch,
///<summary>tethered; weather; other reconnaissance</summary>
Balloon,
///<summary>building</summary>
Bldg,
///<summary>latticework greater than 20' on building</summary>
BldgTwr,
///<summary></summary>
Bridge,
///<summary>transmission line span/wire/cable</summary>
Catenary,
///<summary>nuclear cooling tower</summary>
CoolingTower,
///<summary>permanent</summary>
CRANE,
///<summary>temporary</summary>
CRANE T,
///<summary>airport control tower</summary>
CTRL TWR,
///<summary></summary>
DAM,
///<summary></summary>
DOME,
///<summary></summary>
ELECTRICAL SYSTEM,
///<summary>silo; grain elevator</summary>
ELEVATOR,
///<summary></summary>
FENCE,
///<summary></summary>
GENERAL UTILITY,
///<summary></summary>
LIGHTHOUSE,
///<summary></summary>
MONUMENT,
///<summary>airport navigational aid</summary>
NAVAID,
///<summary>multiple close structures used for industrial purposes</summary>
PLANT,
///<summary>flag pole; light pole</summary>
POLE,
///<summary>multiple close structures used for purifying crude materials</summary>
REFINERY,
///<summary>oil rig</summary>
RIG,
///<summary></summary>
SIGN,
///<summary>steeple</summary>
SPIRE,
///<summary>smoke; industrial</summary>
STACK,
///<summary></summary>
STADIUM,
///<summary>transmission line tower; telephone pole</summary>
T-L TWR,
///<summary>water; fuel</summary>
TANK,
///<summary></summary>
TOWER,
///<summary></summary>
TRAMWAY,
///<summary></summary>
TREE,
///<summary></summary>
VEGETATION,
///<summary>wind turbine</summary>
WINDMILL,
	}

	/////// <summary>
	/////// <see href="https://nfdc.faa.gov/tod/public/TOD_ObstacleTypes.html"/>
	/////// </summary>
	////public class ObstacleTypes
	////{
	////    ///<summary>agricultural equipment</summary>
	////    public const string AG_EQUIP = "AG EQUIP";

	////    ///<summary></summary>
	////    public const string ARCH = "ARCH";

	////    ///<summary>tethered; weather; other reconnaissance</summary>
	////    public const string BALLOON = "BALLOON";

	////    ///<summary>building</summary>
	////    public const string BLDG = "BLDG";

	////    ///<summary>latticework greater than 20' on building</summary>
	////    public const string BLDG_TWR = "BLDG-TWR";

	////    ///<summary></summary>
	////    public const string BRIDGE = "BRIDGE";

	////    ///<summary>transmission line span/wire/cable</summary>
	////    public const string CATENARY = "CATENARY";

	////    ///<summary>nuclear cooling tower</summary>
	////    public const string COOL_TWR = "COOL TWR";

	////    ///<summary>permanent</summary>
	////    public const string CRANE = "CRANE";

	////    ///<summary>temporary</summary>
	////    public const string CRANE_T = "CRANE T";

	////    ///<summary>airport control tower</summary>
	////    public const string CTRL_TWR = "CTRL TWR";

	////    ///<summary></summary>
	////    public const string DAM = "DAM";

	////    ///<summary></summary>
	////    public const string DOME = "DOME";

	////    ///<summary></summary>
	////    public const string ELECTRICAL_SYSTEM = "ELECTRICAL SYSTEM";

	////    ///<summary>silo; grain elevator</summary>
	////    public const string ELEVATOR = "ELEVATOR";

	////    ///<summary></summary>
	////    public const string FENCE = "FENCE";

	////    ///<summary></summary>
	////    public const string GENERAL_UTILITY = "GENERAL UTILITY";

	////    ///<summary></summary>
	////    public const string LIGHTHOUSE = "LIGHTHOUSE";

	////    ///<summary></summary>
	////    public const string MONUMENT = "MONUMENT";

	////    ///<summary>airport navigational aid</summary>
	////    public const string NAVAID = "NAVAID";

	////    ///<summary>multiple close structures used for industrial purposes</summary>
	////    public const string PLANT = "PLANT";

	////    ///<summary>flag pole; light pole</summary>
	////    public const string POLE = "POLE";

	////    ///<summary>multiple close structures used for purifying crude materials</summary>
	////    public const string REFINERY = "REFINERY";

	////    ///<summary>oil rig</summary>
	////    public const string RIG = "RIG";

	////    ///<summary></summary>
	////    public const string SIGN = "SIGN";

	////    ///<summary>steeple</summary>
	////    public const string SPIRE = "SPIRE";

	////    ///<summary>smoke; industrial</summary>
	////    public const string STACK = "STACK";

	////    ///<summary></summary>
	////    public const string STADIUM = "STADIUM";

	////    ///<summary>transmission line tower; telephone pole</summary>
	////    public const string T_L_TWR = "T-L TWR";

	////    ///<summary>water; fuel</summary>
	////    public const string TANK = "TANK";

	////    ///<summary></summary>
	////    public const string TOWER = "TOWER";

	////    ///<summary></summary>
	////    public const string TRAMWAY = "TRAMWAY";

	////    ///<summary></summary>
	////    public const string TREE = "TREE";

	////    ///<summary></summary>
	////    public const string VEGETATION = "VEGETATION";

	////    ///<summary>wind turbine</summary>
	////    public const string WINDMILL = "WINDMILL";

	////}
}
