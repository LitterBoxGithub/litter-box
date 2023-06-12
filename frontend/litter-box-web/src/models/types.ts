import { Guid } from 'guid-typescript';

import {
  PetSpecies,
  PetMassSize,
  PetVolumeSize,
} from './enums';

export type User = {
  id: Guid | string,
  email: string,
  firstName: string,
  lastName: string,
  city: string,
}

export type Pet = {
  id: Guid | string,
  userId: Guid | string,
  name: string,
  city: string,
  petSpecies?: PetSpecies,
  petMassSize?: PetMassSize,
  petVoumeSize?: PetVolumeSize,
}

export type Match = {
  userId1: Guid | string,
  userId2?: Guid | string,
  petId1: Guid | string,
  petId2?: Guid | string,
}

export type Message = {
  matchId: Guid | string,
  authorId: Guid | string,
  messageContent: string,
}

export type Photo = {
  userId: Guid | string,
  petId: Guid | string,
  photoKey: string,
}

export type UserContextType = {
  darkTheme: boolean,
  currentUser: {
    firstName: string,
    lastName: string,
    auth: boolean,
  },
  currentPet: {
    petName: string,
  }
}