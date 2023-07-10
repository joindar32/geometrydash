using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike")) // Проверяем тег объекта, с которым столкнулся игрок
        {
            transform.position = Vector3.zero; // Перемещаем игрока в позицию (0, 0, 0)
        }
    }
}
