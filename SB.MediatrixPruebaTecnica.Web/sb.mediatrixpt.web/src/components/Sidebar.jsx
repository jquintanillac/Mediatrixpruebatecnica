// src/components/Sidebar.js
import React from 'react';
import './Sidebar.css';

const Sidebar = () => {
  return (
    <aside className="sidebar">
      <div className="logo">
        <h1>SB</h1>
        <p>Superintendencia de Bancos<br />República Dominicana</p>
      </div>
      <nav>
        <ul>
          <li><a href="#">Inicio</a></li>
          <li><a href="#">Consulta</a></li>
          <li><a href="#">Crear Registro</a></li>
        </ul>
      </nav>
    </aside>
  );
};

export default Sidebar;
