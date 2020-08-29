using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;

namespace Translate.Orientation {
    public class Orientation: Modifier<Quaternion> {
        public override void Tick() {
            base.Tick();
            transform.rotation = val;
        }
    }
}