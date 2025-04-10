using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private TankView tankObject;


    void Start()
    {
        CreateTank();
    }

    public void CreateTank()
    {
        TankModel tankModel = new TankModel(10, 35);
        TankController tankController = new TankController(tankModel, tankObject);
    }
}
