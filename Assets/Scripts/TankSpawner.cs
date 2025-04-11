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

    public List<Tank> tanks;    

    [SerializeField] private TankView tankObject;


    void Start()
    {
        CreateTank();
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel(tanks[0].movementSpeed, tanks[0].rotationSpeed, tanks[0].tankType, tanks[0].tankColor);
        TankController tankController = new TankController(tankModel, tankObject);
    }
}
