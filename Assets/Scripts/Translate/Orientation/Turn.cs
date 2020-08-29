using System.Numerics;
using Translate.Movement;
using Util.Attributes;

namespace Translate.Orientation {
    public class Turn : Mod<Quaternion> {
        [Expandable] public TurnTraits traits; 
        public override Quaternion Modify(Quaternion direction) {
            throw new System.NotImplementedException();
        }
    }
}