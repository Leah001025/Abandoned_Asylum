# Abandonded_Asylum
C# + 유니티 공포게임

## 🖥️ 프로젝트 소개
버려진 정신병원을 컨셉으로 제작한 공포게임의 시작입니다.
<br>

## 🕰️ 개발 기간
* 24.02.20 ~ 24.02.22

## 🧑‍🤝‍🧑 제작자
 - 진보경

## ⚙️ 에디터 버전
 - 2022.3.22f1

## 📌 주요 기능
#### 시작화면
![image](https://github.com/Leah001025/Abandoned_Asylum/assets/97003364/c043d496-fd5c-4b4a-8ac4-8d4eac12f27b)
 - 'Start Button' 과 로딩씬 연결
 - 씬이 재생중에는 오디오 Loop 기능 활
#### 로딩화면
![image](https://github.com/Leah001025/Abandoned_Asylum/assets/97003364/3dab1690-12b6-4003-b750-ed249e3e8670)
 - Asynchronous화 하여 게임화면에선 로딩에 문제가 없게 만듦
 - Progress Bar 를 이용하여 시간에 따라 Bar 이동하게 만듦
#### 게임화면
![image](https://github.com/Leah001025/Abandoned_Asylum/assets/97003364/10042cf0-7bf0-43ca-b782-92b8faabc5be)
 - 배경음악 및 발소리 구현
 - 왼쪽 Gate House의 입구로 들어갈 시, Trigger Event 실행


![image](https://github.com/Leah001025/Abandoned_Asylum/assets/97003364/c0235001-c26a-4abe-96e7-bb70adc08c10)
- 해당 부분과 Tag가 Player인 오브젝트와 부딪힐때 특정위치에 Ghost 이미지 생성과 오디오 재생.
- 1회성 이벤트 이므로 재생 후 Destroy 함수를 통해 다시 재생되지 않게 파괴함.

## 🎨 사용한 에셋
 - https://assetstore.unity.com/packages/3d/environments/urban/abandoned-asylum-49137
 - https://assetstore.unity.com/packages/tools/audio/surfacesound-lite-sound-effects-system-for-surface-interaction-233868
 - https://assetstore.unity.com/packages/audio/sound-fx/horror-elements-112021
