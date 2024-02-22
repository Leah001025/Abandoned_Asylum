//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TriggerEvent : MonoBehaviour
//{
//    public AudioSource audioSource; // ����� �ҽ��� ���� ����
//    public SpriteRenderer imageRenderer; // �̹��� �������� ���� ����

//    void Start()
//    {
//        audioSource = GetComponent<AudioSource>(); // ������ҽ� ������Ʈ
//        imageRenderer = GetComponent<SpriteRenderer>(); // �̹��������� ������Ʈ
//    }

//    // �÷��̾ �ڽ� �ݶ��̴��� �ε������� event �߻� ��, Destroy
//    void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player")) // �±װ� Player ���� Ȯ��
//        {
//            audioSource.Play();
//            imageRenderer.enabled = true;

//            Destroy(gameObject); // 1ȸ�� �̺�Ʈ �̹Ƿ� �ı�
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public AudioSource audioSource; // ����� �ҽ��� ���� ����
    public SpriteRenderer imageRenderer; // �̹��� �������� ���� ����

    // �÷��̾ �ڽ� �ݶ��̴��� �ε������� event �߻� ��, Destroy
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // �±װ� Player ���� Ȯ��
        {
            StartCoroutine(GhostEvent());
        }
    }

    IEnumerator GhostEvent()
    {
        // ����� ���
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // �̹��� Ȱ��ȭ
        if (imageRenderer != null)
        {
            imageRenderer.enabled = true;
        }

        // 10�� ��ٸ� �Ŀ� �̹����� ��Ȱ��ȭ�ϰ� ������Ʈ�� �ı��մϴ�.
        yield return new WaitForSeconds(5f);

        // �̹��� ��Ȱ��ȭ
        if (imageRenderer != null)
        {
            imageRenderer.enabled = false;
        }

        // ��ü �ı�
        Destroy(gameObject);
    }
}

