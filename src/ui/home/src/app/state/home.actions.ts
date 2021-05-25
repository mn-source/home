import { createAction, props } from '@ngrx/store';

export const setScreenWidth = createAction('[home] screen width', props<{ width: number }>());
