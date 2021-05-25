import { Component, Input, OnInit } from '@angular/core';
import { ProbeModel } from '../../models/probe.model';
import { SensorsDataService } from '../../services/sensors-data/sensors-data.service';

@Component({
  selector: 'home-probe-latest',
  templateUrl: './probe-latest.component.html',
  styleUrls: ['./probe-latest.component.scss']
})
export class ProbeLatestComponent implements OnInit {
  probe: ProbeModel | undefined;
  @Input() set probeId(value: string | undefined) {

    if (value) {
      this.sensorsDataService.getSensorLatestProbe(value).subscribe(s => this.probe = s);

    }
  }
  constructor(private sensorsDataService: SensorsDataService) { }

  ngOnInit(): void {
  }

  get labelAir_1(): string {
    if (this.probe?.pm1) {
      return `${this.probe.pm1} (${(this.probe.pm1 / 10) * 100}%)`;
    }
    return '';

  }

  get labelAir_2_5(): string {
    if (this.probe?.pm2_5) {
      return `${this.probe.pm2_5} (${(this.probe.pm2_5 / 25) * 100}%)`;
    }
    return '';
  }
  get labelAir_10(): string {
    if (this.probe?.pm10) {
      return `${this.probe.pm10} (${(this.probe.pm10 / 50) * 100}%)`;
    }
    return '';
  }

}
