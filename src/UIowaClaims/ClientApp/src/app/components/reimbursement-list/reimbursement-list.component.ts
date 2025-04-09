import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DatePipe } from '@angular/common';
import { ReimbursementService } from '../../services/reimbursement.service';
import { AgGridAngular } from "ag-grid-angular";
import type { ColDef } from "ag-grid-community";
import { AllCommunityModule, ModuleRegistry } from "ag-grid-community";

ModuleRegistry.registerModules([AllCommunityModule]);
interface Reimbursement {
    userId: string;
    amount: number;
    date: Date;
    fileName: string;
}
@Component({
  selector: 'app-reimbursement-list',
  standalone: true,
  imports: [CommonModule, DatePipe, AgGridAngular],
  templateUrl: './reimbursement-list.component.html',
  styleUrls: ['./reimbursement-list.component.css']
})
export class ReimbursementListComponent {
    rowModelType = 'clientSide';
    rowData: Reimbursement[] = [];
    constructor(private service: ReimbursementService) {
    }

    ngOnInit(): void {
        this.service.getAllReimbursements().subscribe(
            (data: any[]) => {
                console.log('Reimbursements:', data);
                this.rowData = [];
                data.forEach((item: any) => {
                    this.rowData.push({
                        userId: item.userId,
                        amount: item.amount,
                        date: item.date,
                        fileName: item.file.fileName
                    });
                });
            },
            (error) => {
                console.error('Error fetching reimbursements:', error);
            }
        );
    }
  columnDefs = [
    { field: 'userId', headerName: 'User ID' },
    { field: 'amount', headerName: 'Amount' },
      {
          field: 'RecepitDate', headerName: 'Date',
          valueFormatter: (params) => {
              console.log(params)
              var paramdate = new Date(params.data.date);
              if (paramdate) {
                  console.log(paramdate)
                  const datePipe = new DatePipe('en-US');
                  return datePipe.transform(paramdate, 'dd/MM/yyyy');
              }
              return '';
          },
      },
    { field: 'fileName', headerName: 'File Name' }
  ];

}
