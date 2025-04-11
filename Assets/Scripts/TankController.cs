using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    private Rigidbody rb;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate(_tankView.gameObject).GetComponent<TankView>();
        rb = tankView.GetRigidBody();
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        tankView.SetColor(tankModel.tankColor);
    }

    public void Movement(float movement)
    {
        rb.velocity = tankView.transform.forward * movement * tankModel.movementSpeed;
    }

    public void Rotation(float rotation)
    {
        Vector3 rotationVector = new Vector3(0f, rotation * tankModel.rotationSpeed, 0f);
        Quaternion rotationQuaternion = Quaternion.Euler(rotationVector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * rotationQuaternion);
    }
}
