
using UnityEngine;

namespace UI
{
    public class TopDowncontroller : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn���򥻸�ơA�Ҧp:���ʳt��
        private float speed = 10.5f;
        private string parameterRun = "�]�B";
        private string parameterDead = "���`";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�:�{���J�f (Unity)�A���Ѷ}�o���X�ʨt�Ϊ����f
        //����ƥ�:����C�������@��
        private void Awake()
        {
            //crtl +shift +C
            //print("����ƥ�");

            // ��� ���w ���o����<����W��>()
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //��s�ƥ�:����C����H�C��� 60 ������A60 FPS (Frame Per second)
        private void Update()
        {
            print("Update �ƥ�");
        }
        #endregion

        #region ��k:�������\�� (���z��
        #endregion
    }

}