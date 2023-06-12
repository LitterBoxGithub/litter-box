import { Box, Card } from '@mui/material';


const ChatsContainer = () => {
  return (
    <Box>
      <button>MyButton</button>
      <Card 
        style={{ width: '80%', height: '80%' }}
        variant='outlined'
      >
        PetChats
      </Card>
    </Box>
  );
}

export default ChatsContainer;