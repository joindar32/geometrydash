using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike")) // ��������� ��� �������, � ������� ���������� �����
        {
            transform.position = Vector3.zero; // ���������� ������ � ������� (0, 0, 0)
        }
    }
}
