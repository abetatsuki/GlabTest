using UnityEngine;

/// <summary>
/// ���̃X�N���v�g�́A�I�u�W�F�N�g���N���b�N���ꂽ�Ƃ���
/// �w�肳�ꂽ�v���n�u���}�E�X�ʒu�ɐ������A�����Ƀh���b�O�\�ɂ��鏈�����s���܂��B
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class ClickClone : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�N���b�N���ɐ�������v���n�u")]
    private GameObject prefabToClone;
    private Camera _cam;

    /// <summary>
    /// ���C���J�������L���b�V�����܂��B
    /// </summary>
    private void Start()
    {
        _cam = Camera.main;
    }

    /// <summary>
    /// �I�u�W�F�N�g���N���b�N���ꂽ�Ƃ��ɌĂ΂�A
    /// �v���n�u���}�E�X�ʒu�ɐ������A�h���b�O��Ԃ��J�n�����܂��B
    /// </summary>
    private void OnMouseDown()
    {

        Vector3 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;


        GameObject clone = Instantiate(prefabToClone, mousePos, Quaternion.identity);


        if (clone.TryGetComponent<DaD>(out var draggable))
        {
            draggable.BeginDrag(mousePos);
        }
    }
}
