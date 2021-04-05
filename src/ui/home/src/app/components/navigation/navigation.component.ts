import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { ActivatedRoute, Route, Router } from '@angular/router';

@Component({
  selector: 'home-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.scss']
})
export class NavigationComponent implements OnInit {

  routes: Route[] = [];

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  constructor(
    private breakpointObserver: BreakpointObserver,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.router.config.forEach(b => this.routes.push(b));
  }

  isRouteActive(url: string | undefined): boolean {
    if (url) {
      return this.router.isActive(url, false);
    }
    return false;
  }

}
