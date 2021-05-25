import { createReducer } from "@ngrx/store";
import { SensorState } from './sensor.store';


export const initialState: SensorState = {
  sensors: []
};


export const reducer = createReducer<SensorState>(
  initialState,
);
