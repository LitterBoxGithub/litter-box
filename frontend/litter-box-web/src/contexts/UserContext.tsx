import { createContext } from 'react';
import { UserContextType } from '../models/types';

export const initialUserContextValue: UserContextType = {
  darkTheme: false,
  currentUser: {
    firstName: "Ramir",
    lastName: "TestLastName",
    auth: true,
  },
  currentPet: {
    petName: "Eevee"
  }
}   // should make this initial object come from constants file -- auth could be contained here

export const UserContext = createContext<UserContextType>(initialUserContextValue);