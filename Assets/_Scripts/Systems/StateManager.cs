using System;
using System.Collections.Generic;

namespace StateManagement {
    
    public class StateManager<T> {

		public event Action OnStateChanged;

        //               Dictionary<T Key, T Vaule>
		private readonly Dictionary<Type, State<T>> states = new Dictionary<Type, State<T>>( );

		private State<T> currentState;

		public StateManager( State<T> _InitalState ) {
			_InitalState.SetStateManager( this );
			states.Add( _InitalState.GetType( ), _InitalState );
			currentState = _InitalState;
			_InitalState.EnterState( );
        }

		public void UpdateState( ) {
			if( currentState != null ) {
				currentState.UpdateState( );
			}
		}

		public void SetState<TR>( ) where TR : State<T> {
			
			var NewState = typeof( TR );

			if( currentState.GetType( ) == NewState ) {
				return;
			}

			if( currentState != null ) {
				currentState.ExitState( );
			}

			currentState = GetState( NewState );
			currentState.EnterState( );

			if( OnStateChanged != null ) {
				OnStateChanged( );
			}

		}

		private State<T> GetState( Type _NewState ) {
			if( states.ContainsKey( _NewState ) ) {
				return states[ _NewState ];
			}

			var state = Activator.CreateInstance( _NewState ) as State<T>;

			if( state != null ) {
				state.SetStateManager( this );
				states.Add( _NewState, state );
				return state;
			}
			return null;
		}
	}

 
}
