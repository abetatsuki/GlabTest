using UnityEngine;

/// <summary>
/// マウスでオブジェクトをドラッグ操作できるスクリプト。
/// オブジェクトのCollider2Dが必要です。
/// </summary>
[RequireComponent(typeof(Collider2D))]
public class DaD : MonoBehaviour
{
    private Camera _cam;          // メインカメラ参照（マウス座標変換用）
    private Vector3 _offset;      // ドラッグ開始時のマウスとオブジェクト位置の差分
    private bool _isDragging;     // ドラッグ中かどうかのフラグ
 

    /// <summary>
    /// ゲーム開始時にメインカメラを取得する
    /// </summary>
    private void Start()
    {
        _cam = Camera.main;
    }

    /// <summary>
    /// 毎フレーム、ドラッグ中ならオブジェクトの位置更新とドラッグ終了判定を行う
    /// </summary>
    private void Update()
    {
       
        if (!_isDragging) return;
  
        DragMove();     // オブジェクトをマウス位置に追従させる
        CheckDragEnd(); // ドラッグ終了のチェック
    }

    /// <summary>
    /// マウス位置にオフセットを加えた位置にオブジェクトを移動する
    /// </summary>
    private void DragMove()
    {
        Vector3 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;  // Z軸は固定（2D想定）
        transform.position = mousePos + _offset;
    }

    /// <summary>
    /// 左クリックを離したらドラッグ終了フラグをfalseにする
    /// </summary>
    private void CheckDragEnd()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _isDragging = false;
        }
    }

    /// <summary>
    /// 自オブジェクト上でマウスクリックされた時にドラッグを開始する
    /// </summary>
    private void OnMouseDown()
    {
        StartDragging();
    }

    /// <summary>
    /// 外部からドラッグ開始を指示する際に使用する（指定座標で開始）
    /// </summary>
    /// <param name="mousePos">ワールド座標でのマウス位置</param>
    public void BeginDrag(Vector3 mousePos)
    {
        if (_cam == null) _cam = Camera.main;
        StartDragging(mousePos);
    }

    /// <summary>
    /// 現在のマウス位置を取得してドラッグ開始処理を呼び出す
    /// </summary>
    private void StartDragging()
    {
        Vector3 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        StartDragging(mousePos);
    }

    /// <summary>
    /// 実際にドラッグ開始状態にする処理
    /// マウス位置とオブジェクト位置の差分を計算し、フラグを立てる
    /// </summary>
    /// <param name="mousePos">ワールド座標のマウス位置</param>
    private void StartDragging(Vector3 mousePos)
    {
        mousePos.z = transform.position.z; // Z軸は固定
        _offset = transform.position - mousePos;
        _isDragging = true;
    }
}
