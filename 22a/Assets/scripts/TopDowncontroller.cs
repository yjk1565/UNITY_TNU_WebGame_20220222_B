
using UnityEngine;

namespace UI
{
    public class TopDowncontroller : MonoBehaviour
    {
        #region 資料:保存系統需要的基本資料，例如:移動速度
        //SerializeField 序列化欄位:讓私人欄位顯示在屬性面板上
        //Header("標題") 標題
        //Range(最小值，最大值) 範圍限制
        [SerializeField, Header("移動速度"),Range(0, 100)]
        private float speed = 10.5f;
        private string parameterRun = "跑步";
        private string parameterDead = "死亡";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
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
            //print("Update 事件內");
            
            //呼叫語法:方法名稱(對應引數);
            GetInput();
            Move();
        }
        #endregion

        #region 方法:較複雜功能 (陳述式 演算法或程式區塊)

        // 方法 method 語法:
        private void GetInput()
        {
            // 使用靜態方法語法 static
            // 類別名稱.靜態方法名稱(對應引數):
            // float h = ****; - 區域變數;僅能在該結構 (大括號內) 存取
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            // 輸出訊息(訊息)  Crtl + Shift + C 儀錶板 (Console)
            //print("取得水平軸向值:" + h);
        }

        private void Move()
        {
            //使用非靜態屬性 non-static
            //欄位名稱.靜態屬性名稱 指定 值
            rig.velocity = new Vector2(h, v) * speed;
            //動畫控制器,設定布林值(參數名稱，布林值)
            //水平 不等於 零 或者 垂直 不等於 零
            ani.SetBool(parameterRun, h != 0 || v != 0);

            // 三元運算子語法
            // 布林值 ? 布林值 等於ture : 布林值 等於 false
            // 水平 >= 0 角度 0 否則 角度180
            // 變形元件.數位角 = 新 三角向量(X，Y，Z)
            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0) ;
        }
        #endregion
    }

}