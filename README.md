# CITY LUN!
도시 곳곳을 점프하는 ONlY UP! 스타일의 항아리류 게임을 기획했습니다.
게임은 3인칭 시점으로 진행됩니다.
(완전히 완성하지는 못했지만, 추후에 미처 도전하지 못했던 몇몇 도전기능까지도 추가해볼 계획입니다)

* 기본 기능구현 (이동, 점프, 체력바 UI 등)
![image](https://github.com/user-attachments/assets/060d0ce1-7787-46a3-8fa1-eac4fc0702fa)

* 오브젝트 조사, 인벤토리 구현: 아이템은 ScriptableObject로 관리
![image](https://github.com/user-attachments/assets/1398cc6b-31f0-49d1-87e2-12196d38c964)
![image](https://github.com/user-attachments/assets/a050377d-66ee-434a-96fb-c17a4cde77d5)

* 아이템 사용
  1) 햄버거: HP와 스태미나 상승시켜줌
 ![image](https://github.com/user-attachments/assets/32af919a-09c7-4f88-bce6-4004e9fe3ddb)

  2) 스피드부스트: 스피드를 순간 상승시켜줌(시간 지나면 원상복귀)
![image](https://github.com/user-attachments/assets/d6815c81-3a45-44df-93b5-541e3606ce98)

* 점프대: 튀어오를 때 애니메이션까지 구현
* 엘리베이터: 위, 아래로 이동(PointA, PointB에 따라 여러 방향으로 이동하는 엘리베이터 구현 가능)
![image](https://github.com/user-attachments/assets/97673c9b-76ad-4ccc-b7b9-d93e63a65f10)

* 오일 트랩: 닿으면 hp감소 및 Damageidicator 붉은색으로 발동
  ![image](https://github.com/user-attachments/assets/491e5d29-994b-4401-9fb5-a344f8e9689d)
