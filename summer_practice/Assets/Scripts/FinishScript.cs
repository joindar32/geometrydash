using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish")) // ��������� ��� �������, � ������� ���������� �����
        {
            SceneManager.LoadScene(1);
        }
    }
    
}
