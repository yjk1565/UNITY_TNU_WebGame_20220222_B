
using UnityEngine;

namespace UI
{
    public class TopDowncontroller : MonoBehaviour
    {
        #region 資料:保存系統需要的基本資料，例如:移動速度
        private float speed = 10.5f;
        private string parameterRun = "跑步";
        private string parameterDead = "死亡";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 事件:程式入口 (Unity)，提供開發者驅動系統的窗口
        //喚醒事件:播放遊戲後執行一次
        private void Awake()
        {
            //crtl +shift +C
            //print("喚醒事件");

            // 欄位 指定 取得元件<元件名稱>()
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //更新事件:撥放遊戲後以每秒約 60 次執行，60 FPS (Frame Per second)
        private void Update()
        {
            print("Update 事件內");
        }
        #endregion

        #region 方法:較複雜功能 (陳述式
        #endregion
    }

}