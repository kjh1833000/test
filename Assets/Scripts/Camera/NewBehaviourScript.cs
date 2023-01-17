using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Camera
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private List<Transform> _tr;
        // Start is called before the first frame update
        private void Start()
        {
            foreach (var tr in _tr.Where(tr => Math.Abs(tr.position.x - 1.0f) < 3.0f))
            {
                Debug.Log(tr.position);
            }
        }

        /// <summary>
        /// [진훈] 아이템을 판매하는 함수 입니다.
        /// </summary>
        /// <param name="itemID">판매하려는 아이템의 아이디 입니다.</param>
        public void Sell(int itemID)
        {
        
        }


        public void Buy()
        {
            
        }

    
    }
}
