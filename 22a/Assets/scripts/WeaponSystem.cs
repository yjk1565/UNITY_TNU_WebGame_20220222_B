using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GG
{ 
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;
        [SerializeField, Header("�Z���R���ɶ�")]
        private float destoryWeaponTime = 3.5f;
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

        private void Start()
        {
            Physics2D.IgnoreLayerCollision(3, 6);   // ���a �P �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 6);   // �Z�� �P �Z�� ���I��
            Physics2D.IgnoreLayerCollision(6, 7);   // �Z�� �P ��� ���I��
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
                //print("�ͦ��Z��");
                //�H���� = �H��.�d��(�̤p�ȡA�̤j��) - ��Ƥ��]�t�̤j��
                int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);
                //�y��
                Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];
                //Quaternion �|�줸:�������׸�T����
                //Quaternion.identity �s�ר�(0�A0�A0)
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);
                //�Ȧs�Z��.���o����<����>().�K�[���O (��V * �t��)
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speed);

                timer = 0;

                Destroy(temp, destoryWeaponTime);

                temp.GetComponent<Weapon>().attack = dataWeapon.attack;
            }
        }
    }
    
    
}
