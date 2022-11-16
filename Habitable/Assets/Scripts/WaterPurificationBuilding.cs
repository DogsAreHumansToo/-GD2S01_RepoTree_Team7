using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPurificationBuilding : BuildingParentClass
{
    void Start()
    {
        TypeAClass resourceC = new TypeAClass();
        setResourceNeeded(resourceC);
        ActiveBuildingType activeType = new ActiveBuildingType();
        setBuildingType(activeType);
    }
}
