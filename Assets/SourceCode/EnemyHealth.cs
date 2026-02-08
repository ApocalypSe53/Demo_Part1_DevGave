using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 3; // Máu tối đa (3 viên đạn mới chết)
    private int currentHealth;

    public GameObject explosionPrefab;

    void Start()
    {
        currentHealth = maxHealth; // Lúc đầu đầy máu
    }

    // Hàm này để nhận sát thương từ bên ngoài (từ đạn)
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Hàm cũ của bạn
    private void Die()
    {
        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }
        Destroy(gameObject);
    }

    // Xóa hàm OnTriggerEnter cũ đi, vì giờ va chạm sẽ do Đạn xử lý
}