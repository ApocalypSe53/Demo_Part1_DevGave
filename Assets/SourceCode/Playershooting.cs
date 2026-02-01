using UnityEngine;

public class MyPlayerShooting : MonoBehaviour
{
    float spacing = 0.15f;
    public GameObject bulletPrefab;
    public float shootingInterval = 0.1f; // Thời gian giãn cách giữa 2 viên đạn
    private float lastBulletTime;
    public Vector3 bulletOffset = new Vector3(0, 1f, 0);

    void Update()
    {
        // Đổi thành GetMouseButton (giữ chuột) thay vì Down (nhấn 1 cái)
        if (Input.GetMouseButton(0)) // 
        {
            // Kiểm tra thời gian để không bắn quá nhanh
            if (Time.time - lastBulletTime > shootingInterval) // 
            {
                ShootBullet();
                lastBulletTime = Time.time; //
            }
        }
    }

    void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position + bulletOffset, transform.rotation); //
        Vector3 leftPos = transform.position + bulletOffset;
        leftPos.x -= spacing; // Trừ bớt trục X để sang trái
        Instantiate(bulletPrefab, leftPos, transform.rotation);

        // 3. Viên PHẢI (Lấy vị trí gốc, dịch sang phải một chút)
        Vector3 rightPos = transform.position + bulletOffset;
        rightPos.x += spacing; // Cộng thêm trục X để sang phải
        Instantiate(bulletPrefab, rightPos, transform.rotation);
    }
}