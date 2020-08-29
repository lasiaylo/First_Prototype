using Quaternion = UnityEngine.Quaternion;

namespace Translate.Rotation {
    public class Rotation: Modifier<Quaternion> {

        public void Awake() {
            val = transform.rotation;
        }
        
        public override void Tick() {
            base.Tick();
            transform.rotation = val;
        }
    }
}