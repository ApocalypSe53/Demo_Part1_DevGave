using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject explosionPrefab; // Kéo Prefab vụ nổ của Player vào đây

    // Hàm để xử lý khi Player chết
    public void Die()
    {
        // 1. Tạo hiệu ứng nổ (nếu có)
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }

        // 2. Hủy máy bay của người chơi
        Destroy(gameObject);

        // TODO: Sau này sẽ thêm code hiện bảng Game Over ở đây
    }
}