﻿import { Injectable } from '@angular/core';
import { Warehouse } from '../models/warehouse';
import { TemplateDefinitionBuilder } from '../../../node_modules/@angular/compiler/src/render3/view/template';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from '../../../node_modules/rxjs';

@Injectable({
  providedIn: 'root'
})
export class WarehouseService {
    private baseUrl: string = "https://localhost:5001/api/Warehouse";
    constructor(private http: HttpClient) { }


    public createNewWarehouse(newWarehouse: Warehouse): void {
        this.http.post<Warehouse>(this.baseUrl, newWarehouse).subscribe();
    }

    public getWareHouses(): Observable<any> {
        return this.http.get<Warehouse[]>(this.baseUrl);
    }
}
