using UnityEngine;

public class MyPlayerShooting : MonoBehaviour
{
    float spacing = 0.15f;
    public GameObject bulletPrefab;
    public float shootingInterval = 0.1f; // Thời gian giãn cách giữa 2 viên đạn [cite: 876]
    private float lastBulletTime;

    void Update()
    {
        // Đổi thành GetMouseButton (giữ chuột) thay vì Down (nhấn 1 cái)
        if (Input.GetMouseButton(0)) // [cite: 887]
        {
            // Kiểm tra thời gian để không bắn quá nhanh
            if (Time.time - lastBulletTime > shootingInterval) // [cite: 889]
            {
                ShootBullet();
                lastBulletTime = Time.time; // [cite: 896]
            }
        }
    }

    void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation); // [cite: 902]
        Vector3 leftPos = transform.position;
        leftPos.x -= spacing; // Trừ bớt trục X để sang trái
        Instantiate(bulletPrefab, leftPos, transform.rotation);

        // 3. Viên PHẢI (Lấy vị trí gốc, dịch sang phải một chút)
        Vector3 rightPos = transform.position;
        rightPos.x += spacing; // Cộng thêm trục X để sang phải
        Instantiate(bulletPrefab, rightPos, transform.rotation);
    }
}