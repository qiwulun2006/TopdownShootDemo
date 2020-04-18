//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly BulletTag bulletTagComponent = new BulletTag();

    public bool isBulletTag {
        get { return HasComponent(GameComponentsLookup.BulletTag); }
        set {
            if (value != isBulletTag) {
                var index = GameComponentsLookup.BulletTag;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : bulletTagComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherBulletTag;

    public static Entitas.IMatcher<GameEntity> BulletTag {
        get {
            if (_matcherBulletTag == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.BulletTag);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherBulletTag = matcher;
            }

            return _matcherBulletTag;
        }
    }
}
