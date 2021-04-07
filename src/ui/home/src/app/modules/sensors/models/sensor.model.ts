export enum SensorClient {
  Supla,
  Blebox
}

export enum SensorType {
  Temperature,
  AirQuality
}

export interface NetworkAccess {
  isActive: boolean;
  sensorApiAddress: string;

}

export interface NetworkCheck {
  network: NetworkAccess;
  probeIntervalSeconds: number;
}

export interface SensorModel {
  idString: string;
  sensorName: string;
  type: SensorType;
  client: SensorClient;
  sensorApiAddress: string;
  networkCheck: NetworkCheck;
  isActive: boolean;
}
