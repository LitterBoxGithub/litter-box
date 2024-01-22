import { useState } from 'react';
import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import { Stack, BottomNavigation, BottomNavigationAction } from '@mui/material';
import GitHubIcon from '@mui/icons-material/GitHub';
import PestControlRodentIcon from '@mui/icons-material/PestControlRodent';
import PetsIcon from '@mui/icons-material/Pets';
import SettingsIcon from '@mui/icons-material/Settings';
import MatchingContainer from './containers/MatchingContainer';
import ChatsContainer from './containers/ChatsContainer';
import KennelContainer from './containers/KennelContainer';
import SettingsContainer from './containers/SettingsContainer';
import './App.css';

const App = () => {
  const routes = {
    matching: '/',
    chats: '/chats',
    kennel: '/kennel',
    settings: '/settings'
  };

  const [signalRInput, setSignalRInput] = useState('');

  return (
    <div className="App">
      <div>
        SignalR Tester
        <input type="text" value={signalRInput} onChange={(e) => setSignalRInput(e.target.value)}/>
      </div>
      <BrowserRouter>
        <Stack sx={{ margin: 0, padding: 0 }}>
          <Routes>
            <Route path={routes.matching} element={<MatchingContainer />} />
            <Route path={routes.chats} element={<ChatsContainer />} />
            <Route path={routes.kennel} element={<KennelContainer petName={"rook"} />} />
            <Route path={routes.settings} element={<SettingsContainer />} />
          </Routes>
        </Stack>
        <BottomNavigation sx={{ position: 'sticky', width: '100%', bottom: '0', }}>
          <BottomNavigationAction component={Link} to={routes.matching} label='Find Matches' icon={<PestControlRodentIcon />}/>
          <BottomNavigationAction component={Link} to={routes.chats} label='Chats' icon={<GitHubIcon />}/>
          <BottomNavigationAction component={Link} to={routes.kennel} label='My Kennel' icon={<PetsIcon />}/>
          <BottomNavigationAction component={Link} to={routes.settings} label='Settings' icon={<SettingsIcon />}/>
        </BottomNavigation>
      </BrowserRouter>
    </div>
  );
}

export default App;
