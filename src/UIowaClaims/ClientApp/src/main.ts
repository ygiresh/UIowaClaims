import 'zone.js';
import { bootstrapApplication } from '@angular/platform-browser';
import { importProvidersFrom } from '@angular/core';
import { provideHttpClient } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { routes } from './app/routes';

// Feature root components
import { ReimbursementFormComponent } from './app/components/reimbursement-form/reimbursement-form.component';
import { ReimbursementListComponent } from './app/components/reimbursement-list/reimbursement-list.component';

const providers = [
    provideHttpClient(),
    importProvidersFrom(ReactiveFormsModule),
    importProvidersFrom(RouterModule.forRoot(routes)),
];

document.addEventListener('DOMContentLoaded', () => {
    if (document.getElementById('ng-claim-form-root')) {
        bootstrapApplication(ReimbursementFormComponent, { providers }).catch(console.error);
    }

    if (document.getElementById('ng-claim-list-root')) {
        bootstrapApplication(ReimbursementListComponent, { providers }).catch(console.error);
    }
});
