using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GG
{ 
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;
        [SerializeField, Header("武器刪除時間")]
        private float destoryWeaponTime = 3.5f;
        /// <summary>
        /// 計時器
        /// </summary>
        private float timer;



        //繪製圖示事件 ODG
        private void OnDrawGizmos()
        {
            // 1. 決定圖示顏色
            // Color(紅，綠，藍，透明度) - 0 ~ 1
            Gizmos.color = new Color(1, 0, 0, 0.5f);
            // 2. 繪製圖示
            // 圖示.繪製球體(中心點，半徑)
            // 取得陣列資料語法:陣列資料名稱[索引值]

            //
            for (int i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
            }
        }

        private void Start()
        {
            Physics2D.IgnoreLayerCollision(3, 6);   // 玩家 與 武器 不碰撞
            Physics2D.IgnoreLayerCollision(6, 6);   // 武器 與 武器 不碰撞
            Physics2D.IgnoreLayerCollision(6, 7);   // 武器 與 牆壁 不碰撞
        }


        private void Update()
        {
            SpawnWeapon();
        }
        private void SpawnWeapon()
        {
            // Time.deltaTime 一個影格的時間
            timer += Time.deltaTime;

            //print("經過的時間:" + timer);

            // 如果 計時器 大於等於 間格時間 就生成 武器

            if (timer >= dataWeapon.interval)
            {
                //print("生成武器");
                //隨機值 = 隨機.範圍(最小值，最大值) - 整數不包含最大值
                int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);
                //座標
                Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];
                //Quaternion 四位元:紀錄角度資訊類型
                //Quaternion.identity 零度角(0，0，0)
                GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);
                //暫存武器.取得元件<鋼體>().添加推力 (方向 * 速度)
                temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speed);

                timer = 0;

                Destroy(temp, destoryWeaponTime);

                temp.GetComponent<Weapon>().attack = dataWeapon.attack;
            }
        }
    }
    
    
}
