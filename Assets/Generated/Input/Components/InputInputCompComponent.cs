//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public InputComp inputComp { get { return (InputComp)GetComponent(InputComponentsLookup.InputComp); } }
    public bool hasInputComp { get { return HasComponent(InputComponentsLookup.InputComp); } }

    public void AddInputComp(UnityEngine.Vector2 newDir, UnityEngine.Vector2 newMousePos) {
        var index = InputComponentsLookup.InputComp;
        var component = (InputComp)CreateComponent(index, typeof(InputComp));
        component.Dir = newDir;
        component.MousePos = newMousePos;
        AddComponent(index, component);
    }

    public void ReplaceInputComp(UnityEngine.Vector2 newDir, UnityEngine.Vector2 newMousePos) {
        var index = InputComponentsLookup.InputComp;
        var component = (InputComp)CreateComponent(index, typeof(InputComp));
        component.Dir = newDir;
        component.MousePos = newMousePos;
        ReplaceComponent(index, component);
    }

    public void RemoveInputComp() {
        RemoveComponent(InputComponentsLookup.InputComp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherInputComp;

    public static Entitas.IMatcher<InputEntity> InputComp {
        get {
            if (_matcherInputComp == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.InputComp);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherInputComp = matcher;
            }

            return _matcherInputComp;
        }
    }
}
