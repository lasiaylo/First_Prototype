namespace States {
    public interface IStateful<T> {
        StateMachine<T> StateMachine { get; }
    }
}