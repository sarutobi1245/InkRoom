import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

import { User } from '../_model/user';
import { JwtHelperService } from '@auth0/angular-jwt';
import { environment } from '../../../environments/environment';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl = environment.apiUrl + 'auth/login';
  baseUrls = environment.apiUrlEC;
  jwtHelper = new JwtHelperService();
  currentUser: User;
  decodedToken: any;
  levelSource = new BehaviorSubject<any>({});
  currentLevel = this.levelSource.asObservable();
  constructor(private http: HttpClient) {}

  login(model: any) {
    return this.http.post(this.baseUrl, model).pipe(
      map((response: any) => {
        const data = response;
        if (data) {
          localStorage.setItem('token', data.token);
          localStorage.setItem('user', JSON.stringify(data.user));
          localStorage.setItem('avatar', data.user.User.image);
          this.decodedToken = this.jwtHelper.decodeToken(data.token);
          this.currentUser = data.user.User;
          this.getBuildingByUserID(data.user.User.ID).subscribe((res: any) => {
            console.log(res);
            res = res || {};
            localStorage.setItem('level', JSON.stringify(res));
            localStorage.setItem('building', JSON.stringify(res.name) ?? null) ;
            localStorage.setItem('buildingID', JSON.stringify(res.id) ?? "0") ;
            this.levelSource.next(res);
          });
          this.getRoleByUserID(data.user.User.ID).subscribe((res: any) => {
            res = res || {};
            localStorage.setItem('role', JSON.stringify(res));
            this.levelSource.next(res);
          });
        }
      })
    );
  }

  getBuildingByUserID(userID) {
    const url = `${environment.apiUrlEC}BuildingUser/GetBuildingByUserID/${userID}`;
    return this.http.get(url, {});
  }

  getRoleByUserID(id) {
    return this.http.get(this.baseUrls + `BuildingUser/GetRoleByUserID/${id}`, {});
  }

  CheckBlockUser(id) {
    return this.http.get(this.baseUrls + `BuildingUser/CheckLoginByUser/${id}`, {});
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(token);
  }

  roleMatch(allowedRoles): boolean {
    let isMatch = false;
    const userRoles = this.decodedToken.role as Array<string>;
    allowedRoles.forEach(element => {
      if (userRoles.includes(element)) {
        isMatch = true;
        return;
      }
    });
    return isMatch;
  }
}
