import { Action, configureStore, ThunkAction } from '@reduxjs/toolkit';
import { connectRouter } from 'connected-react-router';
import { createBrowserHistory } from 'history';
import accountReducer from '../features/account/accountSlice';
import counterReducer from '../features/counter/counterSlice';

export const history = createBrowserHistory();

export const store = configureStore({
  reducer: {
    router: connectRouter(history),
    counter: counterReducer,
    account: accountReducer,    
  },
});

export type AppDispatch = typeof store.dispatch;
export type RootState = ReturnType<typeof store.getState>;
export type AppThunk<ReturnType = void> = ThunkAction<
  ReturnType,
  RootState,
  unknown,
  Action<string>
>;
