using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;
    public int damage = 1; // Sát thương của đạn

    void Update()
    {
        // Code bay cũ giữ nguyên
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);
    }

    // Thêm hàm xử lý va chạm này
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Nếu đụng trúng cái gì đó có script EnemyHealth
        EnemyHealth enemy = collision.GetComponent<EnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage); // Gây sát thương
            Destroy(gameObject); // Đạn tự hủy
        }
    }
}