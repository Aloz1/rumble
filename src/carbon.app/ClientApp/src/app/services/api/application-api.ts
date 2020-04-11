import {HttpClient} from "@angular/common/http";
import {config} from "../../config";

export class ApplicationApi {

  private apiEndpoint = "api/application/";

  constructor(private http: HttpClient, private loading: boolean) {
  }

  public getCountries() {
    return this.http.get(config.baseUrl + this.apiEndpoint + "countries").pipe();
  }

  public getStates() {
    return this.http.get(config.baseUrl + this.apiEndpoint + "states").pipe();
  }

}
