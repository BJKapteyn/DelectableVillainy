//interface for the Villains, need to connect to DB
export interface IVillain {
  Id: number;
  FullName: string;
  FirstName: string;
  LastName: string;
  Description: string;
  URI: string;
  ImageLocation: string;
  SelfPortrait: string;
  ImgFileName: string;
}

export class Villain implements IVillain {
  Id: number;
  FullName: string;
  FirstName: string;
  LastName: string;
  Description: string;
  URI: string;
  ImageLocation: string;
  SelfPortrait: string;
  ImgFileName: string;
  constructor() {

  }
}
