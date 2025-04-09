import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';


@Injectable({ providedIn: 'root' })
export class ReimbursementService {
    constructor(private http: HttpClient) { }
    submitReimbursement(data: FormData) {
        return this.http.post(`${environment.apiUrl}/Claims/submit`, data);
    }
    getAllReimbursements() {
        return this.http.get(`${environment.apiUrl}/Claims/all`);
    }
}