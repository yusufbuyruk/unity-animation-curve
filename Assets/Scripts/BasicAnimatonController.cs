using UnityEngine;
/// <summary>
/// Basic Animation Controller Class
/// </summary>
public class BasicAnimatonController : MonoBehaviour
{
    // Move // Direction Curve
    // Move // Scale
    public AnimationCurve directionCurve;
    public float scale = 1f;

    // Rotation // Rotation Speed
    public float rotationSpeed = 90f;

    void Update()
    {
        // Basic Rotation Function
        // local rotation // transform.up
        // global rotation // Vector3.up
        transform.Rotate(transform.up, rotationSpeed * Time.deltaTime);

        // Basic Move Function
        transform.position += directionCurve.Evaluate(Mathf.Repeat(Time.time, scale)) * scale * Time.deltaTime * transform.up;
    }
}
