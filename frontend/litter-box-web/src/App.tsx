import React, { useContext } from 'react';
import { BrowserRouter, Routes, Route, Link } from "react-router-dom";
import { Stack, Tooltip, Toolbar, AppBar } from '@mui/material';
import GitHubIcon from '@mui/icons-material/GitHub';
import PestControlRodentIcon from '@mui/icons-material/PestControlRodent';
import PetsIcon from '@mui/icons-material/Pets';
import AgricultureIcon from '@mui/icons-material/Agriculture';
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

  return (
    <div className="App">
      <BrowserRouter>
        <Stack>
          <Stack sx={{ margin: 0, padding: 0 }}>
            
          </Stack>
          <Stack sx={{ margin: 0, padding: 0 }}>
            <Routes>
              <Route path={routes.matching} element={<MatchingContainer />} />
              <Route path={routes.chats} element={<ChatsContainer />} />
              <Route path={routes.kennel} element={<KennelContainer />} />
              <Route path={routes.settings} element={<SettingsContainer />} />
            </Routes>
          </Stack>
          <Stack sx={{ margin: 0, padding: 0 }}>
            <AppBar position="fixed" color="primary" sx={{ top: 'auto', bottom: 0, backgroundColor: 'white' }}>
              <Stack sx={{ display: 'flex', flexDirection: 'row', justifyContent: 'space-around', padding: '8px' }}>
                <Tooltip title='Find Pet Matches'>
                  <Link to={routes.matching}>
                    <PestControlRodentIcon fontSize='large' color='action' />
                  </Link>
                </Tooltip>
                <Tooltip title='Pet Chats'>
                  <Link to={routes.chats}>
                    <GitHubIcon fontSize='large' color='action' />
                  </Link>
                </Tooltip>
                <Tooltip title='My Kennel'>
                  <Link to={routes.kennel}>
                    <PetsIcon fontSize='large' color='action' />
                  </Link>
                </Tooltip>
                <Tooltip title='Settings'>
                  <Link to={routes.settings}>
                    <AgricultureIcon fontSize='large' color='action' />
                  </Link>
                </Tooltip>
              </Stack>
            </AppBar>
          </Stack>
        </Stack>
      </BrowserRouter>
    </div>
  );
}

export default App;
