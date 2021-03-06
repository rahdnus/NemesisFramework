
using UnityEditor.Experimental.GraphView;
public class StateView : NodeView
{
    public State state;
     public Port A_input;
    public Port T_input;
    public Port output;
   public StateView(State state)
   {
       this.state=state;
       this.title=state.name;
       viewDataKey=state.guid;
       style.left=state.position.x;
       style.top=state.position.y;
       CreateInputPorts();
       CreateOutputPorts();
   }
   private void CreateInputPorts()
   {
       A_input=InstantiatePort(Orientation.Horizontal,Direction.Input,Port.Capacity.Multi,typeof(bool));
       A_input.portName="Action";
       inputContainer.Add(A_input);
       T_input=InstantiatePort(Orientation.Horizontal,Direction.Input,Port.Capacity.Multi,typeof(bool));
       T_input.portName="Transition";
       inputContainer.Add(T_input);
   }
    private void CreateOutputPorts()
   {
        output = InstantiatePort(Orientation.Horizontal, Direction.Output, Port.Capacity.Multi, typeof(bool));
        output.portName="This State";
        outputContainer.Add(output);

    }
   public override void SetPosition(UnityEngine.Rect newPos)
   {
       base.SetPosition(newPos);
       state.position.x=newPos.xMin;
       state.position.y=newPos.yMin;
   }
   //:base("Assets/Scripts/GraphView/StateView.uxml")
}
