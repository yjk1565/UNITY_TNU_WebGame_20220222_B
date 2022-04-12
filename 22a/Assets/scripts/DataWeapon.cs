using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GG
{

    //作用將腳本的資料變成物件儲存 Project


    [CreateAssetMenu(menuName = "GG/Data Weapon", fileName = "Data Wrapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("飛行速度"), Range(0, 5000)]
        public float speed = 500;
        [Header("攻擊力"), Range(0, 100)]
        public float attack = 10;
        [Header("起始數量"), Range(0, 10)]
        public float countStart = 1;
        [Header("最大數量"), Range(0, 20)]
        public float countMax = 3;
        [Header("間隔時間"), Range(0, 5)]
        public float interval = 3.5f;

        // 資料類型[] 陣列 - 資料結構
        // 作用:儲存多筆相同類型的資料
        [Header("生成位置")]
        public Vector3[] v3SpawnPoint;
        [Header("武器預製物")]
        public GameObject goWeapon;
        public Vector3 v3Direction;
    }
}
