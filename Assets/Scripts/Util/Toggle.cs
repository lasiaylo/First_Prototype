namespace Util {
    public class Toggle {
        public static implicit operator bool(Toggle toggle ) => toggle.Status;
        
        public Toggle(bool status = false) {
            Status = status;
        }

        public bool Status {
            get; private set;
        }

        public bool Flip() {
            Status = !Status;
            return Status;
        }
    }
}