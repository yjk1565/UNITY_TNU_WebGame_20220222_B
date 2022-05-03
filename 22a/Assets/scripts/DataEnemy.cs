using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GG 
{



    [CreateAssetMenu(menuName = "GG/Data Enemy", fileName = "Data Enemy", order =2)]
    public class DataEnemy : ScriptableObject
    {
        [Header("���ʳt��"), Range(0, 50)]
        public float speed = 30;
        [Header("�����O"), Range(0, 500)]
        public float attack = 10;
        [Header("�����N�o"), Range(0, 7)]
        public float cd = 3.2f;
        [Header("��q"), Range(0, 5000)]
        public float hp = 100;
        [Header("�����g��Ⱦ��v"), Range(0, 1)]
        public float expDropProbability = 0.8f;
        [Header("�����g�������")]
        public TypeExp typeExp;
        [Header("����Z��"), Range(0, 10)]
        public float stopDistance = 1.5f;
    }



    public enum TypeExp
    {
        small, middle, big
    }
}
