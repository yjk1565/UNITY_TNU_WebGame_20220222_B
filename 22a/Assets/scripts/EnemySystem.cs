using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GG
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;
        [SerializeField, Header("���a����W��")]
        private string namePlayer = "kni";

        private Transform traPlayer;

        float a = 0;
        float b = 1000;
        private void Awake()
        {
            // ���a�ܧ� =�C������.�M��(����W��) ���ܧ�
            traPlayer = GameObject.Find(namePlayer).transform;

            /** // �ƾ�.����(A�AB�A�ʤ���)
            float result = Mathf.Lerp(0, 100, 0.5f);
            print("0 �P 100 �� 0.5 ���ӵ��G :" + result);
            */
        }

        
        private void Update()
        {
            /**
            a = Mathf.Lerp(a, b, 0.5f);
            print("���յ��G:" + a);
            */
            MoveToPlayer();
        }

        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

            float y = transform.position.x > traPlayer.position.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
        }
    }
}