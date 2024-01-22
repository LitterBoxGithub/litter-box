import { Box, Card,} from '@mui/material';

const SettingsContainer = () => {
  const dev = true;
  return (
    <Box>
      <Card
        style={{ width: '80%', height: '80%' }}
        variant='outlined'
      >
        Settings
      </Card>
    </Box>
  );
}
export default SettingsContainer;