import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Result from './components/Result';
import Quiz from './components/Quiz';
import Layout from './components/Layout';

function App() {
  return (
     <BrowserRouter>
      <Routes>
        <Route path='/' element={<Layout />}>
          <Route path='/' element={<Quiz />} />
          <Route path='/result' element={<Result />} />
        </Route>
      </Routes>
     </BrowserRouter>
  );
}

export default App;
