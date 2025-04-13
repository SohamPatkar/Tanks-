using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour
{
    private BulletController bulletController;

    private void Start()
    {
        bulletController.BulletSpeed(bulletController.GetFireTransform(), bulletController.GetFireSpeed());
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    public void SetTankController(BulletController controller)
    {
        bulletController = controller;
    }
}
