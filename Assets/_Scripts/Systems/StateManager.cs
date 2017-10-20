using System;
using System.Collections.Generic;

namespace StateManagement {
    
    public class StateManager<T> {

		public event Action OnStateChanged;

		private readonly Dictionary<Type, State<T>> states = new Dictionary<Type, State<T>>( );

		private State<T> currentState;

		public StateManager( State<T> _initalState ) {
			_initalState.SetStateManager( this );
			states.Add( _initalState.GetType( ), _initalState );
			currentState = _initalState;
			_initalState.EnterState( );
        }

		public void UpdateState( ) {
			if( currentState != null ) {
				currentState.UpdateState( );
			}
		}

		public void SetState<TR>( ) where TR : State<T> {
			
			var newState = typeof( TR );

			if( currentState.GetType( ) == newState ) {
				return;
			}

			if( currentState != null ) {
				currentState.ExitState( );
			}

			currentState = GetState( newState );
			currentState.EnterState( );

			if( OnStateChanged != null ) {
				OnStateChanged( );
			}

		}

		private State<T> GetState( Type _newState ) {
			if( states.ContainsKey( _newState ) ) {
				return states[ _newState ];
			}

			var state = Activator.CreateInstance( _newState ) as State<T>;

			if( state != null ) {
				state.SetStateManager( this );
				states.Add( _newState, state );
				return state;
			}
			return null;
		}
	}

 
}
