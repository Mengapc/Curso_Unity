using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] int xValue, yValue, zValue = 0;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
