import { IPartname2 } from './../_model/partname2';
import { IMaterialName } from './../_model/material-name';
import { IPartname } from './../_model/partname';
import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient, HttpParams } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from '../../../environments/environment';
import { IGlue } from '../_model/glue';
import { PaginatedResult } from '../_model/pagination';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    // 'Authorization': 'Bearer ' + localStorage.getItem('token'),
  }),
};
@Injectable({
  providedIn: 'root'
})
export class GlueService {
  baseUrl = environment.apiUrlEC;
  glueSource = new BehaviorSubject<number>(0);
  currentGlue = this.glueSource.asObservable();
  constructor(private http: HttpClient) { }
  getGlues(page?, itemsPerPage?): Observable<PaginatedResult<object[]>> {
    const paginatedResult: PaginatedResult<object[]> = new PaginatedResult<object[]>();

    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page);
      params = params.append('pageSize', itemsPerPage);
    }


    return this.http.get<object[]>(this.baseUrl + 'Glue/getGlues', { observe: 'response', params})
      .pipe(
        map(response => {
          // console.log(response);
          paginatedResult.result = response.body;
          if (response.headers.get('Pagination') != null) {
            paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
          }
          return paginatedResult;
        }),
      );
  }

  getAllGlue() {
    return this.http.get(this.baseUrl + 'Glue/GetAll', {});
  }

  getGlueByScheduleID(id) {
    return this.http.get(this.baseUrl + `Glue/GetGluesByScheduleID/${id}`, {});
  }

  getGlueByScheduleIDWithLocale(id, lang) {
    return this.http.get(this.baseUrl + `Glue/GetGluesByScheduleIDWithLocale/${id}/${lang}`, {});
  }

  GetInkChemicalByGlueID(id) {
    return this.http.get(this.baseUrl + `Glue/GetInkChemicalByGlueID/${id}`, {});
  }

  GetInkChemicalByGlueIDWithLocale(id, lang) {
    return this.http.get(this.baseUrl + `Glue/GetInkChemicalByGlueIDWithLocale/${id}/${lang}`, {});
  }

  create(ingredient: IGlue) {
    return this.http.post(this.baseUrl + 'Glue/create', ingredient);
  }

  create1(ingredient: IGlue) {
    return this.http.post(this.baseUrl + 'Glue/create1', ingredient);
  }
  update(ingredient: IGlue) {
    return this.http.put(this.baseUrl + 'Glue/update', ingredient);
  }
  updateChemical(ingredient: IGlue) {
    return this.http.put(this.baseUrl + 'Glue/updateChemical', ingredient);
  }
  delete(id: number, scheduleID) {
    return this.http.delete(this.baseUrl + `Glue/delete/${id}/${scheduleID}`);
  }
  saveGlue(model) {
    return this.http.put(this.baseUrl + 'Glue/saveGlue', model);
  }
  changeGlue(glue) {
    this.glueSource.next(glue);
  }

  getGlueByModelName(id) {
    return this.http.get(this.baseUrl + `Glue/GetGluesByModelNameID/${id}`, {});
  }
  getAllGluesForBPFC(modelNameID, articleID, processID) {
    return this.http.get(this.baseUrl + `Glue/GetAllGluesForBPFC/${modelNameID}/${articleID}/${processID}`, {});
  }
  getAllGluesByBPFCID(BPFCID) {
    return this.http.get(this.baseUrl + `Glue/getAllGluesByBPFCID/${BPFCID}`, {});
  }
  getAllPartName() {
    return this.http.get<IPartname[]>(this.baseUrl + 'PartName/GetAll', {});
  }

  getAllPartName2() {
    return this.http.get<IPartname2[]>(this.baseUrl + 'PartName2/GetAll', {});
  }

  getAllMaterialName() {
    return this.http.get<IMaterialName[]>(this.baseUrl + 'MaterialName/GetAll', {});
  }
}
