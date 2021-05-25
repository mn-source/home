import * as Sate from 'src/app/state/home.state';
import { SensorModel } from '../models/sensor.model';


export interface SensorState {
  sensors: SensorModel[];
}

export interface HomeState extends Sate.HomeState {
  sensor: SensorState;
}
