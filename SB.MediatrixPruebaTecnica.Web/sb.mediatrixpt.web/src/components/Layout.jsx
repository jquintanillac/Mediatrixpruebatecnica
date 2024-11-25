// src/components/Layout.js
import React from 'react';
import '../styles/Sidebar';
import '../styles/Header';
import '../styles/Layout.css'; // Estilos del layout

const Layout = ({ children }) => {
  return (
    <div className="layout">
      <Sidebar />
      <div className="main-content">
        <Header />
        <div className="content">{children}</div>
      </div>
    </div>
  );
};

export default Layout;
