import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class VehicleService {

    constructor(private httpClient: HttpClient) { }

    getMakes() {
        return this.httpClient.get('/api/makes')
            .map(res => res);
    }

    getFeatures() {
        return this.httpClient.get('/api/features')
            .map(res => res);
    }

}
