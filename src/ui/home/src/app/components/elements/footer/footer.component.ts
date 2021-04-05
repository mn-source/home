import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'home-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['../../home.scss']
})
export class FooterComponent implements OnInit {
  private startYear = 2021;
  timeLabel: string;

  constructor() {
    const year = (new Date()).getFullYear();
    if (year === this.startYear) {
      this.timeLabel = `${year}`;
    } else {
      this.timeLabel = `${this.startYear}-${year}`;
    }
  }

  ngOnInit(): void {
  }

}
