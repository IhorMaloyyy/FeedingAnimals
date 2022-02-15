using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 24;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
    }
}
