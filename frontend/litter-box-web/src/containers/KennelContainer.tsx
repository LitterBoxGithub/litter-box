import {  Box, Card, Fab, Stack } from '@mui/material';
import { useState } from 'react';
import PetCard from '../components/PetCard';

import { Pet } from '../models/types';
import mockData from '../mock/mockData';
import AddIcon from '@mui/icons-material/Add';
import RemoveIcon from '@mui/icons-material/Remove';

interface KennelContainerProps {
  petName: string;
}

const KennelContainer = ({ petName }: KennelContainerProps) => {
  const mockUserPets = mockData.mockPets.slice(0,3);
  const [userPets, setUserPets] = useState<Pet[]>(mockUserPets);
  
  return (
    <Box>
      <Card
        style={{ width: '80%', height: '80%' }}
        variant='outlined'
      >
        {
          userPets.map((pet) => (
            <PetCard petName={petName} pet={pet}/>
          ))
        }
      </Card>
      <Stack sx={{ display: 'flex', flexDirection: 'row', justifyContent: 'space-between', padding: '16px', bottom: '3em' }}>
        <Fab color="primary">
          <RemoveIcon />
        </Fab>
        <Fab color="primary">
          <AddIcon />
        </Fab>
      </Stack>
    </Box>
  );
}

export default KennelContainer;