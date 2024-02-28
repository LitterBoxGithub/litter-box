import React from 'react'
import { Pet } from '../models/types';
import { Stack } from '@mui/material';

interface PetCardProps {
  pet: Pet;
  petName: string;
}

const PetCard = ({ pet, petName }: PetCardProps) => {
  return (
    <Stack sx={{ overflowY: 'visible '}}>
      {petName}
      <li key={pet.id}>
        <h3>{pet.name}</h3>
        <p> hello pets!!</p>
        <p>Species: {pet.petSpecies}</p>
        <p>Mass Size: {pet.petMassSize}</p>
        <p>Volume Size: {pet.petVolumeSize}</p>
      </li>
      <img src="https://product-images.tcgplayer.com/276973.jpg"/>
    </Stack>
  );
}

export default PetCard;