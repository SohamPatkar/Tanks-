using UnityEngine;
using UnityEngine.UI;

public class TankSelectionScript : MonoBehaviour
{
    [SerializeField] private TankSpawner tankSpawner;

    public void BlueTank()
    {
        tankSpawner.CreateTank(TankTypes.BLUETANK);
        CloseGameObject();
    }

    public void GreenTank()
    {
        tankSpawner.CreateTank(TankTypes.GREENTANK);
        CloseGameObject();
    }

    public void RedTank()
    {
        tankSpawner.CreateTank(TankTypes.REDTANK);
        CloseGameObject();
    }

    public void CloseGameObject()
    {
       this.gameObject.SetActive(false);
    }
}
