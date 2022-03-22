
using UnityEngine;

namespace UI
{
    public class TopDowncontroller : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn���򥻸�ơA�Ҧp:���ʳt��
        //SerializeField �ǦC�����:���p�H�����ܦb�ݩʭ��O�W
        //Header("���D") ���D
        //Range(�̤p�ȡA�̤j��) �d�򭭨�
        [SerializeField, Header("���ʳt��"),Range(0, 100)]
        private float speed = 10.5f;
        private string parameterRun = "�]�B";
        private string parameterDead = "���`";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
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
            //print("Update �ƥ�");
            
            //�I�s�y�k:��k�W��(�����޼�);
            GetInput();
            Move();
        }
        #endregion

        #region ��k:�������\�� (���z�� �t��k�ε{���϶�)

        // ��k method �y�k:
        private void GetInput()
        {
            // �ϥ��R�A��k�y�k static
            // ���O�W��.�R�A��k�W��(�����޼�):
            // float h = ****; - �ϰ��ܼ�;�ȯ�b�ӵ��c (�j�A����) �s��
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            // ��X�T��(�T��)  Crtl + Shift + C �����O (Console)
            //print("���o�����b�V��:" + h);
        }

        private void Move()
        {
            //�ϥΫD�R�A�ݩ� non-static
            //���W��.�R�A�ݩʦW�� ���w ��
            rig.velocity = new Vector2(h, v) * speed;
            //�ʵe���,�]�w���L��(�ѼƦW�١A���L��)
            //���� ������ �s �Ϊ� ���� ������ �s
            ani.SetBool(parameterRun, h != 0 || v != 0);

            // �T���B��l�y�k
            // ���L�� ? ���L�� ����ture : ���L�� ���� false
            // ���� >= 0 ���� 0 �_�h ����180
            // �ܧΤ���.�Ʀ쨤 = �s �T���V�q(X�AY�AZ)
            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0) ;
        }
        #endregion
    }

}