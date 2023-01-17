import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

export class GenericService<T> {

  constructor(protected APIUrl : string, protected client : HttpClient) {}

  get(id : number) : Observable<Object> {
    return this.client.get(`${this.APIUrl}${environment.APISubRoutes.get}/${id}`);
  }

  post(model : T) : Observable<Object> {
    return this.client.post(`${this.APIUrl}${environment.APISubRoutes.post}`, model);
  }

  put(model : T) : Observable<Object> {
    return this.client.put(`${this.APIUrl}${environment.APISubRoutes.put}`, model);
  }

  delete(id : number) : Observable<Object> {
    return this.client.delete(`${this.APIUrl}${environment.APISubRoutes.delete}/${id}`);
  }
}
