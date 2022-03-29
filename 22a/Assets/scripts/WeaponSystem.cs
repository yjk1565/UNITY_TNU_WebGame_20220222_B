using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GG
{ 
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;
        /// <summary>
        /// �p�ɾ�
        /// </summary>
        private float timer;



        //ø�s�ϥܨƥ� ODG
        private void OnDrawGizmos()
        {
            // 1. �M�w�ϥ��C��
            // Color(���A��A�šA�z����) - 0 ~ 1
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            // 2. ø�s�ϥ�
            // �ϥ�.ø�s�y��(�����I�A�b�|)
            // ���o�}�C��ƻy�k:�}�C��ƦW��[���ޭ�]

            //
            for (int i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
            }
        }




        private void Update()
        {
            SpawnWeapon();
        }
        private void SpawnWeapon()
        {
            // Time.deltaTime �@�Ӽv�檺�ɶ�
            timer += Time.deltaTime;

            //print("�g�L���ɶ�:" + timer);

            // �p�G �p�ɾ� �j�󵥩� ����ɶ� �N�ͦ� �Z��

            if (timer >= dataWeapon.interval)
            {
                print("�ͦ��Z��");
                timer = 0;
            }
        }
    }
    
    
}
