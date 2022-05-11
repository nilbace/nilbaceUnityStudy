using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecircle : MonoBehaviour
{
    GameObject Player;
    float distance = 5f;
    [SerializeField]float radian = Mathf.PI;
    [SerializeField] float moveSpeed;
    void Start() 
    {
        Player = GameObject.Find("Player");
        
    }

    void Update() 
    {
        radian += Time.deltaTime * moveSpeed; //radian값을 시간에 따라 증가시켜줌
        Vector2 offset = new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)); //원점과 어떠한 방향으로 떨어져 있는가
        transform.position = Player.transform.position + distance * (Vector3)offset;         
        //돌아다닐 물체의 위치 = 플레이어의 위치 정보 + 거리 * offset의 방향        
    }
}
