import { enableProdMode } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';
import { HomeModule } from './app/home.module';

import { environment } from './environments/environment';

if (environment.production) {
  enableProdMode();
}

const platform = platformBrowserDynamic();
const bootStrap = platform.bootstrapModule(HomeModule, { preserveWhitespaces: true });
bootStrap.catch(err => console.error(err));
