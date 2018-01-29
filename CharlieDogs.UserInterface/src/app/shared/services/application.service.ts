import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ConverterService } from "./converter.service";
import { environment } from "../../../environments/environment";
import { Http, Headers } from '@angular/http';

@Injectable()
export class ApplicationService {
  constructor(private http: HttpClient,
    private converterService: ConverterService) { }

  createAuthorizationHeader(): HttpHeaders {
    if (sessionStorage.getItem("token") && !this.token) {
      this.token = sessionStorage.getItem("token");
    }

    if (this.token) {
      let headers = new HttpHeaders()
        .set("Authorization", "Bearer " + this.token);

      sessionStorage.setItem("token", this.token);
      return headers;
    } else {
      return new HttpHeaders()
    }
  }

  token: string;
  authenticated: boolean;

  removeToken() {
    this.token = null;
    sessionStorage.removeItem("token");
  }

  setToken(token: string) {
    this.token = token;
    sessionStorage.setItem("token", this.token);
  }

  get<T>(service: string, data?: any) {
    var url = environment.serviceUrl + service;

    if (data) {
      if (data !== Object(data)) {
        url += "/" + data;
      }
      else {
        url += "?" + this.converterService.objectToQueryString(data);
      }
    }

    return this.http.get<T>(url, {
      headers: this.createAuthorizationHeader()
    });
  }

  put<T>(service: string, data?: any) {
    var url = environment.serviceUrl + service;

    return this.http.put<T>(url, data, {
      headers: this.createAuthorizationHeader()
    });
  }

  post<T>(service: string, data?: any) {
    var url = environment.serviceUrl + service;

    return this.http.post<T>(url, data, {
      headers: this.createAuthorizationHeader()
    });
  }

  delete(service: string, data?: any) {
    var url = environment.serviceUrl + service + "/" + data;

    return this.http.delete(url, {
      headers: this.createAuthorizationHeader()
    });
  }
}
