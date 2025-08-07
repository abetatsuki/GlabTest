using UnityEngine;

/// <summary>
/// このスクリプトは、オブジェクトがクリックされたときに
/// 指定されたプレハブをマウス位置に生成し、すぐにドラッグ可能にする処理を行います。
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class ClickClone : MonoBehaviour
{
    [SerializeField]
    [Tooltip("クリック時に生成するプレハブ")]
    private GameObject prefabToClone;
    private Camera _cam;

    /// <summary>
    /// メインカメラをキャッシュします。
    /// </summary>
    private void Start()
    {
        _cam = Camera.main;
    }

    /// <summary>
    /// オブジェクトがクリックされたときに呼ばれ、
    /// プレハブをマウス位置に生成し、ドラッグ状態を開始させます。
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
