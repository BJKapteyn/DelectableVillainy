//interface for the Villains, need to connect to DB
export interface IVillain {
  id: number;
  name: string;
  description: string;
  URI: string;
  imageLocation: string;
}

export class Villain implements IVillain {
  id: number;
  name: string;
  description: string;
  URI: string;
  imageLocation: string;

  constructor() {

  }
}
