using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GG
{
    /// <summary>
    /// �ĤH����:�u�X���˼Ʀr
    /// </summary>
    // �l���O:�����O - �~�ӻy�k
    public class HurtEnemy : HurtSystem
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;

        private void Start()
        {
            hp = data.hp;
        }
    }
}