﻿import { Component } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
})
export class HomeComponent {
    private loginForm = new FormGroup({
        userName: new FormControl(''),
        passWord: new FormControl(''),
    });



}
