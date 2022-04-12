using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GG
{

    //�@�αN�}��������ܦ������x�s Project


    [CreateAssetMenu(menuName = "GG/Data Weapon", fileName = "Data Wrapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 5000)]
        public float speed = 500;
        [Header("�����O"), Range(0, 100)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(0, 10)]
        public float countStart = 1;
        [Header("�̤j�ƶq"), Range(0, 20)]
        public float countMax = 3;
        [Header("���j�ɶ�"), Range(0, 5)]
        public float interval = 3.5f;

        // �������[] �}�C - ��Ƶ��c
        // �@��:�x�s�h���ۦP���������
        [Header("�ͦ���m")]
        public Vector3[] v3SpawnPoint;
        [Header("�Z���w�s��")]
        public GameObject goWeapon;
        public Vector3 v3Direction;
    }
}
