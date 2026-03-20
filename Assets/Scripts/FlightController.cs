// FlightController.cs
// CENG 454 – HW1: Sky-High Prototype
// Author:Egemen Çalışkan | Student ID: 220444035

using UnityEngine;

public class FlightController : MonoBehaviour
{
    [SerializeField] private float pitchSpeed = 45f;   // degrees/second
    [SerializeField] private float yawSpeed   = 45f;   // degrees/second
    [SerializeField] private float rollSpeed  = 45f;   // degrees/second
    [SerializeField] private float thrustSpeed = 5f;    // units/second

    private Rigidbody rb;

    void Start()
    {
        // TODO: Will be implemented in next iteration
    }

    void Update()
    {
        HandleRotation();
        HandleThrust();
    }

    private void HandleRotation()
    {
        // TODO: Will be implemented in next iteration
    }

    private void HandleThrust()
    {
        // TODO: Will be implemented in next iteration
    }
}
