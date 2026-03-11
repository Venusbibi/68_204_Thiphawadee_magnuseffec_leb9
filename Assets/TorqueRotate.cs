using UnityEngine;


public class TorqueRotation : MonoBehaviour

{

    public Vector3 torque = new Vector3(0, 1f, 0);

    private Rigidbody rb;

    void Start() => rb = GetComponent<Rigidbody>();

    void FixedUpdate()

    {

        rb.AddTorque(torque, ForceMode.VelocityChange);

    }

}

