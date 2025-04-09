import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ReimbursementService } from '../../services/reimbursement.service';

@Component({
  selector: 'app-reimbursement-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './reimbursement-form.component.html',
  styleUrls: ['./reimbursement-form.component.css']
})
export class ReimbursementFormComponent {
    form: FormGroup;
    formSubmitted = false;
  constructor(private fb: FormBuilder, private service: ReimbursementService) {
    this.form = this.fb.group({ userId: [''], amount: [''], date: [''], file: [null] });
  }
  onFileChange(event: any) {
    const file = event.target.files[0];
    if (file) this.form.patchValue({ file });
  }
  onSubmit() {
    const formData = new FormData();
    const value = this.form.value;
    formData.append('UserId', value.userId || '');
    formData.append('Amount', value.amount || '');
    formData.append('Date', value.date || '');
    formData.append('File', value.file || '');
      this.service.submitReimbursement(formData).subscribe(() => {
          this.formSubmitted = true;
      });
  }
}