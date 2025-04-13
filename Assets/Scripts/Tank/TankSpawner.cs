using System;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [Serializable]
    public class Tank
    {
        public float rotationSpeed;
        public float movementSpeed;

        public TankTypes tankType;

        public Material tankColor;
    }

    public Tank[] tanks;    

    [SerializeField] private TankView tankObject;

    public void CreateTank(TankTypes tanktype)
    {
        //spawning a particular tank
        if (tanktype == TankTypes.GREENTANK)
        {
            TankModel tankModel = new TankModel(tanks[0].movementSpeed, tanks[0].rotationSpeed, tanks[0].tankType, tanks[0].tankColor);
            TankController tankController = new TankController(tankModel, tankObject);
        }
        else if (tanktype == TankTypes.BLUETANK)
        {
            TankModel tankModel = new TankModel(tanks[1].movementSpeed, tanks[1].rotationSpeed, tanks[1].tankType, tanks[1].tankColor);
            TankController tankController = new TankController(tankModel, tankObject);
        }
        else if (tanktype == TankTypes.REDTANK)
        {
            TankModel tankModel = new TankModel(tanks[2].movementSpeed, tanks[2].rotationSpeed, tanks[2].tankType, tanks[2].tankColor);
            TankController tankController = new TankController(tankModel, tankObject);
        }
    }
}
