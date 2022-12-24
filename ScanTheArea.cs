using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanTheArea : MonoBehaviour
{
        public GameObject wall ;
        public float speed ;
        private float distance ;

        [field: SerializeField]
        public bool WallInArea {get; private set;}
        public Transform Wall { get; private set;}

        [SerializeField]
        private string detectionTag = "Wall" ;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag(detectionTag))
            {
                WallInArea = false ;
                Wall = null ;
            }
        }
}
