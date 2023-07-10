using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Square")) // ��������� ��� �������, � ������� ���������� �����
        {
            transform.position = Vector3.zero; // ���������� ������ � ������� (0, 0, 0)
        }
    }
}
