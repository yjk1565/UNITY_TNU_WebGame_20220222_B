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

        // ��P�{��:����t�ε��ݡB����
        // 1.�ޥ� System.Collections
        // 2.�w�q��P�{�Ǥ�k�Ǧ^���� IEnumerator
        // 3.�ϥ� yield return new WaitForSeconds
        // 4.�ϥαҰʨ�P�{�� StartCoroutine(��P�{�Ǥ�k)

        private IEnumerator Test()
        {
            print("�Ĥ@��");

            yield return new WaitForSeconds(2);

            print("����A�ĤG��");
        }
    }
}
