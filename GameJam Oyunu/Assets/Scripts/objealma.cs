using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objealma : MonoBehaviour
{
    public Transform point;
    public float rangeSpahere;
    public LayerMask LayerObje;
    public Camera cam;

    Rigidbody rbObje;
    public float maxDistance = 20f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rbObje)
        {
            
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(rbObje)
            {
                rbObje.isKinematic = false;
                rbObje = null;
                rbObje.transform.parent = null;
                 


            }
            else
            {
                Collider[] col =  Physics.OverlapSphere(point.position, rangeSpahere,LayerObje);
                foreach(Collider collider in col){
                
                if(col != null)
                {
                    rbObje = collider.GetComponent<Rigidbody>();
                    if(rbObje){
                        
                         rbObje.isKinematic = true;
                         rbObje.transform.position = new Vector3(point.position.x,point.position.y,point.position.z);
                         rbObje.transform.parent = point.transform;

                       

                   
                    } 
                }
                
                }
            }

            
        }



        
    }
    void OnDrawGizmosSelected()
    {
        if(rangeSpahere  == null)
        return;
        Gizmos.DrawSphere(point.position, rangeSpahere);
    }

}
}
