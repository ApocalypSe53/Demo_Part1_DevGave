using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    public float flySpeed = 2f;

    void Update()
    {
        // Bay xuống dưới (Vector3.down)
        transform.Translate(Vector3.down * flySpeed * Time.deltaTime);
    }
}
