using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
        int hp;          // 体力
        int power; // 攻撃力
        int mp=53;

        public void Attack()
        {
                // 攻撃用の関数
        }

        public  void Defence(int damage)
        {
                // 防御用の関数
        }

        public void Magic()
        {
          if(this.mp>5){
            this.mp=this.mp-5;
            Debug.Log("魔法攻撃をした。残りMPは"+this.mp+"。");

          } else {
            Debug.Log("MPが足りないため魔法が使えない。");
          }
        }

}

public class Test : MonoBehaviour
{

       void array_print()
       {
              int[] test_array={10,20,30,40,99};
              int lc=0;

              // ---
              Debug.Log("正順");
              for(lc =0 ; lc < 5 ;lc++){
                Debug.Log(test_array[lc]);
              }

              // --

              Debug.Log("逆順 for ");
              for(lc = 4 ; lc !=-1  ;lc--){
                Debug.Log(test_array[lc]);
              }

              // ---
              //lc = 5;
              //do{
              //  Debug.Log("逆順 do while ");
              //  lc = lc -1;
              //  Debug.Log(test_array[lc]);
              //} while(lc!=0);


       }


       void Start()
       {
          int lc=0;
          Boss lastboss = new Boss();
          array_print();
          Debug.Log("魔法攻撃");
          for(lc=0 ; lc<11 ; lc++){
            lastboss.Magic();
          }
       }

       // Update is called once per frame
       void Update()
       {

       }

}
