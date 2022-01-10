using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour
{
    public FlagHandler flagHandler;
    public int maxenergy=100;
    public int energy=100;//temporary;will be substituted by entity stats 
    public Transform backjump;
    public StateTree tree;


   public LayerMask targetlayer;
   public Transform Target;
   [HideInInspector] public Animator anim;
   [HideInInspector]public NavMeshAgent agent;
   [HideInInspector]public Rigidbody rb;

   public Transform foot;
   public List<Transform> waypoints;
  public int nextwaypoint=0;
  Vector3 pos;
   void Awake()
   {
      // currentstate=tree.states[0];
       anim=GetComponent<Animator>();
      // agent=GetComponent<NavMeshAgent>();
       rb=GetComponent<Rigidbody>();
       tree.onEnter(this);
   }
    void Update()
    {
    tree.update(this);
    }
    void FixedUpdate()
    {
    tree.fixedUpdate(this);
    }
    
    
    public void changeCurrnetTree(StateTree newtree)
    {
        // //find solution for this ***
        // if(newstate!=null)
        // {
        //     Debug.Log(newstate.name);
        //     currenttraversable.onExit(this);
        //     currenttraversable=newstate;
        //     currenttraversable.onEnter(this);
        // }
        Debug.Log(newtree.name);
        if(newtree!=null)
        {
            tree.onExit(this);
            tree=newtree;
            // if(tree.GetType()==typeof(StateBranch))
            // tree.DoTranisiton(this);
            tree.onEnter(this);
        }
    }
  

    public void Block()
    {
        Debug.Log("blocked");
    }
   
    
    public void OnDrawGizmosSelected()
    {
        Gizmos.DrawRay(foot.transform.position,-transform.up);

    }
}
