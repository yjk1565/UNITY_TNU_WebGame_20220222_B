using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GG
{ 
    public class WeaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DataWeapon dataWeapon;
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
                print("生成武器");
                timer = 0;
            }
        }
    }
    
    
}
