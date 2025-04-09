import { Routes } from '@angular/router';
import { ReimbursementFormComponent } from './components/reimbursement-form/reimbursement-form.component';
import { ReimbursementListComponent } from './components/reimbursement-list/reimbursement-list.component';

export const routes: Routes = [
  { path: '/Claim', component: ReimbursementFormComponent },
  { path: '/Claim/List', component: ReimbursementListComponent },
  { path: '**', redirectTo: '/Claim' }
];