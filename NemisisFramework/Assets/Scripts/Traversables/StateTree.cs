using UnityEditor;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Callbacks;

[CreateAssetMenu(menuName ="StateTree")]
public class StateTree : Traversable
{
    public List<EndNode> childendNodePointers=new List<EndNode>();
    public StartNode startNode;
   // public EndNode endNode;
    public override void DoTranisiton(StateController controller)
    {
       
    }
     public void CreateStartNode()
   {
        startNode=CreateInstance<StartNode>();
       startNode.guid=GUID.Generate().ToString();
       startNode.name="START";
       AssetDatabase.AddObjectToAsset(startNode,this);
       AssetDatabase.SaveAssets();
   }
   public EndNode CreateEndNode(Traversable _parent)
   {
      EndNode endNode=CreateInstance<EndNode>();
       endNode.guid=GUID.Generate().ToString();
       endNode.parent=_parent;
       endNode.name="END";
       AssetDatabase.AddObjectToAsset(endNode,this);
       AssetDatabase.SaveAssets();
       return endNode;
   }

//    public List<State> states=new List<State>();
//    public List<Action> actions=new List<Action>();
//    public List<StateTree> subtrees=new List<StateTree>();
//    public List<Transition> transitions=new List<Transition>();
//    public List<Decision> decisions=new List<Decision>();

//     public StateTree CreateStateTree()
//    {
//        StateTree tree=CreateInstance<StateTree>();
//        tree.guid=GUID.Generate().ToString();
//         subtrees.Add(tree);
//        tree.name=subtrees.Count.ToString()+".Tree";
//        AssetDatabase.AddObjectToAsset(tree,this);
//        AssetDatabase.SaveAssets();
//        return tree;
//    }
//    public State CreateState()
//    {
//        State state=CreateInstance<State>();
//        state.guid=GUID.Generate().ToString();
//         states.Add(state);
//        state.name=states.Count.ToString()+".State";
//        AssetDatabase.AddObjectToAsset(state,this);
//        AssetDatabase.SaveAssets();
//        return state;
//    }
//    public Action CreateAction(System.Type type)
//    {
//        Action action=CreateInstance(type) as Action;
//        action.name=type.Name;
//        action.guid=GUID.Generate().ToString();
//         actions.Add(action);
//        AssetDatabase.AddObjectToAsset(action,this);
//        AssetDatabase.SaveAssets();
//        return action;
//    }
//       public Transition CreateTransition(System.Type type)
//    {
//        Transition transition=CreateInstance(type) as Transition;
//        transition.name="transition";
//        transition.guid=GUID.Generate().ToString();
//        transitions.Add(transition);
//        AssetDatabase.AddObjectToAsset(transition,this);
//        AssetDatabase.SaveAssets();
//        return transition;
//    }
//     public Decision CreateDecision(System.Type type)
//    {
//        Decision decision=CreateInstance(type) as Decision;
//        decision.name=type.Name;
//        decision.guid=GUID.Generate().ToString();
//        decisions.Add(decision);
//        AssetDatabase.AddObjectToAsset(decision,this);
//        AssetDatabase.SaveAssets();
//        return decision;
//    }
//    public void RemoveTree(StateTree tree)
//    {
//        subtrees.Remove(tree);
//        AssetDatabase.RemoveObjectFromAsset(tree);
//        AssetDatabase.SaveAssets();
//    }
//    public void RemoveState(State state)
//    {
//        states.Remove(state);
//        AssetDatabase.RemoveObjectFromAsset(state);
//        AssetDatabase.SaveAssets();
//    }
//    public void RemoveAction(Action action)
//    {
//        actions.Remove(action);
//         AssetDatabase.RemoveObjectFromAsset(action);
//        AssetDatabase.SaveAssets();
//    }
//     public void RemoveTransition(Transition transition)
//    {
//        transitions.Remove(transition);
//         AssetDatabase.RemoveObjectFromAsset(transition);
//        AssetDatabase.SaveAssets();
//    }
//     public void RemoveDecision(Decision decision)
//    {
//        decisions.Remove(decision);
//         AssetDatabase.RemoveObjectFromAsset(decision);
//        AssetDatabase.SaveAssets();
//    }
   
}
