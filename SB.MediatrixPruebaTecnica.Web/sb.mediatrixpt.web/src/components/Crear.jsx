// src/components/Crear.js
import React from 'react';

const Crear = () => {
  return (
    <div>
      <h3>Crear Registro</h3>
      <form>
        <label htmlFor="nombre">Nombre:</label>
        <input type="text" id="nombre" name="nombre" />
        <button type="submit">Guardar</button>
      </form>
    </div>
  );
};

export default Crear;
