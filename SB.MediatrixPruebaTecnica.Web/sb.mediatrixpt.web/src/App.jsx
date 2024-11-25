// src/App.js
import React, { useState } from 'react';
import Layout from './components/Layout';
import Listar from './components/Listar';
import Crear from './components/Crear';

function App() {
  const [vista, setVista] = useState('listar'); // Controla la vista actual

  return (
    <Layout>
      <div className="tabs">
        <button onClick={() => setVista('listar')}>Listar</button>
        <button onClick={() => setVista('crear')}>Crear Registro</button>
      </div>
      {vista === 'listar' && <Listar />}
      {vista === 'crear' && <Crear />}
    </Layout>
  );
}

export default App;

