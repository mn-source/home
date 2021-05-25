import { createReducer, on } from '@ngrx/store';
import { setScreenWidth } from './home.actions';
import { LayoutState } from './home.state';




export const initialState: LayoutState = {
  screenWeight: 100
};


export const layoutReducer = createReducer<LayoutState>(
  initialState,
  on(setScreenWidth, (state, { width }) => ({ ...state, screenWeight: width }))
);
