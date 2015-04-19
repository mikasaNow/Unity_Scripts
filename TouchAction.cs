using UnityEngine;
using System.Collections;

/*
 * モデルにセットする
 */

public class TouchAction : MonoBehaviour
{
    // モーションを元に戻すためのタイマー
    public float timer = 0.0f;

    // 離れたときにモーションを元に戻す時間
    public float recover_sec = 2.0f;

    // アニメーション制御
    protected Animator anim = null;
    protected string last_anim_name = "";

    // モーフ制御
    private MMD4MecanimMorphHelper morphScript;

    //-------------------------------------
    // 初期化
    //-------------------------------------
    void Start()
    {
        anim = GetComponent<Animator>();
        morphScript = GetComponent<MMD4MecanimMorphHelper>();
    }


    //-------------------------------------
    // 毎フレームの更新
    //-------------------------------------
    void Update()
    {
        /*
        Debug.Log("deltaTime:" + Time.deltaTime);
        Debug.Log("timer:" + timer);

        float f = anim.GetCurrentAnimatorStateInfo(0).normalizedTime;
        Debug.Log("normalizedTime:" + f);

        if (f >= 1)
        {
            timer = 0.0f;
            setAnimation("stay.vmd");
            morphScript.morphWeight = 0;
        }
         */
        if (timer > 0.0f)
        {
            timer -= 0.001f;
            if (timer <= 0.0f)
            {
                timer = 0.0f;
                setAnimation("stay.vmd");
                morphScript.morphWeight = 0;
            }
        }
    }

    //-------------------------------------
    // アニメーション変更
    //-------------------------------------
    protected void setAnimation(string anim_name)
    {
        // 再生中のアニメーションは無視したい.
        if (anim_name != last_anim_name)
        {
            last_anim_name = anim_name;
            anim.CrossFade(anim_name, 0.1f);
        }
    }


    //==================================================
    // 剛体が触れられたときに呼ばれる関数
    //==================================================

    //-------------------------------------
    // 髪に触れた
    //-------------------------------------
    public void setTouch_FrontHair(Collider collider)
    {
        timer = recover_sec;
        setAnimation("stay.vmd");
        Debug.Log("Touch_FrontHair");
    }

    public void setTouch_BackHair(Collider collider)
    {
        timer = recover_sec;
        setAnimation("stay.vmd");
        Debug.Log("Touch_setTouch_BackHair");
    }

    public void setTouch_RightHair(Collider collider)
    {
        timer = recover_sec;
        setAnimation("stay.vmd");
        Debug.Log("Touch_RightHair");
    }

    public void setTouch_LeftHair(Collider collider)
    {
        timer = recover_sec;
        setAnimation("stay.vmd");
        Debug.Log("Touch_LeftHair");
    }

    //-------------------------------------
    // ネクタイに触れた
    //-------------------------------------
    public void setTouch_Necktie(Collider collider)
    {
        timer = recover_sec;
        setAnimation("stay.vmd");
        Debug.Log("Touch_Necktie");
    }

    //-------------------------------------
    // 胸に触れた
    //-------------------------------------
    public void setTouch_Breast(Collider collider)
    {
        timer = recover_sec;
        setAnimation("振り向き1.vmd");

        // モーフ変更
        morphScript.morphName = "照れ";
        morphScript.morphWeight = 1;
    }
}
