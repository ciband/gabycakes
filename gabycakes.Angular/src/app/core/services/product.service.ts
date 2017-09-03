import { Observable } from 'rxjs/Observable';
import { HttpService } from './http';
import { Injectable } from '@angular/core';

@Injectable()
export class ProductService {

  /**
   * Creates an instance of ProductService.
   * @param {HttpService} http
   *
   * @memberof ProductService
   */
  constructor(private http: HttpService) { }

  /**
   *
   *
   * @param {string} id
   * @returns {Observable<any>}
   *
   * @memberof ProductService
   */
  getProduct(id: string): Observable<any> {
    return this.http.get(`/api/products/${id}`)
    .map(res => res.json());
  }

  /**
   *
   *
   * @returns {*}
   *
   * @memberof ProductService
   */
  getTaxonomies(): any {
    return this.http.get(`/api/taxonomies`)
    .map(res => res.json());
  }

  /**
   *
   *
   * @returns {*}
   *
   * @memberof ProductService
   */
  getProducts(): any {
    return this.http.get(`/api/products`)
    .map(res => res.json());
  }
}
