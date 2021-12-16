using UnityEditor;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="StateTree")]
public class StateTree : ScriptableObject
{
   public List<State> states=new List<State>();
   public List<Action> actions=new List<Action>();

   public State CreateState()
   {
       State state=CreateInstance<State>();
       state.name="State";
       state.guid=GUID.Generate().ToString();
        states.Add(state);
       AssetDatabase.AddObjectToAsset(state,this);
       AssetDatabase.SaveAssets();
       return state;
   }
   public Action CreateAction(System.Type type)
   {
       Action action=CreateInstance(type) as Action;
       action.name=type.Name;
       action.guid=GUID.Generate().ToString();
        actions.Add(action);
       AssetDatabase.AddObjectToAsset(action,this);
       AssetDatabase.SaveAssets();
       return action;
   }
   public void RemoveState(State state)
   {
       states.Remove(state);
       AssetDatabase.RemoveObjectFromAsset(state);
       AssetDatabase.SaveAssets();
   }
   public void RemoveAction(Action action)
   {
       actions.Remove(action);
        AssetDatabase.RemoveObjectFromAsset(action);
       AssetDatabase.SaveAssets();
   }
   
}