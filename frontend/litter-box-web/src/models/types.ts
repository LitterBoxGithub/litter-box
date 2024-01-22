import {
  PetSpecies,
  PetMassSize,
  PetVolumeSize,
} from './enums';

export type User = {
  id: string,
  email: string,
  firstName: string,
  lastName: string,
  city: string,
}

export type Pet = {
  id: string,
  userId: string,
  name: string,
  city: string,
  petSpecies?: PetSpecies,
  petMassSize?: PetMassSize,
  petVolumeSize?: PetVolumeSize,
}

export type Match = {
  userId1: string,
  userId2?: string,
  petId1: string,
  petId2?: string,
}

export type Message = {
  matchId: string,
  authorId: string,
  messageContent: string,
}

export type Photo = {
  userId: string,
  petId: string,
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