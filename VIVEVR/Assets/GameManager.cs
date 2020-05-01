using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class GameManager : MonoBehaviour
{
    [Header("籃球數量")]
    public Text textBallCount;
    [Header("分數")]
    public Text textScore;

    //紀錄 整數 球數量/分數
    private int ballCount = 5;
    private int score;

    public void UseBall(GameObject ball)
    {
        //刪除(球.取得物件<丟>())
        //刪除(球.取得物件<互動>())
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());

        //減數量
        ballCount--;
        //減完後並更新文字
        textBallCount.text = "籃球數量" + ballCount + " / 5";
    }
        //觸發碰撞
    private void OnTriggerEnter(Collider other)
    {
            //進籃後增加的分數
            score += 10;
            //分數增加後並更新文字
            textScore.text = "分數:" + score;


    }


}

