using UnityEngine;
using System.Collections;

/*
 * モデルに触れるオブジェクトにセットする
 */

public class TouchModel : MonoBehaviour
{
    // 指定の剛体との接触であればモデルにメッセージを通知する
    protected void checkTouch(Collider collider, string name, string message)
    {
        if (collider.name.IndexOf(name) >= 0)
        {
            var model = collider.GetComponentInParent<MMD4MecanimModel>();
            if (model)
            {
                var option = SendMessageOptions.DontRequireReceiver;
                model.SendMessage(message, GetComponent<Collider>(), option);

            }
        }
    }

    // 剛体と接触中
    void OnTriggerStay(Collider collider)
    {
        // 監視対象の剛体に触れたかを判定
        // ここの文字列はモデルによって違いますので適時修正してください

        // 髪
        checkTouch(collider, "FrontHair", "setTouch_FrontHair");
        checkTouch(collider, "BackHair", "setTouch_BackHair");
        checkTouch(collider, "RightHair", "setTouch_RightHair");
        checkTouch(collider, "LeftHair", "setTouch_LeftHair");

        // ネクタイ.
        checkTouch(collider, "Necktie", "setTouch_Necktie");

        // 胸
        checkTouch(collider, "Breast", "setTouch_Breast");
    }
}
