namespace StateManagement {
    
    public class StateManager<T> {

        public State<T> curentState{ get; private set; }
        public T state;

        public StateManager( T _state ) {
            state = _state;
            curentState = null;
        }

        public void SetState( State<T> _newState ) {
            if( curentState != null ) {
                curentState.ExitState( state );
            }
            curentState = _newState;
            curentState.EnterState( state );
        }

        public void Update( ) {
            if( curentState != null ) {
                curentState.UpdateState( state );
            } 
        }
    }

    public abstract class State<T> {
        public abstract void EnterState( T _state );
        public abstract void UpdateState( T _state );
		public abstract void ExitState (T _state);
    }
}
