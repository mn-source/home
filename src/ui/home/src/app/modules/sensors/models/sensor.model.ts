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
  sensorNam: string;
  type: SensorType;
  client: SensorClient;
  sensorApiAdress: string;
  isActive: boolean;
}
