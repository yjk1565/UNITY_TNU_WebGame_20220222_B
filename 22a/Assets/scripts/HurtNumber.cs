using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GG
{


    public class HurtNumber : MonoBehaviour
    {
        private CanvasGroup group;

        private void Awake()
        {
            group = GetComponent<CanvasGroup>();

            StartCoroutine(Test());
        }

        // 協同程序:控制系統等待、停止
        // 1.引用 System.Collections
        // 2.定義協同程序方法傳回類型 IEnumerator
        // 3.使用 yield return new WaitForSeconds
        // 4.使用啟動協同程序 StartCoroutine(協同程序方法)

        private IEnumerator Test()
        {
            print("第一行");

            yield return new WaitForSeconds(2);

            print("兩秒後，第二行");
        }
    }
}
