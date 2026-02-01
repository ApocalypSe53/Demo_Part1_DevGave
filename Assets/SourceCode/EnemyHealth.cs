using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab; // Kéo Prefab vụ nổ vào đây

    // Hàm này tự động chạy khi có vật thể (như viên đạn) bay vào vùng Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Tạm thời cứ chạm là chết (1 hit)
        Die();
    }

    private void Die()
    {
        // 1. Tạo hiệu ứng nổ tại vị trí kẻ thù
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation); // [cite: 1136]

            Destroy(explosion, 1.5f);
        }

        // 2. Xóa sổ kẻ thù khỏi game
        Destroy(gameObject);
    }
}