using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    private AudioSource audisource;
    private void Start()
    {
        audisource = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Square")) // ��������� ��� �������, � ������� ���������� �����
        {
            audisource.Play();
            transform.position = Vector3.zero; // ���������� ������ � ������� (0, 0, 0)
        }
    }
}
