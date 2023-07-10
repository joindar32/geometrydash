using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Square")) // Проверяем тег объекта, с которым столкнулся игрок
        {
            transform.position = Vector3.zero; // Перемещаем игрока в позицию (0, 0, 0)
        }
    }
}
