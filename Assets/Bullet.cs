using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed; // Tốc độ bay

    void Update()
    {
        // 1. Lấy vị trí hiện tại
        var newPosition = transform.position;

        // 2. Tăng giá trị Y để bay lên trên
        newPosition.y += Time.deltaTime * flySpeed; // [cite: 664]

        // 3. Cập nhật lại vị trí
        transform.position = newPosition; // [cite: 665]
    }
}