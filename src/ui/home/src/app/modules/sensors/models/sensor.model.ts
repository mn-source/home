export enum SensorClient {
  Supla,
  Blebox
}

export enum SensorType {
  Temperature,
  AirQuality
}

export interface SensorModel {
  idString: string;
  sensorName: string;
  type: SensorType;
  client: SensorClient;
  sensorApiAddress: string;
  isActive: boolean;
}
