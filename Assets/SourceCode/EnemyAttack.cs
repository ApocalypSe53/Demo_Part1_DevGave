using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int damage = 10; // Sát thương gây ra khi đâm (ví dụ mất 1 máu)

    // Hàm này chạy khi kẻ thù đâm vào cái gì đó (Is Trigger)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem cái bị đâm có phải là Player không
        // Bằng cách tìm xem nó có script "PlayerHealth" không
        var playerHealth = collision.GetComponent<PlayerHealth>();

        if (playerHealth != null) // Nếu đúng là Player
        {
            // 1. Gây sát thương cho Player
            playerHealth.Die(); // Hoặc playerHealth.TakeDamage(damage); nếu bạn đã nâng cấp Player có nhiều máu

            // 2. Kẻ thù tự sát (gây 1000 sát thương cho chính mình)
            // Lệnh này gọi script EnemyHealth đang gắn trên chính con quái này
            var myHealth = GetComponent<EnemyHealth>();
            if (myHealth != null)
            {
                myHealth.TakeDamage(1000);
            }
        }
    }
}