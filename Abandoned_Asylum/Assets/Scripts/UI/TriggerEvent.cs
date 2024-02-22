//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class TriggerEvent : MonoBehaviour
//{
//    public AudioSource audioSource; // 오디오 소스를 담을 변수
//    public SpriteRenderer imageRenderer; // 이미지 렌더러를 담을 변수

//    void Start()
//    {
//        audioSource = GetComponent<AudioSource>(); // 오디오소스 컴포넌트
//        imageRenderer = GetComponent<SpriteRenderer>(); // 이미지렌더러 컴포넌트
//    }

//    // 플레이어가 박스 콜라이더랑 부딪혔을때 event 발생 후, Destroy
//    void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player")) // 태그가 Player 인지 확인
//        {
//            audioSource.Play();
//            imageRenderer.enabled = true;

//            Destroy(gameObject); // 1회성 이벤트 이므로 파괴
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public AudioSource audioSource; // 오디오 소스를 담을 변수
    public SpriteRenderer imageRenderer; // 이미지 렌더러를 담을 변수

    // 플레이어가 박스 콜라이더랑 부딪혔을때 event 발생 후, Destroy
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 태그가 Player 인지 확인
        {
            StartCoroutine(GhostEvent());
        }
    }

    IEnumerator GhostEvent()
    {
        // 오디오 재생
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // 이미지 활성화
        if (imageRenderer != null)
        {
            imageRenderer.enabled = true;
        }

        // 10초 기다린 후에 이미지를 비활성화하고 오브젝트를 파괴합니다.
        yield return new WaitForSeconds(5f);

        // 이미지 비활성화
        if (imageRenderer != null)
        {
            imageRenderer.enabled = false;
        }

        // 객체 파괴
        Destroy(gameObject);
    }
}

