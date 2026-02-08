using UnityEngine;

public class MyPlayerShooting : MonoBehaviour
{
    [Header("Bullet Settings")]
    public GameObject bulletPrefab;
    public float shootingInterval = 0.15f; // Giãn cách đạn (tăng lên xíu cho đỡ lag)
    public float spacing = 0.4f;           // Khoảng cách giữa 3 viên
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0); // Vị trí xuất phát từ mũi

    private float lastBulletTime;

    void Update()
    {
        // Hàm này bắt cả Nhấn (Click) và Giữ (Hold)
        if (Input.GetMouseButton(0))
        {
            // Kiểm tra: Đã nghỉ đủ lâu chưa?
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootTripleBullets();
                lastBulletTime = Time.time;
            }
        }
    }

    void ShootTripleBullets()
    {
        // 1. Tính toán vị trí gốc (Mũi máy bay) 1 lần thôi cho đỡ tốn CPU
        Vector3 centerPos = transform.position + bulletOffset;

        // 2. Bắn viên GIỮA
        Instantiate(bulletPrefab, centerPos, transform.rotation);

        //// 3. Bắn viên TRÁI (Lấy tâm dịch sang trái)
        //Vector3 leftPos = centerPos;
        //leftPos.x -= spacing;
        //Instantiate(bulletPrefab, leftPos, transform.rotation);

        //// 4. Bắn viên PHẢI (Lấy tâm dịch sang phải)
        //Vector3 rightPos = centerPos;
        //rightPos.x += spacing;
        //Instantiate(bulletPrefab, rightPos, transform.rotation);
    }
}