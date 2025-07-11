using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 50);
    }
}
