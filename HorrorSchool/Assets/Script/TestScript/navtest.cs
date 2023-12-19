using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;　//�@←これを足しておかないと動かないので必須です。

public class navtest : MonoBehaviour
{

    public GameObject goal; 　//�A←目的地になるオブジェクトを取得するための変数
    public NavMeshAgent agent;　//�Bコンポーネント取得用の変数

    // Use this for initialization
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();　//�Bコンポーネントの取得
        //goal = GameObject.Find("Player");　//�Aここで目的地を取得
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.transform.position;　//�Cここで目的地を設定
    }
}
