import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import { createTheme, ThemeProvider } from '@mui/material';
import CssBaseline from '@mui/material/CssBaseline';
import { ContextProvider } from './hooks/useStateContext';

const darkTheme = createTheme({
  palette: {
    mode: 'dark',
  },
});

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <ContextProvider>
      <ThemeProvider theme={darkTheme}>
        <CssBaseline />
        <App />
      </ThemeProvider>
    </ContextProvider>
  </React.StrictMode>
);
